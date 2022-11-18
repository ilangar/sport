namespace Sport1
{
    partial class perfilEnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfilEnt));
            this.btnNuevoJug = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.flowLayoutJug = new System.Windows.Forms.FlowLayoutPanel();
            this.EliminarPerfil = new System.Windows.Forms.Button();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoJug
            // 
            this.btnNuevoJug.Location = new System.Drawing.Point(770, 388);
            this.btnNuevoJug.Name = "btnNuevoJug";
            this.btnNuevoJug.Size = new System.Drawing.Size(136, 98);
            this.btnNuevoJug.TabIndex = 0;
            this.btnNuevoJug.Text = "Agregar jugador";
            this.btnNuevoJug.UseVisualStyleBackColor = true;
            this.btnNuevoJug.Click += new System.EventHandler(this.BtnAgregarJug_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAtras.BackgroundImage = global::Sport1.Properties.Resources.Botón_volver_a_la_pagina_anterior;
            this.btnVolverAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.Location = new System.Drawing.Point(1192, 12);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(67, 69);
            this.btnVolverAtras.TabIndex = 1;
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.BtnVolverAtras_Click);
            // 
            // flowLayoutJug
            // 
            this.flowLayoutJug.AutoScroll = true;
            this.flowLayoutJug.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutJug.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutJug.Location = new System.Drawing.Point(474, 180);
            this.flowLayoutJug.Name = "flowLayoutJug";
            this.flowLayoutJug.Size = new System.Drawing.Size(256, 448);
            this.flowLayoutJug.TabIndex = 2;
            this.flowLayoutJug.WrapContents = false;
            this.flowLayoutJug.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutJug_Paint);
            // 
            // EliminarPerfil
            // 
            this.EliminarPerfil.Location = new System.Drawing.Point(1065, 388);
            this.EliminarPerfil.Name = "EliminarPerfil";
            this.EliminarPerfil.Size = new System.Drawing.Size(75, 23);
            this.EliminarPerfil.TabIndex = 3;
            this.EliminarPerfil.Text = "Eliminar perfil";
            this.EliminarPerfil.UseVisualStyleBackColor = true;
            this.EliminarPerfil.Click += new System.EventHandler(this.EliminarPerfil_Click);
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUser.Font = new System.Drawing.Font("Montserrat Alternates Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUser.Location = new System.Drawing.Point(731, 12);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(138, 51);
            this.lblNomUser.TabIndex = 7;
            this.lblNomUser.Text = "label1";
            // 
            // perfilEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.EliminarPerfil);
            this.Controls.Add(this.flowLayoutJug);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnNuevoJug);
            this.DoubleBuffered = true;
            this.Name = "perfilEnt";
            this.Text = "perfilEnt";
            this.Load += new System.EventHandler(this.PerfilEnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarJug;
        public System.Windows.Forms.Button btnNuevoJug;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutJug;
        private System.Windows.Forms.Button EliminarPerfil;
        private System.Windows.Forms.Label lblNomUser;
    }
}