using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{

    public partial class Form1 : Form
    {


        private bool pausa;

        private int time;

        private int n;

        private List<Proceso> procesosNuevos = new List<Proceso>();
        private List<Proceso> procesosListos = new List<Proceso>();
        private List<Proceso> procesoEjecucion = new List<Proceso>();
        private List<Proceso> procesosBloqueados = new List<Proceso>();
        private List<Proceso> procesosTerminados = new List<Proceso>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procesosListosBS.DataSource = procesosListos;
            procesosBloqueadosBS.DataSource = procesosBloqueados;
            procesoActualBS.DataSource = procesoEjecucion;
            procesosTerminadosBS.DataSource = procesosTerminados;



            (new NumeroProcesos()).ShowDialog();

            foreach (Proceso proces in Proceso.procesos)
            {
                procesosNuevos.Add(proces);
            }

            time = 0;
            labelTime.Text = time.ToString();
            labelProcesosNuevos.Text = procesosNuevos.Count.ToString();

            int i = 0;
            while (procesosNuevos.Count > 0)
            {
                if (i == 5)
                    break;
                procesosNuevos[0].TiempoLlegada = time;
                procesosListos.Add(procesosNuevos[0]);
                procesosNuevos.RemoveAt(0);
                i++;

            }


            while (procesosListos.Count > 0)
            {
                labelProcesosNuevos.Text = procesosNuevos.Count.ToString();
                procesoEjecucion.Add(procesosListos[0]);
                procesosListos.RemoveAt(0);

                while (procesoEjecucion[0].TiempoRestante > 0)
                {
                 

                    procesoEjecucion[0].TiempoTranscurrido++;
                    procesoEjecucion[0].TiempoRestante--;
                    switch (procesoEjecucion[0].Operacion)
                    {
                        case "+":
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 + procesoEjecucion[0].Dato2).ToString();
                            break;
                        case "-":
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 - procesoEjecucion[0].Dato2).ToString();
                            break;
                        case "*":
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 * procesoEjecucion[0].Dato2).ToString();
                            break;
                        case "/":
                            if (procesoEjecucion[0].Dato2 == 0) procesoEjecucion[0].Dato2 = 1;
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 / procesoEjecucion[0].Dato2).ToString();
                            break;
                        case "residuo":
                            if (procesoEjecucion[0].Dato2 == 0) procesoEjecucion[0].Dato2 = 1;
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 % procesoEjecucion[0].Dato2).ToString();
                            break;
                        case "potencia":
                            procesoEjecucion[0].Resultado = ((int)(Math.Pow(Convert.ToDouble(procesoEjecucion[0].Dato1), Convert.ToDouble(procesoEjecucion[0].Dato2)))).ToString();
                            break;
                        case "porcentaje":
                            procesoEjecucion[0].Resultado = (procesoEjecucion[0].Dato1 * procesoEjecucion[0].Dato2 / 100).ToString();
                            break;
                        default:
                            break;
                    }

                    System.Threading.Thread.Sleep(500);
                    time++;
                    labelTime.Text = time.ToString();

                    procesosListosBS.ResetBindings(false);
                    procesosBloqueadosBS.ResetBindings(false);
                    procesosTerminadosBS.ResetBindings(false);
                    procesoActualBS.ResetBindings(false);

                    Application.DoEvents();

                    if (pausa)
                    {
                        procesoEjecucion[0].TiempoTranscurrido--;
                        procesoEjecucion[0].TiempoRestante++;
                        time--;
                    }
                }

                if (procesoEjecucion[0].TiempoRestante <= 0)
                {
                    procesoEjecucion[0].TiempoFinalización = time;
                    procesoEjecucion[0].TiempoRetorno = procesoEjecucion[0].TiempoFinalización - procesoEjecucion[0].TiempoLlegada;
                    procesoEjecucion[0].TiempoServicio = procesoEjecucion[0].TiempoTranscurrido;
                    procesoEjecucion[0].TiempoEspera = procesoEjecucion[0].TiempoRetorno - procesoEjecucion[0].TiempoServicio;
                    procesosTerminados.Add(procesoEjecucion[0]);
                    procesoEjecucion.Clear();
                }

                if ((procesosListos.Count + procesoEjecucion.Count + procesosBloqueados.Count) != 5
                    && procesosNuevos.Count != 0)
                {
                    procesosNuevos[0].TiempoLlegada = time;
                    procesosListos.Add(procesosNuevos[0]);
                    procesosNuevos.RemoveAt(0);

                }


            }

            procesoEjecucion.Add(new Proceso("", "", 0, 0, 0, 0, "0"));
            procesosListosBS.ResetBindings(false);
            procesosBloqueadosBS.ResetBindings(false);
            procesosTerminadosBS.ResetBindings(false);
            procesoActualBS.ResetBindings(false);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                case 'W':
                    procesoEjecucion[0].TiempoRestante = 0;
                    procesoEjecucion[0].Resultado = "ERROR";
                    break;
                case 'p':
                case 'P':
                    pausa = true;
                    break;
                case 'c':
                case 'C':
                    pausa = false;
                    break;
                case 'e':
                case 'E':                  
                    procesosBloqueados.Add(procesoEjecucion[0]);
                                        
                    break;
                default:
                    break;
            }


        }
    }
}
