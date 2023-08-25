using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class Empleados
    {
        public int Empleadoid { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Funcion { get; set; }
        public decimal Basico { get; set; }
        public int Horas { get; set; }
        public int Antiguedad { get; set; }
        public object EmpleadoId { get; internal set; }

        public Empleados(int empleadoid, string nombre, int edad, string funcion, decimal basico, int horas, int antiguedad)
        {
            Empleadoid = empleadoid;
            Nombre = nombre;
            Edad = edad;
            Funcion = funcion;
            Basico = basico;
            Horas = horas;
            Antiguedad = antiguedad;
        }
        public Empleados() 
        {
            
        }
    }
}
