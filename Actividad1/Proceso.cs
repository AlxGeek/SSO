using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Proceso
    {
        public static List<Proceso> procesos = new List<Proceso>();

        public Proceso(string programador,
        string operacion,
        int dato1,
        int dato2,
        int tiempoMaximo,
        int id, string resultado)
        {
            Programador = programador;
            Operacion = operacion;
            Dato1 = dato1;
            Dato2 = dato2;
            TiempoMaximo = tiempoMaximo;
            Id = id;
            Resultado = resultado;
        }

        public Proceso(
        string operacion,
        int dato1,
        int dato2,
        int tiempoMaximo,
        int id, string resultado)
        {
            Operacion = operacion;
            Dato1 = dato1;
            Dato2 = dato2;
            TiempoRestante = TiempoMaximo = tiempoMaximo;
            Id = id;
            Resultado = resultado;

            TiempoTranscurrido = 0;
            TiempoBloqueado = 0;
            TiempoEspera = 0;
            TiempoRespuesta = -1;
        }

        private string programador;
        private string operacion;
        private int dato1;
        private int dato2;
        private int tiempoMaximo;
        private int id;
        private string resultado;
        private int tiempoRestante;
        private int tiempoTranscurrido;
        private int lote;

        private float tiempoLlegada;
        private float tiempoFinalización;
        private float tiempoRetorno;
        private float tiempoRespuesta;
        private float tiempoEspera;
        private float tiempoServicio;
        private float tiempoBloqueado;


        public string Programador
        {
            get
            {
                return programador;
            }

            set
            {
                programador = value;
            }
        }

        public string Operacion
        {
            get
            {
                return operacion;
            }

            set
            {
                operacion = value;
            }
        }

        public int Dato1
        {
            get
            {
                return dato1;
            }

            set
            {
                dato1 = value;
            }
        }

        public int Dato2
        {
            get
            {
                return dato2;
            }

            set
            {
                dato2 = value;
            }
        }

        public int TiempoMaximo
        {
            get
            {
                return tiempoMaximo;
            }

            set
            {
                tiempoMaximo = value;
            }
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

        public string Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public int TiempoRestante
        {
            get
            {
                return tiempoRestante;
            }

            set
            {
                tiempoRestante = value;
            }
        }

        public int TiempoTranscurrido
        {
            get
            {
                return tiempoTranscurrido;
            }

            set
            {
                tiempoTranscurrido = value;
            }
        }

        public int Lote
        {
            get
            {
                return lote;
            }

            set
            {
                lote = value;
            }
        }

        public float TiempoServicio
        {
            get
            {
                return tiempoServicio;
            }

            set
            {
                tiempoServicio = value;
            }
        }

        public float TiempoEspera
        {
            get
            {
                return tiempoEspera;
            }

            set
            {
                tiempoEspera = value;
            }
        }

        public float TiempoRespuesta
        {
            get
            {
                return tiempoRespuesta;
            }

            set
            {
                tiempoRespuesta = value;
            }
        }

        public float TiempoRetorno
        {
            get
            {
                return tiempoRetorno;
            }

            set
            {
                tiempoRetorno = value;
            }
        }

        public float TiempoFinalización
        {
            get
            {
                return tiempoFinalización;
            }

            set
            {
                tiempoFinalización = value;
            }
        }

        public float TiempoLlegada
        {
            get
            {
                return tiempoLlegada;
            }

            set
            {
                tiempoLlegada = value;
            }
        }

        public float TiempoBloqueado
        {
            get
            {
                return tiempoBloqueado;
            }

            set
            {
                tiempoBloqueado = value;
            }
        }
    }
}
