using System;
using System.Windows.Forms;
using Restaurante.Objetos;
using Restaurante.Presentacion;
using RestauranteG1.Logica;

namespace Restaurante
{
    public partial class fmLogin : Form
    {
        // Variable global
        Usuario miUsuario = new Usuario();
        Estructuras almacen = new Estructuras();

        public fmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            miUsuario.id = 1;
            miUsuario.nomUsr = "lollo";
            miUsuario.clave = "5858";
            miUsuario.idRol = 0;
            miUsuario.nombre = "Byron";
            miUsuario.apellidos = "Ramirez Arroyo";
            miUsuario.correo = "byron@gmail.com";
            miUsuario.estado = 0;
            almacen.AgregarUsuario(miUsuario);

            Usuario segundoUsuario = new Usuario();
            segundoUsuario.id = 2;
            segundoUsuario.nomUsr = "maria";
            segundoUsuario.clave = "1234";
            segundoUsuario.idRol = 1;
            segundoUsuario.nombre = "Maria";
            segundoUsuario.apellidos = "Lopez Mora";
            segundoUsuario.correo = "maria@gmail.com";
            segundoUsuario.estado = 1;
            almacen.AgregarUsuario(segundoUsuario);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            string error = "";

            // Validar usuario
            if (txtUsuario.Text.Equals(""))
            {
                error = error + " --Usuario-- ";
            }

            // Validar clave
            if (txtClave.Text.Equals(""))
            {
                error = error + " --Clave-- ";
            }

            // Si hay campos vacíos
            if (!error.Equals(""))
            {
                MessageBox.Show(
                    "Debe completar los campos de: " + error,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                // Comprobar usuario y contraseña
                int acceso = almacen.validarUsuario(txtUsuario.Text, txtClave.Text);

                if (acceso == 1)
                {
                   /* MessageBox.Show(
                        "Acceso Correcto",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );*/
                    fmPrincipal prc = new fmPrincipal();
                    prc.ShowDialog();
                    txtClave.Text = "";

                }
                else if (acceso == 2)
                {
                    MessageBox.Show(
                        "El usuario no está activo",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Datos Incorrectos",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = almacen.ObtenerUsuarios();
        }
    }
}
