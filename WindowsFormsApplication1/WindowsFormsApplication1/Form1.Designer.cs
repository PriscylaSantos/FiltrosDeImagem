namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImgemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizarImagemFiltradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarTamanhoOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(21, 45);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResultado.Location = new System.Drawing.Point(554, 45);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResultado.TabIndex = 2;
            this.pictureBoxResultado.TabStop = false;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.ItemHeight = 20;
            this.cmbFilterType.Location = new System.Drawing.Point(150, 551);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(268, 28);
            this.cmbFilterType.TabIndex = 46;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.salvarImgemToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click_1);
            // 
            // salvarImgemToolStripMenuItem
            // 
            this.salvarImgemToolStripMenuItem.Name = "salvarImgemToolStripMenuItem";
            this.salvarImgemToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.salvarImgemToolStripMenuItem.Text = "Salvar Imagem";
            this.salvarImgemToolStripMenuItem.Click += new System.EventHandler(this.salvarImgemToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampliarToolStripMenuItem,
            this.reduzirToolStripMenuItem,
            this.utilizarImagemFiltradaToolStripMenuItem,
            this.voltarTamanhoOriginalToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            this.ampliarToolStripMenuItem.Click += new System.EventHandler(this.ampliarToolStripMenuItem_Click);
            // 
            // reduzirToolStripMenuItem
            // 
            this.reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            this.reduzirToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.reduzirToolStripMenuItem.Text = "Reduzir";
            this.reduzirToolStripMenuItem.Click += new System.EventHandler(this.reduzirToolStripMenuItem_Click);
            // 
            // utilizarImagemFiltradaToolStripMenuItem
            // 
            this.utilizarImagemFiltradaToolStripMenuItem.Name = "utilizarImagemFiltradaToolStripMenuItem";
            this.utilizarImagemFiltradaToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.utilizarImagemFiltradaToolStripMenuItem.Text = "Utilizar Imagem Filtrada";
            this.utilizarImagemFiltradaToolStripMenuItem.Click += new System.EventHandler(this.utilizarImagemFiltradaToolStripMenuItem_Click);
            // 
            // voltarTamanhoOriginalToolStripMenuItem
            // 
            this.voltarTamanhoOriginalToolStripMenuItem.Name = "voltarTamanhoOriginalToolStripMenuItem";
            this.voltarTamanhoOriginalToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.voltarTamanhoOriginalToolStripMenuItem.Text = "Voltar Tamanho Original";
            this.voltarTamanhoOriginalToolStripMenuItem.Click += new System.EventHandler(this.voltarTamanhoOriginalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.ClientSize = new System.Drawing.Size(1079, 591);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros de Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarImgemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduzirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizarImagemFiltradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarTamanhoOriginalToolStripMenuItem;
    }
}

