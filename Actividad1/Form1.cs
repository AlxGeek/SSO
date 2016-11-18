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


        private bool pausa, noBloqueado;

        private int time;

        static public int quantum = 4;

        private int n;

        private List<Marco> marcos = new List<Marco>();

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
            marcos.Add(new Marco(0, "100%"));
            marcos.Add(new Marco(1, "100%"));
            for (int ii = 2; ii < 32; ii++)
                marcos.Add(new Marco(ii, "0%"));

            marcoBindingSource.DataSource = marcos;
            procesosNuevosBS.DataSource = procesosNuevos;
            procesosListosBS.DataSource = procesosListos;
            procesosBloqueadosBS.DataSource = procesosBloqueados;
            procesoActualBS.DataSource = procesoEjecucion;
            procesosTerminadosBS.DataSource = procesosTerminados;



            (new NumeroProcesos()).ShowDialog();

            foreach (Proceso proces in Proceso.procesos)
            {
                proces.Estado = "Nuevo";
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


                int tamAux = procesosNuevos[0].Tamanio;
                bool hayEspacio = false;
                for (int ii = 2; ii < 32; ii++)
                {
                    if (marcos[ii].Memorian == 0)
                    {
                        if (tamAux >= 4)
                        {
                            marcos[ii].Memorian = 4;
                            tamAux -= 4;
                            procesosNuevos[0].IdMarcos.Add(ii);
                        }
                        else
                        {
                            marcos[ii].Memorian = tamAux;
                            procesosNuevos[0].IdMarcos.Add(ii);
                            hayEspacio = true;
                            break;
                        }
                    }
                }
                if (hayEspacio)
                {
                    procesosNuevos[0].TiempoLlegada = time;
                    procesosNuevos[0].Estado = "Listo";
                    procesosListos.Add(procesosNuevos[0]);
                    procesosNuevos.RemoveAt(0);
                    i++;
                }
                else
                {
                    foreach (int p in procesosNuevos[0].IdMarcos)
                        marcos[p].Memorian = 0;
                    break;
                }

            }


            while (procesosListos.Count > 0 || procesosBloqueados.Count > 0)
            {
                noBloqueado = true;
                labelProcesosNuevos.Text = procesosNuevos.Count.ToString();

                if (procesosListos.Count > 0)
                {
                    procesosListos[0].Estado = "Ejecucion";
                    procesoEjecucion.Add(procesosListos[0]);
                    procesosListos.RemoveAt(0);

                    if (procesoEjecucion[0].TiempoRespuesta == -1)
                    {
                        procesoEjecucion[0].TiempoRespuesta = time - procesoEjecucion[0].TiempoLlegada;
                    }

                    int nquantum = 0;
                    while (procesoEjecucion[0].TiempoRestante > 0 && noBloqueado)
                    {
                        foreach (Proceso p in procesosBloqueados)
                        {
                            p.TiempoBloqueado++;
                        }

                        foreach (Proceso p in procesosListos)
                        {
                            p.TiempoEspera++;
                        }

                        for (int j = 0; j < procesosBloqueados.Count; j++)
                        {
                            if (procesosBloqueados[j].TiempoBloqueado >= 10)
                            {
                                procesosBloqueados[j].Estado = "Listo";
                                procesosListos.Add(procesosBloqueados[j]);
                                procesosBloqueados.RemoveAt(j);
                                j--;
                            }
                        }

                        procesoEjecucion[0].TiempoTranscurrido++;
                        procesoEjecucion[0].TiempoRestante--;
                        procesoEjecucion[0].TiempoServicio = procesoEjecucion[0].TiempoTranscurrido;


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

                        marcoBindingSource.ResetBindings(false);
                        procesosNuevosBS.ResetBindings(false);
                        procesosListosBS.ResetBindings(false);
                        procesosBloqueadosBS.ResetBindings(false);
                        procesosTerminadosBS.ResetBindings(false);
                        procesoActualBS.ResetBindings(false);

                        Application.DoEvents();

                        if (pausa)
                        {
                            foreach (Proceso p in procesosBloqueados)
                                p.TiempoBloqueado--;
                            procesoEjecucion[0].TiempoTranscurrido--;
                            procesoEjecucion[0].TiempoServicio = procesoEjecucion[0].TiempoTranscurrido;
                            procesoEjecucion[0].TiempoRestante++;
                            time--;
                            nquantum--;
                        }

                        nquantum++;
                        if (nquantum >= quantum && procesoEjecucion[0].TiempoRestante != 0)
                        {
                            procesosListos.Add(procesoEjecucion[0]);
                            break;
                        }

                    }

                    if (procesoEjecucion[0].TiempoRestante <= 0)
                    {
                        procesoEjecucion[0].TiempoFinalización = time;
                        procesoEjecucion[0].TiempoRetorno = procesoEjecucion[0].TiempoFinalización - procesoEjecucion[0].TiempoLlegada;
                        procesoEjecucion[0].TiempoServicio = procesoEjecucion[0].TiempoTranscurrido;
                        procesoEjecucion[0].TiempoEspera = procesoEjecucion[0].TiempoRetorno - procesoEjecucion[0].TiempoServicio;
                        if (procesoEjecucion[0].Id != -1)
                        {
                            procesoEjecucion[0].Estado = "Terminado";

                            foreach (int p in procesoEjecucion[0].IdMarcos)
                                marcos[p].Memorian = 0;

                            procesosTerminados.Add(procesoEjecucion[0]);


                        }

                    }

                    procesoEjecucion.Clear();

                }
                else
                {
                    procesoEjecucion.Add(new Proceso("", "", 0, 0, 0, -1, "0"));
                    while (procesosListos.Count <= 0)
                    {

                        foreach (Proceso p in procesosBloqueados)
                        {
                            p.TiempoBloqueado++;
                        }

                        foreach (Proceso p in procesosListos)
                        {
                            p.TiempoEspera++;
                        }

                        for (int j = 0; j < procesosBloqueados.Count; j++)
                        {
                            if (procesosBloqueados[j].TiempoBloqueado >= 10)
                            {
                                procesosBloqueados[j].Estado = "Listo";
                                procesosListos.Add(procesosBloqueados[j]);
                                procesosBloqueados.RemoveAt(j);
                                j--;
                            }
                        }

                        System.Threading.Thread.Sleep(500);
                        time++;
                        labelTime.Text = time.ToString();

                        marcoBindingSource.ResetBindings(false);
                        procesosNuevosBS.ResetBindings(false);
                        procesosListosBS.ResetBindings(false);
                        procesosBloqueadosBS.ResetBindings(false);
                        procesosTerminadosBS.ResetBindings(false);
                        procesoActualBS.ResetBindings(false);

                        Application.DoEvents();

                        if (pausa)
                        {
                            foreach (Proceso p in procesosBloqueados)
                                p.TiempoBloqueado--;
                            time--;
                        }

                        procesoEjecucion.Clear();
                    }
                }



                while ((procesosListos.Count + procesoEjecucion.Count + procesosBloqueados.Count) < 5
                    && procesosNuevos.Count != 0)
                {

                    int tamAux = procesosNuevos[0].Tamanio;
                    bool hayEspacio = false;
                    for (int ii = 2; ii < 32; ii++)
                    {
                        if (marcos[ii].Memorian == 0)
                        {
                            if (tamAux >= 4)
                            {
                                marcos[ii].Memorian = 4;
                                tamAux -= 4;
                                procesosNuevos[0].IdMarcos.Add(ii);
                            }
                            else
                            {
                                marcos[ii].Memorian = tamAux;
                                procesosNuevos[0].IdMarcos.Add(ii);
                                hayEspacio = true;
                                break;
                            }
                        }
                    }
                    if (hayEspacio)
                    {

                        procesosNuevos[0].TiempoLlegada = time;
                        procesosNuevos[0].Estado = "Listo";
                        procesosListos.Add(procesosNuevos[0]);
                        procesosNuevos.RemoveAt(0);
                    }
                    else
                    {
                        foreach (int p in procesosNuevos[0].IdMarcos)
                            marcos[p].Memorian = 0;
                        break;
                    }
                }


            }

            procesoEjecucion.Add(new Proceso("", "", 0, 0, 0, 0, "0"));
            procesosListosBS.ResetBindings(false);
            procesosBloqueadosBS.ResetBindings(false);
            procesosTerminadosBS.ResetBindings(false);
            procesoActualBS.ResetBindings(false);
        }

        private void buttonQuantum_Click(object sender, EventArgs e)
        {
            DialogQuantum dg = new DialogQuantum();
            dg.ShowDialog();
            quantumLabel.Text = quantum.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'b':
                case 'B':
                    List<Proceso> allProcess = procesosNuevos.Concat(procesosListos.Concat(procesoEjecucion.Concat(procesosBloqueados.Concat(procesosTerminados).ToList()).ToList()).ToList()).ToList();
                    foreach (Proceso p in allProcess)
                    {
                        //p.TiempoFinalización = time;
                        //p.TiempoRetorno = p.TiempoFinalización - p.TiempoLlegada;
                        p.TiempoServicio = p.TiempoTranscurrido;
                        //p.TiempoEspera = p.TiempoRetorno - p.TiempoServicio;

                    }
                    BCP bcp = new BCP(allProcess);
                    bcp.ShowDialog();
                    break;
                case 'u':
                case 'U':
                    procesosNuevos.Add(
                        new Proceso(
                        NumeroProcesos.operations[NumeroProcesos.rnd.Next(0, NumeroProcesos.operations.Length)], NumeroProcesos.rnd.Next(1, 100),
                        NumeroProcesos.rnd.Next(1, 100),
                        NumeroProcesos.rnd.Next(5, 15),
                        NumeroProcesos.i++, "0", "Nuevo", NumeroProcesos.rnd.Next(1, 12))
                        );

                    labelProcesosNuevos.Text = procesosNuevos.Count.ToString();

                    break;
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
                    if (procesoEjecucion.Count != 0 && procesoEjecucion[0].Id != -1)
                    {
                        procesoEjecucion[0].TiempoBloqueado = 0;
                        procesoEjecucion[0].Estado = "Bloqueado";
                        procesosBloqueados.Add(procesoEjecucion[0]);
                        noBloqueado = false;
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
