using Refuerzo2024.Model.DAO;
using Refuerzo2024.View.Asignaturas;
using Refuerzo2024.View.Estudiantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refuerzo2024.Controller.Asignaturas
{
    internal class ControllerAsignaturas
    {
        FrmViewAsignaturas objAsignaturas;

        public ControllerAsignaturas(FrmViewAsignaturas objAsignaturas)
        {
            this.objAsignaturas = objAsignaturas;
            //Manejar eventos que surjan en la vista
            objAsignaturas.Load += new EventHandler(CargaIncial);
            objAsignaturas.btnAgregar.Click += new EventHandler(RegistrarAsignaturas);
            objAsignaturas.btnActualizar.Click += new EventHandler(ActualizarAsignaturas);
            objAsignaturas.btnEliminar.Click += new EventHandler(EliminarAsignatura);
            objAsignaturas.btnBuscar.Click += new EventHandler(BuscarAsignatura);
            objAsignaturas.dgvAsignaturas.CellClick += new DataGridViewCellEventHandler(SeleccionarDato);
        }

        public void CargaIncial(object sender, EventArgs e)
        {
            LlenarComboEspecialidades();
            LlenarDataGridViewAsignaturas();
        }


        private void LlenarComboEspecialidades()
        {
            //Se crea objeto del DAOEstudiantes para accesar a todos los metodos contenidos en la clase.
            DAOAsignaturas obj = new DAOAsignaturas();
            //Se crea un DataSet que almacenará los valores que retorne el metodo.
            DataSet ds = obj.ObtenerEspecialidades();
            //Llenamos el combobox
            objAsignaturas.cmbEspecialidad.DataSource = ds.Tables["Especialidades"];
            //Se indica que campo se mostrará al usuario
            objAsignaturas.cmbEspecialidad.DisplayMember = "nombreEspecialidad";
            //Se indica que valor será seleccionado dependiendo de lo que elija el usuario
            objAsignaturas.cmbEspecialidad.ValueMember = "idEspecialidad";
        }

        private void LlenarDataGridViewAsignaturas()
        {
            //Se crea objeto del DAOEstudiantes para accesar a todos los metodos contenidos en la clase.
            DAOAsignaturas obj = new DAOAsignaturas();
            //Se crea un DataSet que almacenará los valores que retorne el metodo.
            DataSet ds = obj.ObtenerAsignaturas();
            //Llenamos el combobox
            objAsignaturas.dgvAsignaturas.DataSource = ds.Tables["Asignaturas"];
        }

        public void RegistrarAsignaturas(object sender, EventArgs e)
        {
            string name = objAsignaturas.tbNombre.Text.Trim();
            string codigo = objAsignaturas.tbcodigo.Text.Trim();
            string especialidad = objAsignaturas.cmbEspecialidad.Text.Trim();

            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(especialidad)))


            {
                 DAOAsignaturas data = new DAOAsignaturas();
                //Guardar en los atributos del DTO todos los valores contenidos en los componentes del formulario
                data.NombreAsignatura = objAsignaturas.tbNombre.Text.Trim();
                data.Codigo = objAsignaturas.tbcodigo.Text.Trim();
                data.IdEspecialidad = (int)objAsignaturas.cmbEspecialidad.SelectedValue;
                //Se invoca al metodo RegistrarEstudiante y se verifica si su retorno es TRUE, de ser así significa que los datos pudieron ser registrados correctamente, de lo contrario, no se pudo registrar los valores.
                if (data.RegistrarAsignatura() == true)
                {
                  MessageBox.Show("Datos registrados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  LlenarDataGridViewAsignaturas();
                }
               else
               {
                 MessageBox.Show("No se pudo guardar los datos", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
                LimpiarCampos(sender, e);
            }
            else
            {
                MessageBox.Show("Error al registrar, llena todos los campos", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarAsignaturas(object sender, EventArgs e)
        {
            string name = objAsignaturas.tbNombre.Text.Trim();
            string codigo = objAsignaturas.tbcodigo.Text.Trim();
            string especialidad = objAsignaturas.cmbEspecialidad.Text.Trim();

            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(especialidad)))


            {
                DAOAsignaturas data = new DAOAsignaturas();
                //Guardar en los atributos del DTO todos los valores contenidos en los componentes del formulario
                data.IdAsignaturas = int.Parse(objAsignaturas.tbId.Text.Trim().ToString());
                data.NombreAsignatura = objAsignaturas.tbNombre.Text.Trim();
                data.Codigo = objAsignaturas.tbcodigo.Text.Trim();
                data.IdEspecialidad = (int)objAsignaturas.cmbEspecialidad.SelectedValue;
                if (data.ActualizarAsignaturas() == true)
                {
                 MessageBox.Show("Los datos fueron actualizados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 LlenarDataGridViewAsignaturas();
                }
                else
                {
                 MessageBox.Show("Los datos no pudieron ser actualizados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarCampos(sender, e);
            }
            else
            {
                MessageBox.Show("Error al registrar, llena todos los campos", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void EliminarAsignatura(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(objAsignaturas.tbId.Text.Trim()))
            {
                MessageBox.Show("Seleccione un registro", "Seleccione un valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAOAsignaturas data = new DAOAsignaturas();
                data.IdAsignaturas = int.Parse(objAsignaturas.tbId.Text);
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (data.EliminarAsignaturas() == true)
                    {
                        MessageBox.Show("El dato fue eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGridViewAsignaturas();
                    }
                    else
                    {
                        MessageBox.Show("El registro no pudo ser eliminado", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void BuscarAsignatura(object sender, EventArgs e)
        {
            DAOAsignaturas data = new DAOAsignaturas();
            DataSet ds = data.BuscarAsignaturas(objAsignaturas.tbBuscar.Text.Trim());
            objAsignaturas.dgvAsignaturas.DataSource = ds.Tables["Asignaturas"];
        }

        public void SeleccionarDato(object sender, DataGridViewCellEventArgs e)
        {
            //Capturar la fila a la que se le dió click
            int pos = objAsignaturas.dgvAsignaturas.CurrentRow.Index;
            //Enviar los datos del DataGridView hacia los controles
            objAsignaturas.tbId.Text = objAsignaturas.dgvAsignaturas[0, pos].Value.ToString();
            objAsignaturas.tbNombre.Text = objAsignaturas.dgvAsignaturas[1, pos].Value.ToString();
            objAsignaturas.tbcodigo.Text = objAsignaturas.dgvAsignaturas[2, pos].Value.ToString();
            objAsignaturas.cmbEspecialidad.Text = objAsignaturas.dgvAsignaturas[3, pos].Value.ToString();
        }

        public void LimpiarCampos(object sender, EventArgs e)
        {
            objAsignaturas.tbId.Clear();
            objAsignaturas.tbNombre.Clear();
            objAsignaturas.tbcodigo.Clear();
            objAsignaturas.cmbEspecialidad.Text = "";
        }

    }
}
