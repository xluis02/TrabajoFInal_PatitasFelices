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
    public partial class FormVeterinario : Form
    {
        private int id_sede;
        private NVeterinario nVeterinario = new NVeterinario();

        public FormVeterinario(int id_sede)
        {
            InitializeComponent();
            this.id_sede = id_sede;
            MostrarVeterinarios(nVeterinario.ListarTodo(id_sede));
        }

        private void MostrarVeterinarios(List<Veterinarios> veterinarios)
        {
            dgVeterinarios.DataSource = null;
            if (veterinarios.Count == 0)
            {
                return;
            }
            else
            {
                dgVeterinarios.DataSource = veterinarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbEspecialidad.Text == "" || tbCodigoColegiatura.Text == "" || cbGenero.Text == "" || tbCorreo.Text == "" || tbNumero.Text == "")
            {
                MessageBox.Show("Ingrese todos sus datos en los campos por favor");
                return;
            }


            Veterinarios veterinario = new Veterinarios()
            {
                NombreCompleto = tbNombre.Text,
                Especialidad = tbEspecialidad.Text,
                CodigoColegiatura = tbCodigoColegiatura.Text,
                Genero = cbGenero.Text,
                CorreoElectronico = tbCorreo.Text,
                NumeroTelefonico = tbNumero.Text,
                // Setear el FK
                SedeId = id_sede
            };

            String mensaje = nVeterinario.Registrar(veterinario);
            MessageBox.Show(mensaje);

            MostrarVeterinarios(nVeterinario.ListarTodo(id_sede));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbEspecialidad.Text == "" || tbCodigoColegiatura.Text == "" || cbGenero.Text == "" || tbCorreo.Text == "" || tbNumero.Text == "")
            {
                MessageBox.Show("Ingrese todos sus datos en los campos por favor");
                return;
            }

            if (dgVeterinarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int id_veterinario = int.Parse(dgVeterinarios.SelectedRows[0].Cells[0].Value.ToString());

            Veterinarios veterinario = new Veterinarios()
            {
                VeterinarioId = id_veterinario,
                NombreCompleto = tbNombre.Text,
                Especialidad = tbEspecialidad.Text,
                CodigoColegiatura = tbCodigoColegiatura.Text,
                Genero = cbGenero.Text,
                CorreoElectronico = tbCorreo.Text,
                NumeroTelefonico = tbNumero.Text,
            };

            String mensaje = nVeterinario.Modificar(veterinario);
            MessageBox.Show(mensaje);

            MostrarVeterinarios(nVeterinario.ListarTodo(id_sede));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgVeterinarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_veterinario = int.Parse(dgVeterinarios.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nVeterinario.Eliminar(id_veterinario);
            MessageBox.Show(mensaje);

            MostrarVeterinarios(nVeterinario.ListarTodo(id_sede));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
