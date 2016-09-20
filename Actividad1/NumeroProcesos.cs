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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            for (int i = 0; i < n; i++)
            {
                //DatosProceso dp= new DatosProceso();
                //dp.ShowDialog();

                Proceso.procesos.Add(
                        new Proceso(
                        comboOperacion.Text, Convert.ToInt32(numericDato1.Value),
                        Convert.ToInt32(numericDato2.Value),
                        Convert.ToInt32(numericTimeMax.Value),
                        Convert.ToInt32(numericId.Value), 0)
                        );

            }
            this.Close();
        }
    }
}
