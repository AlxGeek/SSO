﻿using System;
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
        int id, int resultado)
        {
            Programador = programador;
            Operacion = operacion;
            Dato1 = dato1;
            Dato2 = dato2;
            TiempoMaximo = tiempoMaximo;
            Id = id;
            Resultado = resultado;
        }

        private string programador;
        private string operacion;
        private int dato1;
        private int dato2;
        private int tiempoMaximo;
        private int id;
        private int resultado;
        private int tiempoRestante;
        private int tiempoTranscurrido;
        private int lote;

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

        public int Resultado
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
    }
}
