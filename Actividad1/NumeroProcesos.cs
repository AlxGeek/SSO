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
    public partial class NumeroProcesos : Form
    {
        public NumeroProcesos()
        {
            InitializeComponent();
        }

        static public int i;
        static public string[] operations = new string[] { "+", "-", "*", "/", "residuo", "potencia", "porcentaje" };
        static public Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = (int)numericUpDown1.Value;
            
            for (i = 0; i < n; i++)
            {
                //DatosProceso dp= new DatosProceso();
                //dp.ShowDialog();

                Proceso.procesos.Add(
                        new Proceso(
                        operations[rnd.Next(0, operations.Length)], rnd.Next(1,100),
                        rnd.Next(1, 100),
                        rnd.Next(5, 15),
                        i, "0")
                        );

            }
            this.Close();
        }
    }
}
