using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private object listWiew1;
        private object empleados;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var listado = EmpleadoController.GetEmpleados();
            if(listado.Count > 0)
            {
                foreach(var empleado in listado)
                {
                    listView1.Items.Add(empleado.EmpleadoId.ToString());
                    listView1.Items.Add(empleado.Nombre.ToString());
                    listView1.Items.Add(empleado.Edad.ToString());
                    listView1.Items.Add(empleado.Funcion.ToString());
                    listView1.Items.Add(empleado.Basico.ToString());
                    listView1.Items.Add(empleado.Horas.ToString());
                    listView1.Items.Add(empleado.Antiguedad.ToString());
                }
            }
        }
    }
}
