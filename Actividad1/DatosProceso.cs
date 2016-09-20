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
    public partial class DatosProceso : Form
    {// holi
        public DatosProceso()
        {
            InitializeComponent();
            comboOperacion.SelectedIndex = 0;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (Proceso proc in Proceso.procesos) {
                if (proc.Id == Convert.ToInt32(numericId.Value))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Proceso.procesos.Add(
                    new Proceso(textProgramador.Text,
                    comboOperacion.Text, Convert.ToInt32(numericDato1.Value),
                    Convert.ToInt32(numericDato2.Value),
                    Convert.ToInt32(numericTimeMax.Value),
                    Convert.ToInt32(numericId.Value), 0)
                    );
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: El ID ya esta asignado.");
            }
        }
    }
}
