using System;

namespace Restaurante.Presentacion
{
    partial class fmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.pnlSubCajas = new System.Windows.Forms.Panel();
            this.btnMovsCaja = new System.Windows.Forms.Button();
            this.btnEditarCaja = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlSubCajas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnRoles);
            this.panel1.Controls.Add(this.pnlSubCajas);
            this.panel1.Controls.Add(this.btnCajas);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 889);
            this.panel1.TabIndex = 0;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = global::Restaurante.Properties.Resources._00lo_ac30_210603_convertido_a_24x24;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(45, 323);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(170, 44);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Image = global::Restaurante.Properties.Resources._00lo_ac30_210603_convertido_a_24x24;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(45, 260);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(170, 44);
            this.btnRoles.TabIndex = 3;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // pnlSubCajas
            // 
            this.pnlSubCajas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSubCajas.Controls.Add(this.btnMovsCaja);
            this.pnlSubCajas.Controls.Add(this.btnEditarCaja);
            this.pnlSubCajas.Location = new System.Drawing.Point(0, 146);
            this.pnlSubCajas.Name = "pnlSubCajas";
            this.pnlSubCajas.Size = new System.Drawing.Size(248, 99);
            this.pnlSubCajas.TabIndex = 2;
            this.pnlSubCajas.Visible = false;
            // 
            // btnMovsCaja
            // 
            this.btnMovsCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovsCaja.Location = new System.Drawing.Point(26, 52);
            this.btnMovsCaja.Name = "btnMovsCaja";
            this.btnMovsCaja.Size = new System.Drawing.Size(201, 44);
            this.btnMovsCaja.TabIndex = 1;
            this.btnMovsCaja.Text = "Movimientos";
            this.btnMovsCaja.UseVisualStyleBackColor = true;
            this.btnMovsCaja.Click += new System.EventHandler(this.btnMovsCaja_Click);
            // 
            // btnEditarCaja
            // 
            this.btnEditarCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCaja.Location = new System.Drawing.Point(26, 0);
            this.btnEditarCaja.Name = "btnEditarCaja";
            this.btnEditarCaja.Size = new System.Drawing.Size(200, 46);
            this.btnEditarCaja.TabIndex = 0;
            this.btnEditarCaja.Text = "Edicion Cajas";
            this.btnEditarCaja.UseVisualStyleBackColor = true;
            this.btnEditarCaja.Click += new System.EventHandler(this.btnEditarCaja_Click);
            // 
            // btnCajas
            // 
            this.btnCajas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCajas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajas.Image = global::Restaurante.Properties.Resources._00lo_ac30_210603_convertido_a_24x24;
            this.btnCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajas.Location = new System.Drawing.Point(45, 96);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(170, 44);
            this.btnCajas.TabIndex = 1;
            this.btnCajas.Text = "Cajas";
            this.btnCajas.UseVisualStyleBackColor = false;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 56);
            this.panel2.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = global::Restaurante.Properties.Resources.regresar;
            this.btnRegresar.Location = new System.Drawing.Point(1206, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 44);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Restaurante.Properties.Resources.window_close;
            this.btnSalir.Location = new System.Drawing.Point(1256, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 44);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(410, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(441, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Restaurante";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlContenedor.Location = new System.Drawing.Point(249, 55);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1309, 834);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 889);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPrincipal";
            this.Text = "fmPrincipal";
            this.panel1.ResumeLayout(false);
            this.pnlSubCajas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirFormH(new FmUsuarios());
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Panel pnlSubCajas;
        private System.Windows.Forms.Button btnMovsCaja;
        private System.Windows.Forms.Button btnEditarCaja;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
    }
}