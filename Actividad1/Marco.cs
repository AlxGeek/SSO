using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class Marco
    {
        private int id;
        private string idProceso;
        private string memoriaUsada;
        private int memorian;
        private string estado;

        public Marco(int id, int memoria)
        {
            Id = id;            
            Memorian = memoria;            
        }

        public Marco(int id, int memoria, string estado)
        {
            Id = id;                      
            Estado = estado;
            Memorian = memoria;
        }

        public Marco(int id, int memoria, string estado, string idproceso)
        {
            Id = id;
            Estado = estado;
            Memorian = memoria;
            IdProceso = idproceso;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string MemoriaUsada
        {
            get
            {
                return memoriaUsada;
            }

            set
            {
                memoriaUsada = value;
            }
        }

        public int Memorian
        {
            get
            {
                return memorian;
            }

            set
            {
                memorian = value;
                switch (memorian)
                {
                    case 0:
                        memoriaUsada = "0% " + estado;
                        break;
                    case 1:
                        memoriaUsada = "25% " + estado;
                        break;
                    case 2:
                        memoriaUsada = "50% " + estado;
                        break;
                    case 3:
                        memoriaUsada = "75% " + estado;
                        break;
                    case 4:
                        memoriaUsada = "100% " + estado;
                        break;

                    default:
                        break;
                }
                
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
                switch (memorian)
                {
                    case 0:
                        memoriaUsada = "0%"; //+ estado;
                        break;
                    case 1:
                        memoriaUsada = "25% " + estado;
                        break;
                    case 2:
                        memoriaUsada = "50% " + estado;
                        break;
                    case 3:
                        memoriaUsada = "75% " + estado;
                        break;
                    case 4:
                        memoriaUsada = "100% " + estado;
                        break;

                    default:
                        break;
                }
            }
        }

        public string IdProceso
        {
            get
            {
                return idProceso;
            }

            set
            {
                idProceso = value;
            }
        }
    }


}
