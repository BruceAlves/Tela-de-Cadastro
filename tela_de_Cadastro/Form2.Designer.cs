namespace tela_de_Cadastro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvTelaCadastro = new System.Windows.Forms.DataGridView();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelaCadastro
            // 
            this.dgvTelaCadastro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTelaCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelaCadastro.Location = new System.Drawing.Point(30, 67);
            this.dgvTelaCadastro.Name = "dgvTelaCadastro";
            this.dgvTelaCadastro.RowTemplate.Height = 25;
            this.dgvTelaCadastro.Size = new System.Drawing.Size(474, 229);
            this.dgvTelaCadastro.TabIndex = 0;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(30, 38);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(357, 23);
            this.txtCampo.TabIndex = 1;
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntPesquisa.Location = new System.Drawing.Point(393, 36);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(111, 30);
            this.bntPesquisa.TabIndex = 2;
            this.bntPesquisa.Text = "Pesquisar";
            this.bntPesquisa.UseVisualStyleBackColor = false;
            this.bntPesquisa.Click += new System.EventHandler(this.bntPesquisa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(30, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(365, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar Todos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntPesquisa);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.dgvTelaCadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelaCadastro;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}