using Restaurante.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteG1.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurante.Presentacion
{
    public partial class MenuRoles : Form
    {
        
        Restaurante.Objetos.Roles miRol = new Restaurante.Objetos.Roles();
        Estructuras almacen = new Estructuras();

        public MenuRoles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            fmPrincipal prc = new fmPrincipal();
            prc.ShowDialog();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            txtId.Text = almacen.siguienteRol().ToString();
            CbEstado.SelectedIndex = 0;
            grdRoles.DataSource = almacen.ObtenerRoles();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Roles miRol = new Roles();
            string error = "";

            if (txtId.Text.Equals(""))
                error = error + "-Identificacion-";

            if (txtNombre.Text.Equals(""))
                error = error + "-Nombre-";

            if (!error.Equals(""))
            {
                MessageBox.Show("DEBE DE COMPLETAR LOS CAMPOS DE: "
                    + error, "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            else
            { 
              int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                int estado = CbEstado.SelectedIndex;

                miRol.id = id;
                miRol.nombre = nombre;
                miRol.estado = estado;

                Roles encontrado = almacen.buscarRol(id);
                if (encontrado != null)
                {
                    almacen.modificarRol(miRol);
                }
                else
                {
                    miRol.id = almacen.siguienteRol();
                    almacen.AgregarRol(miRol);
                }

                grdRoles.DataSource = almacen.ObtenerRoles();
                txtId.Text = almacen.siguienteRol().ToString();
                txtNombre.Text = "";
                CbEstado.SelectedIndex = 0;
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
