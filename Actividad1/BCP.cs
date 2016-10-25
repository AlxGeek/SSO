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
    public partial class BCP : Form
    {

        public BCP(List<Proceso> procesos)
        {
            
            InitializeComponent();
            this.KeyPress += BCP_KeyPress;
            this.dataGridView1.KeyPress += BCP_KeyPress;
            procesoBindingSource.DataSource = procesos;
        }

        private void BCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'c':
                case 'C':
                    this.Close();
                    break;

                default:
                    break;
            }
        }

    }
}
