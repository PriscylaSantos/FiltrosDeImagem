using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int[,] filtroWindow;

        public Form1()
        {
            InitializeComponent();
            string[] filters = new string[]{"Média", "Mediana",
                "Máximo", "Mínimo", "Moda",
                "Média Ponderada", "Sobel",
                "Sobel Inverso", "Prewitt", "Prewitt Inverso",
                "Roberts", "Roberts Inverso", "Laplace",
                "Laplace Original", "Cannys",
                "Cannys Inverso", "Cinza: HSI", "Cinza: HSL",
                "Cinza: HSV", "Cinza: NTSC/PAL", "Substituição Uniforme: HSI",
                "Substituição Uniforme: HSL", "Substituição Uniforme: HSV", "Substituição Uniforme: NTSC/PAL",
                "Populosidade: HSI", "Populosidade: HSL", "Populosidade: HSV", "Populosidade: NTSC/PAL",
                "Corte Mediano: HSI", "Corte Mediano: HSL", "Corte Mediano: HSV", "Corte Mediano: NTSC/PAL",
                "Negativo", "Negativo Cinza" };

            cmbFilterType.Items.AddRange(filters);
        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image == null)
                return;

            string filterCase = (string)cmbFilterType.SelectedItem;

            Bitmap Image = new Bitmap(pictureBoxOriginal.Image);

            switch (filterCase)
            {
                case "Média":
                    FiltroMedia filtroMedia = new FiltroMedia();
                    pictureBoxResultado.Image = filtroMedia.Media(Image);
                    break;

                case "Mediana":
                    FiltroMediana filtroMediana = new FiltroMediana();
                    pictureBoxResultado.Image = filtroMediana.Mediana(Image);
                    break;

                case "Máximo":
                    FiltroMinMax filtroMax = new FiltroMinMax();
                    pictureBoxResultado.Image = filtroMax.MinMax(Image, 1);
                    break;

                case "Mínimo":
                    //
                    FiltroMinMax filtroMin = new FiltroMinMax();
                    pictureBoxResultado.Image = filtroMin.MinMax(Image, 0);
                    break;

                case "Moda":
                    //
                    FiltroModa filtroModa = new FiltroModa();
                    pictureBoxResultado.Image = filtroModa.Moda(Image);
                    break;

                case "Média Ponderada":
                    //
                    FiltroMedia filtroMediaP = new FiltroMedia();
                    pictureBoxResultado.Image = filtroMediaP.MediaPonderada(Image);
                    break;
                case "Sobel":
                    //
                    FiltroBordas filtroSobel = new FiltroBordas();
                    pictureBoxResultado.Image = filtroSobel.Sobel(Image, 0);
                    break;
                case "Sobel Inverso":
                    //
                    FiltroBordas filtroSobelInv = new FiltroBordas();
                    pictureBoxResultado.Image = filtroSobelInv.Sobel(Image, 1);
                    break;
                case "Prewitt":
                    //
                    FiltroBordas filtroPrewitt = new FiltroBordas();
                    pictureBoxResultado.Image = filtroPrewitt.Prewitt(Image, 0);
                    break;
                case "Prewitt Inverso":
                    //
                    FiltroBordas filtroPrewittInv = new FiltroBordas();
                    pictureBoxResultado.Image = filtroPrewittInv.Prewitt(Image, 1);
                    break;
                case "Roberts":
                    //
                    FiltroBordas filtroRoberts = new FiltroBordas();
                    pictureBoxResultado.Image = filtroRoberts.Roberts(Image, 0);
                    break;
                case "Roberts Inverso":
                    //
                    FiltroBordas filtroRobertsInv = new FiltroBordas();
                    pictureBoxResultado.Image = filtroRobertsInv.Roberts(Image, 1);
                    break;
                case "Laplace":
                    //
                    FiltroBordas filtroLaplace = new FiltroBordas();
                    filtroWindow = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                    pictureBoxResultado.Image = filtroLaplace.LaPlace(Image, filtroWindow);
                    break;
                case "Laplace Original":
                    //
                    FiltroBordas filtroLaplaceOri = new FiltroBordas();
                    filtroWindow = new int[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
                    pictureBoxResultado.Image = filtroLaplaceOri.LaPlace(Image, filtroWindow);
                    break;
                case "Cannys":
                    //
                    FiltroBordas filtroCannys = new FiltroBordas();
                    pictureBoxResultado.Image = filtroCannys.Cannys(Image, 0);
                    break;
                case "Cannys Inverso":
                    //
                    FiltroBordas filtroCannysInv = new FiltroBordas();
                    pictureBoxResultado.Image = filtroCannysInv.Cannys(Image, 1);
                    break;
                case "Cinza: HSI":
                    //
                    FiltroCinza filtroCHSI = new FiltroCinza();
                    pictureBoxResultado.Image = filtroCHSI.HSI(Image);
                    break;
                case "Cinza: HSL":
                    //
                    FiltroCinza filtroCHSL = new FiltroCinza();
                    pictureBoxResultado.Image = filtroCHSL.HSL(Image);
                    break;
                case "Cinza: HSV":
                    //
                    FiltroCinza filtroCHSV = new FiltroCinza();
                    pictureBoxResultado.Image = filtroCHSV.HSV(Image);
                    break;
                case "Cinza: NTSC/PAL":
                    //
                    FiltroCinza filtroCNTSC = new FiltroCinza();
                    pictureBoxResultado.Image = filtroCNTSC.NTSCePAL(Image);
                    break;
                case "Substituição Uniforme: HSI":
                    //
                    FiltroSubstituicaoUniforme filtroSubHSI = new FiltroSubstituicaoUniforme();
                    pictureBoxResultado.Image = filtroSubHSI.HSI(Image);
                    break;
                case "Substituição Uniforme: HSL":
                    //
                    FiltroSubstituicaoUniforme filtroSubHSL = new FiltroSubstituicaoUniforme();
                    pictureBoxResultado.Image = filtroSubHSL.HSL(Image);
                    break;
                case "Substituição Uniforme: HSV":
                    //
                    FiltroSubstituicaoUniforme filtroSubHSV = new FiltroSubstituicaoUniforme();
                    pictureBoxResultado.Image = filtroSubHSV.HSV(Image);
                    break;
                case "Substituição Uniforme: NTSC/PAL":
                    //
                    FiltroSubstituicaoUniforme filtroSubNTSC = new FiltroSubstituicaoUniforme();
                    pictureBoxResultado.Image = filtroSubNTSC.NTSCePal(Image);
                    break;
                case "Populosidade: HSI":
                    //
                    FiltroPopulosidade filtroPopHSI = new FiltroPopulosidade();
                    pictureBoxResultado.Image = filtroPopHSI.HSI(Image);
                    break;
                case "Populosidade: HSL":
                    //
                    FiltroPopulosidade filtroPopHSL = new FiltroPopulosidade();
                    pictureBoxResultado.Image = filtroPopHSL.HSL(Image);
                    break;
                case "Populosidade: HSV":
                    //
                    FiltroPopulosidade filtroPopHSV = new FiltroPopulosidade();
                    pictureBoxResultado.Image = filtroPopHSV.HSV(Image);
                    break;
                case "Populosidade: NTSC/PAL":
                    //
                    FiltroPopulosidade filtroPopNTSC = new FiltroPopulosidade();
                    pictureBoxResultado.Image = filtroPopNTSC.NTSCePAL(Image);
                    break;
                case "Corte Mediano: HSI":
                    //
                    FiltroCorteMediano filtroCMHSI = new FiltroCorteMediano();
                    pictureBoxResultado.Image = filtroCMHSI.HSI(Image);
                    break;
                case "Corte Mediano: HSL":
                    //
                    FiltroCorteMediano filtroCMHSL = new FiltroCorteMediano();
                    pictureBoxResultado.Image = filtroCMHSL.HSL(Image);
                    break;
                case "Corte Mediano: HSV":
                    //
                    FiltroCorteMediano filtroCMHSV = new FiltroCorteMediano();
                    pictureBoxResultado.Image = filtroCMHSV.HSV(Image);
                    break;
                case "Corte Mediano: NTSC/PAL":
                    //
                    FiltroCorteMediano filtroCMNTSC = new FiltroCorteMediano();
                    pictureBoxResultado.Image = filtroCMNTSC.NTSCePAL(Image);
                    break;
                case "Negativo":
                    //
                    FiltroNegativo filtroNegativoColor = new FiltroNegativo();
                    pictureBoxResultado.Image = filtroNegativoColor.Negativo(Image, 1);
                    break;
                case "Negativo Cinza":
                    //
                    FiltroNegativo filtroNegativo = new FiltroNegativo();
                    pictureBoxResultado.Image = filtroNegativo.Negativo(Image, 0);
                    break;
            }
        }

        private void abrirImagemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            Bitmap Imagem;
            caixa.Filter = "Imagem Png(.png)|*.png|Imagme bmp(.bmp)|*.bmp|Imagem Gif(.Gif)|*gif|Imagem JPG(.jpg)|*.jpg|Imagem TIFF(.tif)|*tif";
            caixa.InitialDirectory = @"C:\Users\'\Desktop\Imagem Trabalho";
            caixa.Title = "Selecionar Imagem";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                Imagem = new Bitmap(Image.FromFile(caixa.FileName));
                pictureBoxOriginal.Image = Imagem;
            }
        }

        private void salvarImgemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Filter = "Imagem Png(.png)|*png";
            caixa.DefaultExt = "png";
            caixa.Title = "Salvar Imagem";
            if (DialogResult.OK == caixa.ShowDialog())
            {
                string nome = caixa.FileName;
                Bitmap NovaImagem = new Bitmap(pictureBoxResultado.Image);
                NovaImagem.Save(nome, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            double m = 0.5;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            int auxi = 0;
            int auxj = 0;

            for (i = 0; i < Largura; i++)
            {
                for (j = 0; j < Altura; j++)
                {
                    auxi = Convert.ToInt32(i * m);
                    auxj = Convert.ToInt32(j * m);
                    pixelR = Imagem.GetPixel(auxi, auxj).R;
                    pixelG = Imagem.GetPixel(auxi, auxj).G;
                    pixelB = Imagem.GetPixel(auxi, auxj).B;
                    pixelA = Imagem.GetPixel(auxi, auxj).A;
                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            double m = 0.5;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            int auxi = 0;
            int auxj = 0;

            for (i = 0; i < Largura * m; i++)
            {
                for (j = 0; j < Altura * m; j++)
                {
                    auxi = Convert.ToInt32(i / m);
                    auxj = Convert.ToInt32(j / m);
                    pixelR = Imagem.GetPixel(auxi, auxj).R;
                    pixelG = Imagem.GetPixel(auxi, auxj).G;
                    pixelB = Imagem.GetPixel(auxi, auxj).B;
                    pixelA = Imagem.GetPixel(auxi, auxj).A;
                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void utilizarImagemFiltradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap NovaImagem = new Bitmap(pictureBoxResultado.Image);
            pictureBoxOriginal.Image = NovaImagem;
        }

        private void voltarTamanhoOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxResultado.Image = pictureBoxOriginal.Image;
        }

    }
}

    
