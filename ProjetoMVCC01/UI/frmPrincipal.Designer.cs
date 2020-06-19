namespace ProjetoMVCC01
{
    partial class frmDados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.txtCpfC01 = new System.Windows.Forms.TextBox();
            this.txtNomeC01 = new System.Windows.Forms.TextBox();
            this.txtNomeMaeC01 = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpfC01
            // 
            this.txtCpfC01.BackColor = System.Drawing.Color.White;
            this.txtCpfC01.ForeColor = System.Drawing.Color.Black;
            this.txtCpfC01.Location = new System.Drawing.Point(9, 28);
            this.txtCpfC01.Name = "txtCpfC01";
            this.txtCpfC01.Size = new System.Drawing.Size(235, 20);
            this.txtCpfC01.TabIndex = 0;
            // 
            // txtNomeC01
            // 
            this.txtNomeC01.BackColor = System.Drawing.Color.White;
            this.txtNomeC01.ForeColor = System.Drawing.Color.Black;
            this.txtNomeC01.Location = new System.Drawing.Point(9, 77);
            this.txtNomeC01.Name = "txtNomeC01";
            this.txtNomeC01.Size = new System.Drawing.Size(321, 20);
            this.txtNomeC01.TabIndex = 1;
            // 
            // txtNomeMaeC01
            // 
            this.txtNomeMaeC01.BackColor = System.Drawing.Color.White;
            this.txtNomeMaeC01.ForeColor = System.Drawing.Color.Black;
            this.txtNomeMaeC01.Location = new System.Drawing.Point(9, 126);
            this.txtNomeMaeC01.Name = "txtNomeMaeC01";
            this.txtNomeMaeC01.Size = new System.Drawing.Size(321, 20);
            this.txtNomeMaeC01.TabIndex = 2;
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Enviar.FlatAppearance.BorderSize = 0;
            this.Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.ForeColor = System.Drawing.Color.White;
            this.Enviar.Location = new System.Drawing.Point(9, 152);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(147, 43);
            this.Enviar.TabIndex = 3;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 12);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Location = new System.Drawing.Point(6, 111);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(73, 13);
            this.lblNomeMae.TabIndex = 6;
            this.lblNomeMae.Text = "Nome da mãe";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(183, 152);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 43);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot_311-removebg-preview.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoMVCC01.Properties.Resources.Screenshot_311_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(342, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNomeMae);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.txtNomeMaeC01);
            this.Controls.Add(this.txtNomeC01);
            this.Controls.Add(this.txtCpfC01);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDados";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insira os dados";
            this.Load += new System.EventHandler(this.frmDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfC01;
        private System.Windows.Forms.TextBox txtNomeC01;
        private System.Windows.Forms.TextBox txtNomeMaeC01;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Enviar;
    }
}

