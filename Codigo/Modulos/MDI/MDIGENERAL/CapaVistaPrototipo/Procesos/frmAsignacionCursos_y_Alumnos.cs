using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorPrototipo;

namespace CapaVistaPrototipo.Procesos
{
    public partial class frmAsignacionCursos_y_Alumnos : Form
    {
        Controlador cn = new Controlador();
        public frmAsignacionCursos_y_Alumnos()
        {
            InitializeComponent();
            LlenarComboCarrera();
            LlenarComboSede();
            LlenarComboJornada();
            LlenarComboSeccion();
            LlenarComboAula();
            LlenarComboCurso();
            LlenarComboAlumno();

            actualizardatagriew();
            dtTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        string tabla = "asignacioncursosalumnos";


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarDataGRID(tabla);
            dtTabla.DataSource = dt;

        }

        public void LlenarComboCarrera()
        {
            List<string> concepto = cn.llenarCombo("codigo_carrera", "carreras");
            cb_carrera.Items.Clear();
            cb_carrera.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboSede()
        {
            List<string> concepto = cn.llenarCombo("codigo_sede", "sedes");
            cb_sede.Items.Clear();
            cb_sede.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboJornada()
        {
            List<string> concepto = cn.llenarCombo("codigo_jornada", "jornadas");
            cb_jornada.Items.Clear();
            cb_jornada.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboSeccion()
        {
            List<string> concepto = cn.llenarCombo("codigo_seccion", "secciones");
            cb_seccion.Items.Clear();
            cb_seccion.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboAula()
        {
            List<string> concepto = cn.llenarCombo("codigo_aula", "aulas");
            cb_Aula.Items.Clear();
            cb_Aula.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboCurso()
        {
            List<string> concepto = cn.llenarCombo("codigo_curso", "cursos");
            cb_curso.Items.Clear();
            cb_curso.Items.AddRange(concepto.ToArray());
        }

        public void LlenarComboAlumno()
        {
            List<string> concepto = cn.llenarCombo("carnet_alumno", "alumnos");
            cb_alumno.Items.Clear();
            cb_alumno.Items.AddRange(concepto.ToArray());
        }

        public void BuscarCarrera()
        {
            string tabla = "carreras";

            string columna = "codigo_carrera";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_carrera.SelectedItem != null) ? cb_carrera.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreCarrera.Text = row["nombre_carrera"].ToString();
                txt_estadoCarrera.Text = row["estatus_carrera"].ToString();
            }
            else
            {

            }
        }

        public void BuscarSede()
        {
            string tabla = "sedes";

            string columna = "codigo_sede";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_sede.SelectedItem != null) ? cb_sede.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreSede.Text = row["nombre_sede"].ToString();
                txt_estadoSede.Text = row["estatus_sede"].ToString();
            }
            else
            {

            }
        }

        public void BuscarJornada()
        {
            string tabla = "jornadas";

            string columna = "codigo_jornada";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_jornada.SelectedItem != null) ? cb_jornada.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreJornada.Text = row["nombre_jornada"].ToString();
                txt_estadoJornada.Text = row["estatus_jornada"].ToString();
            }
            else
            {

            }
        }


        public void BuscarSeccion()
        {
            string tabla = "secciones";

            string columna = "codigo_seccion";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_seccion.SelectedItem != null) ? cb_seccion.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreSeccion.Text = row["nombre_seccion"].ToString();
                txt_estadoSeccion.Text = row["estatus_seccion"].ToString();
            }
            else
            {

            }
        }

        public void BuscarAula()
        {
            string tabla = "aulas";

            string columna = "codigo_aula";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_Aula.SelectedItem != null) ? cb_Aula.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreAula.Text = row["nombre_aula"].ToString();
                txt_estadoAula.Text = row["estatus_aula"].ToString();
            }
            else
            {

            }
        }

        public void BuscarCurso()
        {
            string tabla = "cursos";

            string columna = "codigo_curso";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_curso.SelectedItem != null) ? cb_curso.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreCurso.Text = row["nombre_curso"].ToString();
                txt_estadoCurso.Text = row["estatus_curso"].ToString();
            }
            else
            {

            }
        }

        public void BuscarAlumno()
        {
            string tabla = "alumnos";

            string columna = "carnet_alumno";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_alumno.SelectedItem != null) ? cb_alumno.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                //  MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_nombreAlumno.Text = row["nombre_alumno"].ToString();
                txt_estadoAlumno.Text = row["estatus_alumno"].ToString();
            }
            else
            {

            }
        }

        public void GuardarDatos()
        {
            string tabla = "asignacioncursosalumnos";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            valores.Add("codigo_carrera", cb_carrera.SelectedItem);
            valores.Add("codigo_sede", cb_sede.SelectedItem);
            valores.Add("codigo_jornada", cb_jornada.SelectedItem);
            valores.Add("codigo_seccion", cb_seccion.SelectedItem);
            valores.Add("codigo_aula", cb_Aula.SelectedItem);
            valores.Add("codigo_curso", cb_curso.SelectedItem);
            valores.Add("carnet_alumno", cb_alumno.SelectedItem);
            valores.Add("nota_asignacioncursoalumnos", txt_nota.Text);


            cn.GuardarDatos(tabla, valores);

            //MessageBox.Show("Datos guardados");
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Deseas guardar la informacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // El usuario confirmó, ejecutar el código
                GuardarDatos();
                MessageBox.Show("Datos guadados");
            }
            else
            {
                // El usuario canceló, mostrar un mensaje
                MessageBox.Show("Datos no guardados");
            }
        }

        private void cb_carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCarrera();
        }

        private void cb_sede_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarSede();
        }

        private void cb_jornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarJornada();
        }

        private void cb_seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarSeccion();
        }

        private void cb_Aula_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarAula();
        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCurso();
        }

        private void cb_alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarAlumno();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ayudas_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"..\..\..\..\..\..\..\Ayuda\Modulos\Ayudas\AyudasByTech.chm";
            Help.ShowHelp(this, rutaAyuda, "Bancos.html");
        }
    }
}
