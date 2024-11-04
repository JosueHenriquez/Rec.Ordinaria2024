using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refuerzo2024.Controller.Asignaturas;

namespace Refuerzo2024.View.Asignaturas
{
    public partial class FrmViewAsignaturas : Form
    {
        public FrmViewAsignaturas()
        {
            InitializeComponent();
            ControllerAsignaturas controllerAsignaturas = new ControllerAsignaturas(this);
        }
    }
}
