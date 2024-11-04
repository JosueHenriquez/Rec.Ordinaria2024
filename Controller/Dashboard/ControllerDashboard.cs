using Refuerzo2024.Model.Conexion;
using Refuerzo2024.View.Asignaturas;
using Refuerzo2024.View.Dashboard;
using Refuerzo2024.View.Estudiantes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refuerzo2024.Controller.Dashboard
{
    internal class ControllerDashboard
    {
        ViewDashboard object_Dashboard;
        Form currentForm;

        public ControllerDashboard(ViewDashboard vista)
        {
            this.object_Dashboard = vista;
            vista.probarConexiónToolStripMenuItem.Click += new EventHandler(ProbarConexion);
            vista.btnEstudiantes.Click += new EventHandler(AbrirFormEstudiantes);
            vista.btnAsignaturas.Click += new EventHandler(AbrirFormAsignaturas);
        }


        /// <summary>
        /// Método para abrir formularios dentro del panel contenedor del formulario principal
        /// </summary>
        /// <typeparam name="MiForm"></typeparam>
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Se declara objeto de tipo Form llamada formulario
            Form formulario;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que desea abrir <MiForm> posteriormente se guarda todo en el objeto de tipo formulario
            formulario = object_Dashboard.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe se procederá a crearlo de lo contrario solo se traerá al frente (ver clausula else)
            if (formulario == null)
            {
                //Se define un nuevo formulario para guardarse como nuevo objeto MiForm
                formulario = new MiForm();
                //Se especifica que el formulario debe mostrarse como ventana
                formulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Se establece que se abrira en todo el espacio del formulario padre
                formulario.Dock = DockStyle.Fill;
                //Se le asigna una opacidad de 0.75
                formulario.Opacity = 0.75;
                //Se evalua el formulario actual para verificar si es nulo
                if (currentForm != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    currentForm.Close();
                    //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                    object_Dashboard.PanelContenedor.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se está abriendo
                currentForm = formulario;
                //Se agregan los controles del nuevo formulario al panel contenedor
                object_Dashboard.PanelContenedor.Controls.Add(formulario);
                //Tag es una propiedad genérica disponible para la mayoría de los controles en aplicaciones .NET, incluyendo los paneles.
                object_Dashboard.PanelContenedor.Tag = formulario;
                //Se muestra el formulario en el panel contenedor
                formulario.Show();
                //Se trae al frente el formulario armado
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                //Se cierra el formulario actual para mostrar el nuevo formulario
                currentForm.Close();
                //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                object_Dashboard.PanelContenedor.Controls.Remove(currentForm);
            }
        }

        public void ProbarConexion(object sender, EventArgs e)
        {
            //Ejecutando el metodo obtener conexión el cual retorna un valor
            if (dbContext.obtenerConexion() != null)
            {
                MessageBox.Show("La conexión se realizó correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La conexión al servidor o a la base de datos no se pudo establecer correctamente.", "Proceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbrirFormEstudiantes(object sender, EventArgs e)
        {
            AbrirFormulario<ViewEstudiantes>();
        }

        public void AbrirFormAsignaturas(object sender, EventArgs e)
        {
            AbrirFormulario<FrmViewAsignaturas>();
        }
    }
}
