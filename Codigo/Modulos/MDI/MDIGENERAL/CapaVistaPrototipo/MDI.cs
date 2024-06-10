using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaPrototipo
{
    public partial class MDI : Form
    {
        Controlador cn = new Controlador();
        public MDI()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            // Button[] apps = { btn_precios, btn_generarBoleta };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cns.getAccesoApp(2001, apps[1]);
            //cns.getAccesoApp(2002, apps[2]);
            //cns.getAccesoApp(2003, apps[3]);
            //cns.getAccesoApp(2004, apps[4]);
            //cns.getAccesoApp(2005, apps[5]);
        }

        private void hideSubMenu()
        {
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
            if (PanelProcesos.Visible == true)
                PanelProcesos.Visible = false;
            if (panelReporte.Visible == true)
                panelReporte.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false;
        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Abrir(object abrirform)
        {
            if (this.panelMDI.Controls.Count > 0)
                this.panelMDI.Controls.RemoveAt(0);

            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.panelMDI.Controls.Add(fh);
            this.panelMDI.Tag = fh;
            fh.Show();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelProcesos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReporte);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "umg.chm");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mantemiento1_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.DavidCarrillo_MantenimientoAlumnos());
            hideSubMenu();
            cn.setBtitacora("9001", "Mant. Alumnos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.DavidCarrillo_MantenimientoCarreras());
            hideSubMenu();
            cn.setBtitacora("9002", "Mant. Cursos");
        }

        private void btn_Proceso1_Click(object sender, EventArgs e)
        {
            Abrir(new Procesos.frmAsignacionCursos_y_Alumnos());
            hideSubMenu();
            cn.setBtitacora("9003", "Pro. Asignacion de cursos y alumnos");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Abrir(new Mantenimientos.DavidCarrillo_MantenimientoCursos());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }
    }
}
