using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prRepository;
using prUtility;
using AutoMapper;
using prDTO;
using prEntidades;
using ProductsWebAPI.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ProductsWebAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/products")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class ProductsController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "products";

        public ProductsController(ApplicationDbContext context,
            IMapper mapper
            , IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.mapper = mapper;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        [HttpPost]
       
        public async Task<ActionResult> Post([FromForm] ProductAddUpdDTO productAddUpdDTO)
        {
            var product  = this.mapper.Map<Product>(productAddUpdDTO);
           
            if (productAddUpdDTO.IMAGE  != null)
            {
                product.URL_IMAGE = await this.almacenadorArchivos.GuardarArchivo(this.contenedor, productAddUpdDTO.IMAGE);
            }
           
            context.Add(product);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get([FromQuery] PaginacionDTO paginacionDTO)
        {
            var queryable = this.context.TB_PRODUCTS.AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnCabecera(queryable);
            var products = await queryable.OrderBy(x => x.NAME).Paginar(paginacionDTO).ToListAsync();
            var resultado = this.mapper.Map<List<ProductDTO>>(products);
            return resultado;
        }

        [HttpPut("{code}")]
        public async Task<ActionResult> Put(string code ,  [FromForm] ProductAddUpdDTO productAddUpdDTO)
        {
           
            var product = await this.context.TB_PRODUCTS.FirstOrDefaultAsync(x => x.PRODUCT_CODE == code);

            if (product == null)
            {
                return NotFound();
            }

            product = this.mapper.Map(productAddUpdDTO, product);

            if (productAddUpdDTO.IMAGE != null)
            {
                product.URL_IMAGE = await this.almacenadorArchivos.EditarArchivo(this.contenedor, productAddUpdDTO.IMAGE, product.URL_IMAGE);
            }

            await this.context.SaveChangesAsync();
            
            return NoContent();

        }


    }
}
