using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Marco
    {
        private int id;
        private string memoriaUsada;
        private int memorian;

        public Marco(int id, string memoria)
        {
            Id = id;
            MemoriaUsada = memoria;
            memorian = 0;


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
                        memoriaUsada = "0%";
                        break;
                    case 1:
                        memoriaUsada = "25%";
                        break;
                    case 2:
                        memoriaUsada = "50%";
                        break;
                    case 3:
                        memoriaUsada = "75%";
                        break;
                    case 4:
                        memoriaUsada = "100%";
                        break;

                    default:
                        break;
                }
                
            }
        }
    }


}
