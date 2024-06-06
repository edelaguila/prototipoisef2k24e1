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
    public partial class frmMantenimientoAlumnos : Form
    {
        public frmMantenimientoAlumnos()
        {
            InitializeComponent();
            this.navegador1.config("alumnos", this, "9001");
        }
    }
}
