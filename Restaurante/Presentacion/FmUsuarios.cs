using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Objetos;
using RestauranteG1.Logica;
namespace Restaurante.Presentacion
{
    public partial class FmUsuarios : Form
    {
        public FmUsuarios()
        {
            InitializeComponent();
        }

        Estructuras almacen = new Estructuras();

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nomUsr = "";
            string clave = "";

            string error = "";
            if (txtId.Text.Equals(""))
            {
                error = error + " -Identificacion- ";
            }
            else
            {
                id = int.Parse(txtId.Text);
            }

            if (txtnomUsr.Text.Equals(""))
            {
                error = error + " -Nombre de usuario- ";
            }
            else
            {
                nomUsr = txtnomUsr.Text;
            }

            if (txtClave.Text.Equals(""))
            {
                error = error + " -Contraseña- ";
            }
            else
            {
                clave = txtClave.Text;
            }

            int idRol = cmbRol.SelectedIndex;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string correo = txtCorreo.Text;
            int estado = cmbEstado.SelectedIndex;

            if (!error.Equals(""))
            {
                MessageBox.Show("DEBE DE COMPLETAR LOS CAMPOS DE: "
                    + error, "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                Usuario miUsuario = new Usuario();
                miUsuario.id = id;
                miUsuario.clave = clave;
                miUsuario.nomUsr = nomUsr;
                miUsuario.idRol = idRol;
                miUsuario.nombre = nombre;
                miUsuario.apellidos = apellidos;
                miUsuario.correo = correo;
                miUsuario.estado = estado;

                Usuario encontrado = almacen.buscarUsuario(id);
                if (encontrado != null)
                {
                    almacen.modificarUsuario(miUsuario);
                }
                else
                {
                    miUsuario.id = almacen.siguienteUsuario();
                    almacen.AgregarUsuario(miUsuario);
                    txtId.Text = miUsuario.id.ToString();
                }

                grdUsuarios.DataSource = almacen.ObtenerUsuarios();
            }
        }

        private void FmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (!txtId.Text.Equals(""))
            {
                id = int.Parse(txtId.Text);

                Usuario encontrado = almacen.buscarUsuario(id);

                if (encontrado != null)
                {
                    txtnomUsr.Text = encontrado.nomUsr;
                    txtNombre.Text = encontrado.nombre;
                    txtClave.Text = encontrado.clave;
                    txtApellidos.Text = encontrado.apellidos;
                    txtCorreo.Text = encontrado.correo;
                    cmbEstado.SelectedIndex = encontrado.estado;
                    cmbRol.SelectedIndex = encontrado.idRol;

                    
                
                }

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (!txtId.Text.Equals(""))
            {
                id = int.Parse(txtId.Text);

                Usuario encontrado = almacen.buscarUsuario(id);

                if (encontrado != null)
                {
                    almacen.eliminarUsuario(id);
                    txtnomUsr.Text = "";
                    txtNombre.Text = "";
                    txtClave.Text = "";
                    txtApellidos.Text = "";
                    txtCorreo.Text = "";
                    cmbEstado.SelectedIndex = 0;
                    cmbRol.SelectedIndex = 0;

                    grdUsuarios.DataSource = almacen.ObtenerUsuarios();

                }
            }
        }
    }
}
