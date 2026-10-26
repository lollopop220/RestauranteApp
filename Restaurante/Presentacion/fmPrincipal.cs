using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Presentacion
{
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        //metodo para abrir ventana dentro de un panel
        private void abrirFormH(object formHija)
        {
            //preguntar si el panel contenedor tiene componentes 

            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
                //elimina todo lo que tiene el contenedor

            }
            Form fh = formHija as Form; //forzar objeto formhija como formulario
            fh.TopLevel = false; //no es un formulario principal
            fh.Dock = DockStyle.Fill; // rellenar el panel 
            this.pnlContenedor.Controls.Add(fh); //agregar ventana ala contenedor
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            pnlSubCajas.Visible = true;
        }

        private void btnEditarCaja_Click(object sender, EventArgs e)
        {
            pnlSubCajas.Visible = false;
        }

        private void btnMovsCaja_Click(object sender, EventArgs e)
        {
            pnlSubCajas.Visible = true;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            abrirFormH(new MenuRoles());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormH(new FmUsuarios());
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
