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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.Seleciona = new System.Windows.Forms.Button();
            this.Salva = new System.Windows.Forms.Button();
            this.Reduzir = new System.Windows.Forms.Button();
            this.ampliar = new System.Windows.Forms.Button();
            this.FiltroMedia = new System.Windows.Forms.Button();
            this.FiltroMediana = new System.Windows.Forms.Button();
            this.FiltroMaximo = new System.Windows.Forms.Button();
            this.FiltroMinimo = new System.Windows.Forms.Button();
            this.FiltroSobelPreto = new System.Windows.Forms.Button();
            this.FiltroSobelBranco = new System.Windows.Forms.Button();
            this.FiltroPrewittPreto = new System.Windows.Forms.Button();
            this.FitroPrewittBranco = new System.Windows.Forms.Button();
            this.FiltrodeRobertsPreto = new System.Windows.Forms.Button();
            this.FiltroLaplace = new System.Windows.Forms.Button();
            this.FiltroLaplaceOriginal = new System.Windows.Forms.Button();
            this.FiltroCannys = new System.Windows.Forms.Button();
            this.FiltroRobertsBranco = new System.Windows.Forms.Button();
            this.FiltroModa = new System.Windows.Forms.Button();
            this.FiltroMediaPonderada = new System.Windows.Forms.Button();
            this.FiltroCannysBranco = new System.Windows.Forms.Button();
            this.PegarImagem = new System.Windows.Forms.Button();
            this.EscalaCinza = new System.Windows.Forms.Button();
            this.SubstituicaoUniformeHSI = new System.Windows.Forms.Button();
            this.SubstituicaoUniformeHSL = new System.Windows.Forms.Button();
            this.SubstituicaoUniformeHSV = new System.Windows.Forms.Button();
            this.SubstituicaoUniformeNTSCePAL = new System.Windows.Forms.Button();
            this.AlgoritmodePopulodidadeHSI = new System.Windows.Forms.Button();
            this.AlgorotmodePopulosidadeHSL = new System.Windows.Forms.Button();
            this.AlgoritmodepolulosidadeHSV = new System.Windows.Forms.Button();
            this.AlgoritmodePopulosidadeNTSCePAL = new System.Windows.Forms.Button();
            this.AlgoritmoCorteMedianoHSI = new System.Windows.Forms.Button();
            this.AlgoritmoCorteMedianoHSL = new System.Windows.Forms.Button();
            this.AlgoritmodeCorteMedianoHSV = new System.Windows.Forms.Button();
            this.AlgotimodeCorteMedianoNTSCePAL = new System.Windows.Forms.Button();
            this.EscalaCinzaHSL = new System.Windows.Forms.Button();
            this.EscalaCinzaHSV = new System.Windows.Forms.Button();
            this.EscalaCinzaNTSCePAL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(25, 74);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            //this.pictureBoxOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click);
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResultado.Location = new System.Drawing.Point(563, 74);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResultado.TabIndex = 2;
            this.pictureBoxResultado.TabStop = false;
            // 
            // Seleciona
            // 
            this.Seleciona.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.Seleciona.Location = new System.Drawing.Point(25, 580);
            this.Seleciona.Name = "Seleciona";
            this.Seleciona.Size = new System.Drawing.Size(171, 30);
            this.Seleciona.TabIndex = 3;
            this.Seleciona.Text = "Selecionar Imagem";
            this.Seleciona.UseVisualStyleBackColor = true;
            this.Seleciona.Click += new System.EventHandler(this.Seleciona_Click);
            // 
            // Salva
            // 
            this.Salva.Image = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.Salva.Location = new System.Drawing.Point(563, 580);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(171, 30);
            this.Salva.TabIndex = 4;
            this.Salva.Text = "Salvar Imagem";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Reduzir
            // 
            this.Reduzir.BackColor = System.Drawing.Color.White;
            this.Reduzir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.Reduzir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reduzir.Location = new System.Drawing.Point(25, 5);
            this.Reduzir.Name = "Reduzir";
            this.Reduzir.Size = new System.Drawing.Size(100, 30);
            this.Reduzir.TabIndex = 5;
            this.Reduzir.Text = "Zoom Redução";
            this.Reduzir.UseVisualStyleBackColor = false;
            this.Reduzir.Click += new System.EventHandler(this.Reduzir_Click);
            // 
            // ampliar
            // 
            this.ampliar.BackColor = System.Drawing.Color.White;
            this.ampliar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.ampliar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ampliar.Location = new System.Drawing.Point(25, 37);
            this.ampliar.Name = "ampliar";
            this.ampliar.Size = new System.Drawing.Size(100, 30);
            this.ampliar.TabIndex = 6;
            this.ampliar.Text = "Zoom Ampliação";
            this.ampliar.UseVisualStyleBackColor = false;
            this.ampliar.Click += new System.EventHandler(this.ampliar_Click);
            // 
            // FiltroMedia
            // 
            this.FiltroMedia.BackColor = System.Drawing.Color.White;
            this.FiltroMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroMedia.BackgroundImage")));
            this.FiltroMedia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroMedia.Location = new System.Drawing.Point(129, 6);
            this.FiltroMedia.Name = "FiltroMedia";
            this.FiltroMedia.Size = new System.Drawing.Size(100, 30);
            this.FiltroMedia.TabIndex = 7;
            this.FiltroMedia.Text = "Média";
            this.FiltroMedia.UseVisualStyleBackColor = false;
            this.FiltroMedia.Click += new System.EventHandler(this.FiltroMedia_Click);
            // 
            // FiltroMediana
            // 
            this.FiltroMediana.BackColor = System.Drawing.Color.White;
            this.FiltroMediana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroMediana.BackgroundImage")));
            this.FiltroMediana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroMediana.Location = new System.Drawing.Point(129, 38);
            this.FiltroMediana.Name = "FiltroMediana";
            this.FiltroMediana.Size = new System.Drawing.Size(100, 30);
            this.FiltroMediana.TabIndex = 8;
            this.FiltroMediana.Text = "Mediana";
            this.FiltroMediana.UseVisualStyleBackColor = false;
            this.FiltroMediana.Click += new System.EventHandler(this.FiltroMediana_Click);
            // 
            // FiltroMaximo
            // 
            this.FiltroMaximo.BackColor = System.Drawing.Color.White;
            this.FiltroMaximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroMaximo.BackgroundImage")));
            this.FiltroMaximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroMaximo.Location = new System.Drawing.Point(235, 6);
            this.FiltroMaximo.Name = "FiltroMaximo";
            this.FiltroMaximo.Size = new System.Drawing.Size(100, 30);
            this.FiltroMaximo.TabIndex = 9;
            this.FiltroMaximo.Text = "Máximo";
            this.FiltroMaximo.UseVisualStyleBackColor = false;
            this.FiltroMaximo.Click += new System.EventHandler(this.FiltroMaximo_Click);
            // 
            // FiltroMinimo
            // 
            this.FiltroMinimo.BackColor = System.Drawing.Color.White;
            this.FiltroMinimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroMinimo.BackgroundImage")));
            this.FiltroMinimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroMinimo.Location = new System.Drawing.Point(235, 38);
            this.FiltroMinimo.Name = "FiltroMinimo";
            this.FiltroMinimo.Size = new System.Drawing.Size(100, 30);
            this.FiltroMinimo.TabIndex = 10;
            this.FiltroMinimo.Text = "Mínimo";
            this.FiltroMinimo.UseVisualStyleBackColor = false;
            this.FiltroMinimo.Click += new System.EventHandler(this.FiltroMinimo_Click);
            // 
            // FiltroSobelPreto
            // 
            this.FiltroSobelPreto.BackColor = System.Drawing.Color.White;
            this.FiltroSobelPreto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroSobelPreto.BackgroundImage")));
            this.FiltroSobelPreto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroSobelPreto.Location = new System.Drawing.Point(447, 7);
            this.FiltroSobelPreto.Name = "FiltroSobelPreto";
            this.FiltroSobelPreto.Size = new System.Drawing.Size(100, 30);
            this.FiltroSobelPreto.TabIndex = 11;
            this.FiltroSobelPreto.Text = "Sobel Preto";
            this.FiltroSobelPreto.UseVisualStyleBackColor = false;
            this.FiltroSobelPreto.Click += new System.EventHandler(this.FiltroSobel_Click);
            // 
            // FiltroSobelBranco
            // 
            this.FiltroSobelBranco.BackColor = System.Drawing.Color.White;
            this.FiltroSobelBranco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroSobelBranco.BackgroundImage")));
            this.FiltroSobelBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroSobelBranco.Location = new System.Drawing.Point(447, 38);
            this.FiltroSobelBranco.Name = "FiltroSobelBranco";
            this.FiltroSobelBranco.Size = new System.Drawing.Size(100, 30);
            this.FiltroSobelBranco.TabIndex = 12;
            this.FiltroSobelBranco.Text = "Sobel Branco";
            this.FiltroSobelBranco.UseVisualStyleBackColor = false;
            this.FiltroSobelBranco.Click += new System.EventHandler(this.FiltroSobelBranco_Click);
            // 
            // FiltroPrewittPreto
            // 
            this.FiltroPrewittPreto.BackColor = System.Drawing.Color.White;
            this.FiltroPrewittPreto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroPrewittPreto.BackgroundImage")));
            this.FiltroPrewittPreto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroPrewittPreto.Location = new System.Drawing.Point(553, 7);
            this.FiltroPrewittPreto.Name = "FiltroPrewittPreto";
            this.FiltroPrewittPreto.Size = new System.Drawing.Size(100, 30);
            this.FiltroPrewittPreto.TabIndex = 13;
            this.FiltroPrewittPreto.Text = "Prewitt Preto";
            this.FiltroPrewittPreto.UseVisualStyleBackColor = false;
            this.FiltroPrewittPreto.Click += new System.EventHandler(this.FiltroPrewitt_Click);
            // 
            // FitroPrewittBranco
            // 
            this.FitroPrewittBranco.BackColor = System.Drawing.Color.White;
            this.FitroPrewittBranco.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.FitroPrewittBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FitroPrewittBranco.Location = new System.Drawing.Point(553, 39);
            this.FitroPrewittBranco.Name = "FitroPrewittBranco";
            this.FitroPrewittBranco.Size = new System.Drawing.Size(100, 30);
            this.FitroPrewittBranco.TabIndex = 14;
            this.FitroPrewittBranco.Text = "Prewitt Branco";
            this.FitroPrewittBranco.UseVisualStyleBackColor = false;
            this.FitroPrewittBranco.Click += new System.EventHandler(this.FitroPrewittBranco_Click);
            // 
            // FiltrodeRobertsPreto
            // 
            this.FiltrodeRobertsPreto.BackColor = System.Drawing.Color.White;
            this.FiltrodeRobertsPreto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltrodeRobertsPreto.BackgroundImage")));
            this.FiltrodeRobertsPreto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltrodeRobertsPreto.Location = new System.Drawing.Point(659, 7);
            this.FiltrodeRobertsPreto.Name = "FiltrodeRobertsPreto";
            this.FiltrodeRobertsPreto.Size = new System.Drawing.Size(100, 30);
            this.FiltrodeRobertsPreto.TabIndex = 15;
            this.FiltrodeRobertsPreto.Text = "Roberts Preto";
            this.FiltrodeRobertsPreto.UseVisualStyleBackColor = false;
            this.FiltrodeRobertsPreto.Click += new System.EventHandler(this.FiltrodeRobertsPreto_Click);
            // 
            // FiltroLaplace
            // 
            this.FiltroLaplace.BackColor = System.Drawing.Color.White;
            this.FiltroLaplace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroLaplace.BackgroundImage")));
            this.FiltroLaplace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroLaplace.Location = new System.Drawing.Point(765, 6);
            this.FiltroLaplace.Name = "FiltroLaplace";
            this.FiltroLaplace.Size = new System.Drawing.Size(100, 30);
            this.FiltroLaplace.TabIndex = 16;
            this.FiltroLaplace.Text = "Laplace";
            this.FiltroLaplace.UseVisualStyleBackColor = false;
            this.FiltroLaplace.Click += new System.EventHandler(this.FiltroLaplace_Click);
            // 
            // FiltroLaplaceOriginal
            // 
            this.FiltroLaplaceOriginal.BackColor = System.Drawing.Color.White;
            this.FiltroLaplaceOriginal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroLaplaceOriginal.BackgroundImage")));
            this.FiltroLaplaceOriginal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroLaplaceOriginal.Location = new System.Drawing.Point(765, 39);
            this.FiltroLaplaceOriginal.Name = "FiltroLaplaceOriginal";
            this.FiltroLaplaceOriginal.Size = new System.Drawing.Size(100, 30);
            this.FiltroLaplaceOriginal.TabIndex = 17;
            this.FiltroLaplaceOriginal.Text = "Laplace + Original";
            this.FiltroLaplaceOriginal.UseVisualStyleBackColor = false;
            this.FiltroLaplaceOriginal.Click += new System.EventHandler(this.FiltroLaplaceOriginal_Click);
            // 
            // FiltroCannys
            // 
            this.FiltroCannys.BackColor = System.Drawing.Color.White;
            this.FiltroCannys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroCannys.BackgroundImage")));
            this.FiltroCannys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroCannys.Location = new System.Drawing.Point(871, 6);
            this.FiltroCannys.Name = "FiltroCannys";
            this.FiltroCannys.Size = new System.Drawing.Size(100, 30);
            this.FiltroCannys.TabIndex = 18;
            this.FiltroCannys.Text = "Cannys";
            this.FiltroCannys.UseVisualStyleBackColor = false;
            this.FiltroCannys.Click += new System.EventHandler(this.FiltroCannys_Click);
            // 
            // FiltroRobertsBranco
            // 
            this.FiltroRobertsBranco.BackColor = System.Drawing.Color.White;
            this.FiltroRobertsBranco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroRobertsBranco.BackgroundImage")));
            this.FiltroRobertsBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroRobertsBranco.Location = new System.Drawing.Point(659, 39);
            this.FiltroRobertsBranco.Name = "FiltroRobertsBranco";
            this.FiltroRobertsBranco.Size = new System.Drawing.Size(100, 30);
            this.FiltroRobertsBranco.TabIndex = 19;
            this.FiltroRobertsBranco.Text = "Roberts Branco";
            this.FiltroRobertsBranco.UseVisualStyleBackColor = false;
            this.FiltroRobertsBranco.Click += new System.EventHandler(this.FiltroRobertsBranco_Click);
            // 
            // FiltroModa
            // 
            this.FiltroModa.BackColor = System.Drawing.Color.White;
            this.FiltroModa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroModa.BackgroundImage")));
            this.FiltroModa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroModa.Location = new System.Drawing.Point(341, 6);
            this.FiltroModa.Name = "FiltroModa";
            this.FiltroModa.Size = new System.Drawing.Size(100, 30);
            this.FiltroModa.TabIndex = 20;
            this.FiltroModa.Text = "Moda";
            this.FiltroModa.UseVisualStyleBackColor = false;
            this.FiltroModa.Click += new System.EventHandler(this.FiltroModa_Click);
            // 
            // FiltroMediaPonderada
            // 
            this.FiltroMediaPonderada.BackColor = System.Drawing.Color.White;
            this.FiltroMediaPonderada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiltroMediaPonderada.BackgroundImage")));
            this.FiltroMediaPonderada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroMediaPonderada.Location = new System.Drawing.Point(341, 38);
            this.FiltroMediaPonderada.Name = "FiltroMediaPonderada";
            this.FiltroMediaPonderada.Size = new System.Drawing.Size(100, 30);
            this.FiltroMediaPonderada.TabIndex = 21;
            this.FiltroMediaPonderada.Text = "Média Ponderada";
            this.FiltroMediaPonderada.UseVisualStyleBackColor = false;
            this.FiltroMediaPonderada.Click += new System.EventHandler(this.FiltroMediaPonderada_Click);
            // 
            // FiltroCannysBranco
            // 
            this.FiltroCannysBranco.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.FiltroCannysBranco.Location = new System.Drawing.Point(871, 39);
            this.FiltroCannysBranco.Name = "FiltroCannysBranco";
            this.FiltroCannysBranco.Size = new System.Drawing.Size(100, 30);
            this.FiltroCannysBranco.TabIndex = 22;
            this.FiltroCannysBranco.Text = "Cannys Branco";
            this.FiltroCannysBranco.UseVisualStyleBackColor = true;
            this.FiltroCannysBranco.Click += new System.EventHandler(this.FiltroCannysBranco_Click);
            // 
            // PegarImagem
            // 
            this.PegarImagem.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.PegarImagem.Location = new System.Drawing.Point(740, 580);
            this.PegarImagem.Name = "PegarImagem";
            this.PegarImagem.Size = new System.Drawing.Size(171, 30);
            this.PegarImagem.TabIndex = 23;
            this.PegarImagem.Text = "Pegar Imagem com Filtro";
            this.PegarImagem.UseVisualStyleBackColor = true;
            this.PegarImagem.Click += new System.EventHandler(this.PegarImagem_Click);
            // 
            // EscalaCinza
            // 
            this.EscalaCinza.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.EscalaCinza.Location = new System.Drawing.Point(977, 5);
            this.EscalaCinza.Name = "EscalaCinza";
            this.EscalaCinza.Size = new System.Drawing.Size(100, 30);
            this.EscalaCinza.TabIndex = 27;
            this.EscalaCinza.Text = "Cinza HSI";
            this.EscalaCinza.UseVisualStyleBackColor = true;
            this.EscalaCinza.Click += new System.EventHandler(this.EscalaCinza_Click);
            // 
            // SubstituicaoUniformeHSI
            // 
            this.SubstituicaoUniformeHSI.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.SubstituicaoUniformeHSI.Location = new System.Drawing.Point(1070, 87);
            this.SubstituicaoUniformeHSI.Name = "SubstituicaoUniformeHSI";
            this.SubstituicaoUniformeHSI.Size = new System.Drawing.Size(150, 30);
            this.SubstituicaoUniformeHSI.TabIndex = 28;
            this.SubstituicaoUniformeHSI.Text = "Substituição Uniforme HSI";
            this.SubstituicaoUniformeHSI.UseVisualStyleBackColor = true;
            this.SubstituicaoUniformeHSI.Click += new System.EventHandler(this.SubstituicaoUniformeHSI_Click);
            // 
            // SubstituicaoUniformeHSL
            // 
            this.SubstituicaoUniformeHSL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.SubstituicaoUniformeHSL.Location = new System.Drawing.Point(1070, 124);
            this.SubstituicaoUniformeHSL.Name = "SubstituicaoUniformeHSL";
            this.SubstituicaoUniformeHSL.Size = new System.Drawing.Size(150, 30);
            this.SubstituicaoUniformeHSL.TabIndex = 29;
            this.SubstituicaoUniformeHSL.Text = "Substituição Uniforme HSL";
            this.SubstituicaoUniformeHSL.UseVisualStyleBackColor = true;
            this.SubstituicaoUniformeHSL.Click += new System.EventHandler(this.SubstituicaoUniformeHSL_Click);
            // 
            // SubstituicaoUniformeHSV
            // 
            this.SubstituicaoUniformeHSV.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.SubstituicaoUniformeHSV.Location = new System.Drawing.Point(1070, 161);
            this.SubstituicaoUniformeHSV.Name = "SubstituicaoUniformeHSV";
            this.SubstituicaoUniformeHSV.Size = new System.Drawing.Size(150, 30);
            this.SubstituicaoUniformeHSV.TabIndex = 30;
            this.SubstituicaoUniformeHSV.Text = "Substituição Uniforme HSV";
            this.SubstituicaoUniformeHSV.UseVisualStyleBackColor = true;
            this.SubstituicaoUniformeHSV.Click += new System.EventHandler(this.SubstituicaoUniformeHSV_Click);
            // 
            // SubstituicaoUniformeNTSCePAL
            // 
            this.SubstituicaoUniformeNTSCePAL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.SubstituicaoUniformeNTSCePAL.Location = new System.Drawing.Point(1070, 198);
            this.SubstituicaoUniformeNTSCePAL.Name = "SubstituicaoUniformeNTSCePAL";
            this.SubstituicaoUniformeNTSCePAL.Size = new System.Drawing.Size(150, 35);
            this.SubstituicaoUniformeNTSCePAL.TabIndex = 31;
            this.SubstituicaoUniformeNTSCePAL.Text = "Substituição Uniforme NTSC/PAL";
            this.SubstituicaoUniformeNTSCePAL.UseVisualStyleBackColor = true;
            this.SubstituicaoUniformeNTSCePAL.Click += new System.EventHandler(this.SubstituicaoUniformeNTSCePAL_Click);
            // 
            // AlgoritmodePopulodidadeHSI
            // 
            this.AlgoritmodePopulodidadeHSI.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmodePopulodidadeHSI.Location = new System.Drawing.Point(1070, 258);
            this.AlgoritmodePopulodidadeHSI.Name = "AlgoritmodePopulodidadeHSI";
            this.AlgoritmodePopulodidadeHSI.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmodePopulodidadeHSI.TabIndex = 32;
            this.AlgoritmodePopulodidadeHSI.Text = "Populosidade HSI";
            this.AlgoritmodePopulodidadeHSI.UseVisualStyleBackColor = true;
            this.AlgoritmodePopulodidadeHSI.Click += new System.EventHandler(this.AlgoritmodePopulodidadeHSI_Click);
            // 
            // AlgorotmodePopulosidadeHSL
            // 
            this.AlgorotmodePopulosidadeHSL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgorotmodePopulosidadeHSL.Location = new System.Drawing.Point(1069, 294);
            this.AlgorotmodePopulosidadeHSL.Name = "AlgorotmodePopulosidadeHSL";
            this.AlgorotmodePopulosidadeHSL.Size = new System.Drawing.Size(150, 30);
            this.AlgorotmodePopulosidadeHSL.TabIndex = 33;
            this.AlgorotmodePopulosidadeHSL.Text = "Populosidade HSL";
            this.AlgorotmodePopulosidadeHSL.UseVisualStyleBackColor = false;
            this.AlgorotmodePopulosidadeHSL.Click += new System.EventHandler(this.AlgorotmodePopulosidadeHSL_Click);
            // 
            // AlgoritmodepolulosidadeHSV
            // 
            this.AlgoritmodepolulosidadeHSV.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmodepolulosidadeHSV.Location = new System.Drawing.Point(1070, 330);
            this.AlgoritmodepolulosidadeHSV.Name = "AlgoritmodepolulosidadeHSV";
            this.AlgoritmodepolulosidadeHSV.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmodepolulosidadeHSV.TabIndex = 34;
            this.AlgoritmodepolulosidadeHSV.Text = "Populosidade HSV";
            this.AlgoritmodepolulosidadeHSV.UseVisualStyleBackColor = true;
            this.AlgoritmodepolulosidadeHSV.Click += new System.EventHandler(this.AlgoritmodepolulosidadeHSV_Click);
            // 
            // AlgoritmodePopulosidadeNTSCePAL
            // 
            this.AlgoritmodePopulosidadeNTSCePAL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmodePopulosidadeNTSCePAL.Location = new System.Drawing.Point(1070, 366);
            this.AlgoritmodePopulosidadeNTSCePAL.Name = "AlgoritmodePopulosidadeNTSCePAL";
            this.AlgoritmodePopulosidadeNTSCePAL.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmodePopulosidadeNTSCePAL.TabIndex = 35;
            this.AlgoritmodePopulosidadeNTSCePAL.Text = "Populasidade NTSC/PAL";
            this.AlgoritmodePopulosidadeNTSCePAL.UseVisualStyleBackColor = true;
            this.AlgoritmodePopulosidadeNTSCePAL.Click += new System.EventHandler(this.AlgoritmodePopulosidadeNTSCePAL_Click);
            // 
            // AlgoritmoCorteMedianoHSI
            // 
            this.AlgoritmoCorteMedianoHSI.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmoCorteMedianoHSI.Location = new System.Drawing.Point(1070, 422);
            this.AlgoritmoCorteMedianoHSI.Name = "AlgoritmoCorteMedianoHSI";
            this.AlgoritmoCorteMedianoHSI.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmoCorteMedianoHSI.TabIndex = 36;
            this.AlgoritmoCorteMedianoHSI.Text = "Corte Mediano HSI";
            this.AlgoritmoCorteMedianoHSI.UseVisualStyleBackColor = true;
            this.AlgoritmoCorteMedianoHSI.Click += new System.EventHandler(this.AlgoritmoCorteMedianoHSI_Click);
            // 
            // AlgoritmoCorteMedianoHSL
            // 
            this.AlgoritmoCorteMedianoHSL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmoCorteMedianoHSL.Location = new System.Drawing.Point(1069, 458);
            this.AlgoritmoCorteMedianoHSL.Name = "AlgoritmoCorteMedianoHSL";
            this.AlgoritmoCorteMedianoHSL.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmoCorteMedianoHSL.TabIndex = 37;
            this.AlgoritmoCorteMedianoHSL.Text = "Corte Mediano HSL";
            this.AlgoritmoCorteMedianoHSL.UseVisualStyleBackColor = true;
            this.AlgoritmoCorteMedianoHSL.Click += new System.EventHandler(this.AlgoritmoCorteMedianoHSL_Click);
            // 
            // AlgoritmodeCorteMedianoHSV
            // 
            this.AlgoritmodeCorteMedianoHSV.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgoritmodeCorteMedianoHSV.Location = new System.Drawing.Point(1069, 494);
            this.AlgoritmodeCorteMedianoHSV.Name = "AlgoritmodeCorteMedianoHSV";
            this.AlgoritmodeCorteMedianoHSV.Size = new System.Drawing.Size(150, 30);
            this.AlgoritmodeCorteMedianoHSV.TabIndex = 38;
            this.AlgoritmodeCorteMedianoHSV.Text = "Corte Mediano HSV";
            this.AlgoritmodeCorteMedianoHSV.UseVisualStyleBackColor = true;
            this.AlgoritmodeCorteMedianoHSV.Click += new System.EventHandler(this.AlgoritmodeCorteMedianoHSV_Click);
            // 
            // AlgotimodeCorteMedianoNTSCePAL
            // 
            this.AlgotimodeCorteMedianoNTSCePAL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.AlgotimodeCorteMedianoNTSCePAL.Location = new System.Drawing.Point(1070, 530);
            this.AlgotimodeCorteMedianoNTSCePAL.Name = "AlgotimodeCorteMedianoNTSCePAL";
            this.AlgotimodeCorteMedianoNTSCePAL.Size = new System.Drawing.Size(150, 30);
            this.AlgotimodeCorteMedianoNTSCePAL.TabIndex = 39;
            this.AlgotimodeCorteMedianoNTSCePAL.Text = "Corte Mediano NTSC/PAL";
            this.AlgotimodeCorteMedianoNTSCePAL.UseVisualStyleBackColor = true;
            this.AlgotimodeCorteMedianoNTSCePAL.Click += new System.EventHandler(this.AlgotimodeCorteMedianoNTSCePAL_Click);
            // 
            // EscalaCinzaHSL
            // 
            this.EscalaCinzaHSL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.EscalaCinzaHSL.Location = new System.Drawing.Point(977, 41);
            this.EscalaCinzaHSL.Name = "EscalaCinzaHSL";
            this.EscalaCinzaHSL.Size = new System.Drawing.Size(100, 30);
            this.EscalaCinzaHSL.TabIndex = 40;
            this.EscalaCinzaHSL.Text = "Cinza HSL";
            this.EscalaCinzaHSL.UseVisualStyleBackColor = true;
            this.EscalaCinzaHSL.Click += new System.EventHandler(this.EscalaCinzaHSL_Click);
            // 
            // EscalaCinzaHSV
            // 
            this.EscalaCinzaHSV.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.EscalaCinzaHSV.Location = new System.Drawing.Point(1083, 5);
            this.EscalaCinzaHSV.Name = "EscalaCinzaHSV";
            this.EscalaCinzaHSV.Size = new System.Drawing.Size(100, 30);
            this.EscalaCinzaHSV.TabIndex = 41;
            this.EscalaCinzaHSV.Text = "Cinza HSV";
            this.EscalaCinzaHSV.UseVisualStyleBackColor = true;
            this.EscalaCinzaHSV.Click += new System.EventHandler(this.EscalaCinzaHSV_Click);
            // 
            // EscalaCinzaNTSCePAL
            // 
            this.EscalaCinzaNTSCePAL.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.EscalaCinzaNTSCePAL.Location = new System.Drawing.Point(1083, 43);
            this.EscalaCinzaNTSCePAL.Name = "EscalaCinzaNTSCePAL";
            this.EscalaCinzaNTSCePAL.Size = new System.Drawing.Size(100, 30);
            this.EscalaCinzaNTSCePAL.TabIndex = 42;
            this.EscalaCinzaNTSCePAL.Text = "Cinza NTSC/PAL";
            this.EscalaCinzaNTSCePAL.UseVisualStyleBackColor = true;
            this.EscalaCinzaNTSCePAL.Click += new System.EventHandler(this.EscalaCinzaNTSCePAL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1069, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.img05;
            this.ClientSize = new System.Drawing.Size(1264, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EscalaCinzaNTSCePAL);
            this.Controls.Add(this.EscalaCinzaHSV);
            this.Controls.Add(this.EscalaCinzaHSL);
            this.Controls.Add(this.AlgotimodeCorteMedianoNTSCePAL);
            this.Controls.Add(this.AlgoritmodeCorteMedianoHSV);
            this.Controls.Add(this.AlgoritmoCorteMedianoHSL);
            this.Controls.Add(this.AlgoritmoCorteMedianoHSI);
            this.Controls.Add(this.AlgoritmodePopulosidadeNTSCePAL);
            this.Controls.Add(this.AlgoritmodepolulosidadeHSV);
            this.Controls.Add(this.AlgorotmodePopulosidadeHSL);
            this.Controls.Add(this.AlgoritmodePopulodidadeHSI);
            this.Controls.Add(this.SubstituicaoUniformeNTSCePAL);
            this.Controls.Add(this.SubstituicaoUniformeHSV);
            this.Controls.Add(this.SubstituicaoUniformeHSL);
            this.Controls.Add(this.SubstituicaoUniformeHSI);
            this.Controls.Add(this.EscalaCinza);
            this.Controls.Add(this.PegarImagem);
            this.Controls.Add(this.FiltroCannysBranco);
            this.Controls.Add(this.FiltroMediaPonderada);
            this.Controls.Add(this.FiltroModa);
            this.Controls.Add(this.FiltroRobertsBranco);
            this.Controls.Add(this.FiltroCannys);
            this.Controls.Add(this.FiltroLaplaceOriginal);
            this.Controls.Add(this.FiltroLaplace);
            this.Controls.Add(this.FiltrodeRobertsPreto);
            this.Controls.Add(this.FitroPrewittBranco);
            this.Controls.Add(this.FiltroPrewittPreto);
            this.Controls.Add(this.FiltroSobelBranco);
            this.Controls.Add(this.FiltroSobelPreto);
            this.Controls.Add(this.FiltroMinimo);
            this.Controls.Add(this.FiltroMaximo);
            this.Controls.Add(this.FiltroMediana);
            this.Controls.Add(this.FiltroMedia);
            this.Controls.Add(this.ampliar);
            this.Controls.Add(this.Reduzir);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.Seleciona);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Button Seleciona;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button Reduzir;
        private System.Windows.Forms.Button ampliar;
        private System.Windows.Forms.Button FiltroMedia;
        private System.Windows.Forms.Button FiltroMediana;
        private System.Windows.Forms.Button FiltroMaximo;
        private System.Windows.Forms.Button FiltroMinimo;
        private System.Windows.Forms.Button FiltroSobelPreto;
        private System.Windows.Forms.Button FiltroSobelBranco;
        private System.Windows.Forms.Button FiltroPrewittPreto;
        private System.Windows.Forms.Button FitroPrewittBranco;
        private System.Windows.Forms.Button FiltrodeRobertsPreto;
        private System.Windows.Forms.Button FiltroLaplace;
        private System.Windows.Forms.Button FiltroLaplaceOriginal;
        private System.Windows.Forms.Button FiltroCannys;
        private System.Windows.Forms.Button FiltroRobertsBranco;
        private System.Windows.Forms.Button FiltroModa;
        private System.Windows.Forms.Button FiltroMediaPonderada;
        private System.Windows.Forms.Button FiltroCannysBranco;
        private System.Windows.Forms.Button PegarImagem;
        private System.Windows.Forms.Button EscalaCinza;
        private System.Windows.Forms.Button SubstituicaoUniformeHSI;
        private System.Windows.Forms.Button SubstituicaoUniformeHSL;
        private System.Windows.Forms.Button SubstituicaoUniformeHSV;
        private System.Windows.Forms.Button SubstituicaoUniformeNTSCePAL;
        private System.Windows.Forms.Button AlgoritmodePopulodidadeHSI;
        private System.Windows.Forms.Button AlgorotmodePopulosidadeHSL;
        private System.Windows.Forms.Button AlgoritmodepolulosidadeHSV;
        private System.Windows.Forms.Button AlgoritmodePopulosidadeNTSCePAL;
        private System.Windows.Forms.Button AlgoritmoCorteMedianoHSI;
        private System.Windows.Forms.Button AlgoritmoCorteMedianoHSL;
        private System.Windows.Forms.Button AlgoritmodeCorteMedianoHSV;
        private System.Windows.Forms.Button AlgotimodeCorteMedianoNTSCePAL;
        private System.Windows.Forms.Button EscalaCinzaHSL;
        private System.Windows.Forms.Button EscalaCinzaHSV;
        private System.Windows.Forms.Button EscalaCinzaNTSCePAL;
        private System.Windows.Forms.Button button1;
    }
}

