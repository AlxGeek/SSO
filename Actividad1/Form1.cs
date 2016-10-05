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
        

        private bool flag;

        private int time;

        private int n, j, k;

        private List<Proceso> procesosNuevos= new List<Proceso>();
        private List<Proceso> procesosListos = new List<Proceso>();
        private List<Proceso> procesosEjecucion = new List<Proceso>();
        private List<Proceso> procesosBloqueados = new List<Proceso>();
        private List<Proceso> procesosTerminados = new List<Proceso>();

        private List<Proceso> procesoActual = new List<Proceso>();

        

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new NumeroProcesos()).ShowDialog();            
                        
            procesoBindingSource1.DataSource = procesoActual;
            procesoBindingSource2.DataSource = procesosTerminados;
            foreach (Proceso proces in Proceso.procesos)
            {                
                procesosNuevos.Add(proces);                
            }
            
            time = 0;
            labelTime.Text = time.ToString();
            labelProcesosNuevos.Text = procesosNuevos.Count.ToString();

            for (j = 0; j < lotes.Count; j++)
            {
                lotePrint = new List<Proceso>(lotes[j]);
                procesoBindingSource.DataSource = lotePrint;
                
                
                for (k = 0; k < lotes[j].Count; k++)
                {
                    procesoActual.Add(lotes[j][k]);
                    lotePrint.Remove(lotes[j][k]);
                    for (n = 0; n < lotes[j][k].TiempoMaximo; n++)
                    {
                        procesoActual[0].TiempoTranscurrido = n;
                        procesoActual[0].TiempoRestante = lotes[j][k].TiempoMaximo - n;
                        switch (procesoActual[0].Operacion)
                        {
                            case "+":
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 + lotes[j][k].Dato2).ToString();
                                break;
                            case "-":
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 - lotes[j][k].Dato2).ToString();
                                break;
                            case "*":
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 * lotes[j][k].Dato2).ToString();
                                break;
                            case "/":
                                if (lotes[j][k].Dato2 == 0) lotes[j][k].Dato2 = 1;
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 / lotes[j][k].Dato2).ToString();
                                break;
                            case "residuo":
                                if (lotes[j][k].Dato2 == 0) lotes[j][k].Dato2 = 1;
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 % lotes[j][k].Dato2).ToString();
                                break;
                            case "potencia":
                                lotes[j][k].Resultado = ((int)(Math.Pow(Convert.ToDouble(lotes[j][k].Dato1), Convert.ToDouble(lotes[j][k].Dato2)))).ToString();
                                break;
                            case "porcentaje":
                                lotes[j][k].Resultado = (lotes[j][k].Dato1 * lotes[j][k].Dato2 / 100).ToString();
                                break;
                            default:
                                break;
                        }

                        procesoBindingSource1.ResetBindings(false);
                        procesoBindingSource.ResetBindings(false);

                        Application.DoEvents();

                        System.Threading.Thread.Sleep(500);
                        time++;
                        labelTime.Text = time.ToString();

                        if (flag) { n--; time--; }
                    }
                    if (n != 51)
                        procesosTerminados.Add(lotes[j][k]);
                    procesoBindingSource2.ResetBindings(false);
                    procesoActual.Clear();
                }

            }
            procesoActual.Add(new Proceso("", "", 0, 0, 0, 0, "0"));

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                case 'W':
                    n = lotes[j][k].TiempoMaximo;
                    lotes[j][k].Resultado = "ERROR";
                    break;
                case 'p':
                case 'P':
                    flag = true;
                    break;
                case 'c':
                case 'C':
                    flag = false;
                    break;
                case 'e':
                case 'E':
                    lotePrint.Add(procesoActual[0]);
                    lotes[j].Add(procesoActual[0]);
                    n = 50;
                    break;
                default:
                    break;
            }


        }
    }
}
