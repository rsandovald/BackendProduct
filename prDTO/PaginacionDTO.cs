using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prDTO
{
    public class PaginacionDTO
    {
        public int Pagina { get; set; } = 1;
        private int recordsPorPagina = 10;
        private readonly int cantidadMaximaRecordsPorPagina = 50;

        public int RecordPorPagina
        {
            get
            {
                return this.recordsPorPagina;
            }
            set
            {
                recordsPorPagina = (value > this.cantidadMaximaRecordsPorPagina ? this.cantidadMaximaRecordsPorPagina : value);
            }

        }

    }
}
