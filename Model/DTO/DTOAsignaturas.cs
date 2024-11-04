using Refuerzo2024.Model.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo2024.Model.DTO
{
    internal class DTOAsignaturas : dbContext
    {
        int idAsignaturas;
        string nombreAsignatura;
        string codigo;
        int idEspecialidad;

        public int IdAsignaturas { get => idAsignaturas; set => idAsignaturas = value; }
        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
    }
}
