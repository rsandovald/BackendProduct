using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prDTO; 

namespace prUtility
{
    public static class IQueryableExtension
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PaginacionDTO paginacionDTO)
        {
            return queryable
                .Skip((paginacionDTO.Pagina - 1) * paginacionDTO.RecordPorPagina)
                .Take(paginacionDTO.RecordPorPagina);

        }
    }
}
