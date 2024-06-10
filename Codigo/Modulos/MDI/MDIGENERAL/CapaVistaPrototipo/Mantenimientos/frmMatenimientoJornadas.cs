using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPrototipo.Mantenimientos
{
    public partial class frmMatenimientoJornadas : Form
    {
        public frmMatenimientoJornadas()
        {
            InitializeComponent();
            this.navegador1.config("jornadas", this, "9010");
        }
    }
}
