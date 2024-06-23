using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormSede : Form
    {
        private NSede nSede = new NSede();

        public FormSede()
        {
            InitializeComponent();
            MostrarSedes(nSede.ListarTodo());
        }

        private void MostrarSedes(List<Sedes> sedes)
        {
            dgSedes.DataSource = null;
            if (sedes.Count == 0)
            {
                return;
            }
            else
            {
                dgSedes.DataSource = sedes;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Ingrese los datos en los campos por favor");
                return;
            }

            Sedes sede = new Sedes()
            {
                NombreSede = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Telefono = tbTelefono.Text
            };

            String mensaje = nSede.Registrar(sede);
            MessageBox.Show(mensaje);

            MostrarSedes(nSede.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Ingrese los datos en los campos por favor");
                return;
            }

            if (dgSedes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int id_sede = int.Parse(dgSedes.SelectedRows[0].Cells[0].Value.ToString());

            Sedes sede = new Sedes()
            {
                SedeId = id_sede,
                NombreSede = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Telefono = tbTelefono.Text
            };

            String mensaje = nSede.Modificar(sede);
            MessageBox.Show(mensaje);

            MostrarSedes(nSede.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
