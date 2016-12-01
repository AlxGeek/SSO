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
    public partial class TablaPaginas : Form
    {

        List<Marco> marcos;
        public TablaPaginas(List<Marco> marcos_in)
        {
            InitializeComponent();

            marcos = marcos_in;

            marcoBindingSource.DataSource = marcos;

        }

    }
}
