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
        private List<List<Proceso>> lotes = new List<List<Proceso>>();

        private int time;

        private List<Proceso> procesoActual = new List<Proceso>();

        private List<Proceso> procesosTerminados = new List<Proceso>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new NumeroProcesos()).ShowDialog();
            int i = 0;
            List<Proceso> temp = new List<Proceso>();
            int loteN = 1;
            procesoBindingSource1.DataSource = procesoActual;
            procesoBindingSource2.DataSource = procesosTerminados;
            foreach (Proceso proces in Proceso.procesos)
            {
                proces.Lote = loteN;
                temp.Add(proces);
                i++;
                if (i == 5)
                {
                    loteN++;
                    i = 0;
                    lotes.Add(temp);
                    temp = new List<Proceso>();
                }
            }
            lotes.Add(temp);
            time = 0;
            labelTime.Text = time.ToString();

            for (int j = 0; j < lotes.Count; j++)
            {
                procesoBindingSource.DataSource = lotes[j];
                labelLA.Text = (j + 1).ToString();
                labelLP.Text = (lotes.Count - (j + 1)).ToString();
                for (int k = 0; k < lotes[j].Count; k++)
                {
                    procesoActual.Add(lotes[j][k]);
                    for (int n = 0; n < lotes[j][k].TiempoMaximo; n++)
                    {
                        procesoActual[0].TiempoTranscurrido = n;
                        procesoActual[0].TiempoRestante = lotes[j][k].TiempoMaximo - n;
                        switch (procesoActual[0].Operacion)
                        {
                            case "+":
                                lotes[j][k].Resultado = lotes[j][k].Dato1 + lotes[j][k].Dato2;
                                break;
                            case "-":
                                lotes[j][k].Resultado = lotes[j][k].Dato1 - lotes[j][k].Dato2;
                                break;
                            case "*":
                                lotes[j][k].Resultado = lotes[j][k].Dato1 * lotes[j][k].Dato2;
                                break;
                            case "/":
                                if (lotes[j][k].Dato2 == 0) lotes[j][k].Dato2 = 1;
                                lotes[j][k].Resultado = lotes[j][k].Dato1 / lotes[j][k].Dato2;
                                break;
                            case "residuo":
                                if (lotes[j][k].Dato2 == 0) lotes[j][k].Dato2 = 1;
                                lotes[j][k].Resultado = lotes[j][k].Dato1 % lotes[j][k].Dato2;
                                break;
                            case "potencia":
                                lotes[j][k].Resultado = (int)(Math.Pow(Convert.ToDouble(lotes[j][k].Dato1), Convert.ToDouble(lotes[j][k].Dato2)));
                                break;
                            case "porcentaje":
                                lotes[j][k].Resultado = lotes[j][k].Dato1 * lotes[j][k].Dato2 / 100;
                                break;
                            default:
                                break;
                        }

                        procesoBindingSource1.ResetBindings(false);

                        Application.DoEvents();

                        System.Threading.Thread.Sleep(500);
                        time++;
                        labelTime.Text = time.ToString();
                    }
                    procesosTerminados.Add(lotes[j][k]);
                    procesoBindingSource2.ResetBindings(false);
                    procesoActual.Clear();
                }

            }
            procesoActual.Add(new Proceso("", "", 0, 0, 0, 0, 0));

        }
    }
}
