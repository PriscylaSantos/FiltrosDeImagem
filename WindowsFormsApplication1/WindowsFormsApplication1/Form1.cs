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
        public class Ordenacao
        {
            public int[] BubbleSort(int[] vetor)                //retorna a array ordenada
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    for (int j = 0; j < vetor.Length - 1; j++)
                    {
                        if (vetor[j] > vetor[j + 1])
                        {
                            int swap = vetor[j];
                            vetor[j] = vetor[j + 1];
                            vetor[j + 1] = swap;
                        }
                    }

                }
                return vetor;
            }
        }

        public class CalcularModa
        {
            public int[] Moda(int[] moda, int valor)                //retorna a array ordenada
            {
                int[] cont = new int[9];
                int[] distintos = new int[9];
                int[] conjunto = new int[9];
                Boolean novo;
                int ndistintos = 0;
                for (int i = 0; i < moda.Length; i++)
                {
                    novo = true;
                    for (int j = 0; j < moda.Length; j++)
                    {
                        if (cont[j] == distintos[i])
                        {
                            novo = false;
                            cont[i] = cont[i] + 1;
                        }

                    }
                    if (novo)
                    {
                        ndistintos = ndistintos + 1;
                        distintos[ndistintos] = conjunto[i];
                        cont[ndistintos] = 1;

                    }
                }

                int tmoda = 0;
                for (int a = 0; ndistintos < a; a++)
                {
                    if (cont[a] > tmoda)
                    {
                        valor = a;
                        tmoda = cont[a];

                    }
                }
                return moda;
            }

        }

        public class CalcularMediaPonderada
        {
            public int[] MediaPonderada(int[] mediaP, int valor)                //retorna a array ordenada
            {
                int peso = 0;
                int soma = 0;
                int i;
                for (i = 0; i < mediaP.Length; i++)
                {
                    mediaP[i] = (mediaP[i] * (i + 1));
                    soma = soma + mediaP[i];
                    peso = peso + i;
                }
                valor = soma / peso;
                return mediaP;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Seleciona_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            Bitmap Imagem;
            // caixa.Filter = "Imagem JPG(.jpg,.bmp,.gif, .png, .tif)|*.jpg ||*.bmp|| *gif|| *png|";
            caixa.Filter = "Imagem JPG(.jpg)|*.jpg|Imagme bmp(.bmp)|*.bmp|Imagem Gif(.Gif)|*gif|Imagem Png(.png)|*png|Imagem TIFF(.tif)|*tif";
            caixa.InitialDirectory = @"C:\Users\'\Desktop\Imagem Trabalho";
            caixa.Title = "Selecionar Imagem";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                Imagem = new Bitmap(Image.FromFile(caixa.FileName));
                pictureBoxOriginal.Image = Imagem;
            }
        }

        private void Salva_Click(object sender, EventArgs e)
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


        private void Reduzir_Click(object sender, EventArgs e)
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

        private void ampliar_Click(object sender, EventArgs e)
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


        private void FiltroMedia_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            //int aux;
            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    pixelR = (
                             Imagem.GetPixel(i - 1, j - 1).R +
                             Imagem.GetPixel(i - 1, j).R +
                             Imagem.GetPixel(i - 1, j + 1).R +

                             Imagem.GetPixel(i, j - 1).R +
                             Imagem.GetPixel(i, j).R +
                             Imagem.GetPixel(i, j + 1).R +

                             Imagem.GetPixel(i + 1, j - 1).R + // Imagem.GetPixel(i + 1, j + 1).R + 
                             Imagem.GetPixel(i + 1, j).R +
                             Imagem.GetPixel(i + 1, j + 1).R
                             ) / 9;

                    pixelG = (
                             Imagem.GetPixel(i - 1, j - 1).G +
                             Imagem.GetPixel(i - 1, j).G +
                             Imagem.GetPixel(i - 1, j + 1).G +

                             Imagem.GetPixel(i, j - 1).G +
                             Imagem.GetPixel(i, j).G +
                             Imagem.GetPixel(i, j + 1).G +

                             Imagem.GetPixel(i + 1, j - 1).G + //Imagem.GetPixel(i + 1, j + 1).G + 
                             Imagem.GetPixel(i + 1, j).G +
                             Imagem.GetPixel(i + 1, j + 1).G
                             ) / 9;

                    pixelB = (
                              Imagem.GetPixel(i - 1, j - 1).B +
                              Imagem.GetPixel(i - 1, j).B +
                              Imagem.GetPixel(i - 1, j + 1).B +

                              Imagem.GetPixel(i, j - 1).B +
                              Imagem.GetPixel(i, j).B +
                              Imagem.GetPixel(i, j + 1).B +

                              Imagem.GetPixel(i + 1, j - 1).B + // Imagem.GetPixel(i + 1, j + 1).B +
                              Imagem.GetPixel(i + 1, j).B +
                              Imagem.GetPixel(i + 1, j + 1).B
                              ) / 9;

                    pixelA = (
                             Imagem.GetPixel(i - 1, j - 1).A +
                             Imagem.GetPixel(i - 1, j).A +
                             Imagem.GetPixel(i - 1, j + 1).A +

                             Imagem.GetPixel(i, j - 1).A +
                             Imagem.GetPixel(i, j).A +
                             Imagem.GetPixel(i, j + 1).A +

                             Imagem.GetPixel(i + 1, j - 1).A + //Imagem.GetPixel(i + 1, j + 1).A +
                             Imagem.GetPixel(i + 1, j).A +
                             Imagem.GetPixel(i + 1, j + 1).A
                            ) / 9;


                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));

                }
            }

            pictureBoxResultado.Image = NovaImagem;
        }

        private void FiltroMediana_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Ordenacao ordenar = new Ordenacao();
            int[] vetor = new int[9];

            Bitmap NovaImagem = new Bitmap(Largura, Altura);


            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    todosPixeisR[0] = Imagem.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = Imagem.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = Imagem.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = Imagem.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = Imagem.GetPixel(i, j).R;
                    todosPixeisR[5] = Imagem.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R; // Imagem.GetPixel(i + 1, j + 1).R + 
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    vetor = ordenar.BubbleSort(todosPixeisR);
                    pixelR = todosPixeisR[4];


                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G; //Imagem.GetPixel(i + 1, j + 1).G + 
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    vetor = ordenar.BubbleSort(todosPixeisG);
                    pixelG = todosPixeisG[4];


                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B; // Imagem.GetPixel(i + 1, j + 1).B +
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    vetor = ordenar.BubbleSort(todosPixeisB);
                    pixelB = todosPixeisB[4];


                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A; //Imagem.GetPixel(i + 1, j + 1).A +
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    vetor = ordenar.BubbleSort(todosPixeisA);
                    pixelA = todosPixeisA[4];


                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void FiltroMaximo_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Ordenacao ordenar = new Ordenacao();
            int[] vetor = new int[9];

            Bitmap NovaImagem = new Bitmap(Largura, Altura);


            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    todosPixeisR[0] = Imagem.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = Imagem.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = Imagem.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = Imagem.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = Imagem.GetPixel(i, j).R;
                    todosPixeisR[5] = Imagem.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R; // Imagem.GetPixel(i + 1, j + 1).R + 
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    vetor = ordenar.BubbleSort(todosPixeisR);
                    pixelR = todosPixeisR[8];


                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G; //Imagem.GetPixel(i + 1, j + 1).G + 
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    vetor = ordenar.BubbleSort(todosPixeisG);
                    pixelG = todosPixeisG[8];


                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B; // Imagem.GetPixel(i + 1, j + 1).B +
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    vetor = ordenar.BubbleSort(todosPixeisB);
                    pixelB = todosPixeisB[8];


                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A; //Imagem.GetPixel(i + 1, j + 1).A +
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    vetor = ordenar.BubbleSort(todosPixeisA);
                    pixelA = todosPixeisA[8];


                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void FiltroMinimo_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Ordenacao ordenar = new Ordenacao();
            int[] vetor = new int[9];

            Bitmap NovaImagem = new Bitmap(Largura, Altura);

            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    todosPixeisR[0] = Imagem.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = Imagem.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = Imagem.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = Imagem.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = Imagem.GetPixel(i, j).R;
                    todosPixeisR[5] = Imagem.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R; // Imagem.GetPixel(i + 1, j + 1).R + 
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    vetor = ordenar.BubbleSort(todosPixeisR);
                    pixelR = todosPixeisR[0];


                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G; //Imagem.GetPixel(i + 1, j + 1).G + 
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    vetor = ordenar.BubbleSort(todosPixeisG);
                    pixelG = todosPixeisG[0];


                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B; // Imagem.GetPixel(i + 1, j + 1).B +
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    vetor = ordenar.BubbleSort(todosPixeisB);
                    pixelB = todosPixeisB[0];


                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A; //Imagem.GetPixel(i + 1, j + 1).A +
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    vetor = ordenar.BubbleSort(todosPixeisA);
                    pixelA = todosPixeisA[0];


                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void FiltroModa_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Ordenacao ordenar = new Ordenacao();
            CalcularModa calcular = new CalcularModa();
            int[] vetor = new int[9];
            int[] moda = new int[9];
            int valor = 0;


            Bitmap NovaImagem = new Bitmap(Largura, Altura);


            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    todosPixeisR[0] = Imagem.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = Imagem.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = Imagem.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = Imagem.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = Imagem.GetPixel(i, j).R;
                    todosPixeisR[5] = Imagem.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R; // Imagem.GetPixel(i + 1, j + 1).R + 
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    vetor = ordenar.BubbleSort(todosPixeisR);
                    moda = calcular.Moda(todosPixeisR, valor);
                    pixelR = todosPixeisR[valor];


                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G; //Imagem.GetPixel(i + 1, j + 1).G + 
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    vetor = ordenar.BubbleSort(todosPixeisG);
                    moda = calcular.Moda(todosPixeisG, valor);
                    pixelG = todosPixeisG[valor];


                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B; // Imagem.GetPixel(i + 1, j + 1).B +
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    vetor = ordenar.BubbleSort(todosPixeisB);
                    moda = calcular.Moda(todosPixeisB, valor);
                    pixelB = todosPixeisB[valor];


                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A; //Imagem.GetPixel(i + 1, j + 1).A +
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    vetor = ordenar.BubbleSort(todosPixeisA);
                    moda = calcular.Moda(todosPixeisA, valor);
                    pixelA = todosPixeisG[valor];

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void FiltroMediaPonderada_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            // Ordenacao ordenar = new Ordenacao();
            CalcularMediaPonderada calcular = new CalcularMediaPonderada();
            int[] vetor = new int[9];
            int[] mediaP = new int[9];
            int valor = 0;


            Bitmap NovaImagem = new Bitmap(Largura, Altura);


            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    todosPixeisR[0] = Imagem.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = Imagem.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = Imagem.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = Imagem.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = Imagem.GetPixel(i, j).R;
                    todosPixeisR[5] = Imagem.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R; // Imagem.GetPixel(i + 1, j + 1).R + 
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    //  vetor = ordenar.BubbleSort(todosPixeisR);
                    mediaP = calcular.MediaPonderada(todosPixeisR, valor);
                    pixelR = todosPixeisR[valor];


                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G; //Imagem.GetPixel(i + 1, j + 1).G + 
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    // vetor = ordenar.BubbleSort(todosPixeisG);
                    mediaP = calcular.MediaPonderada(todosPixeisG, valor);
                    pixelG = todosPixeisG[valor];


                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B; // Imagem.GetPixel(i + 1, j + 1).B +
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    // vetor = ordenar.BubbleSort(todosPixeisB);
                    mediaP = calcular.MediaPonderada(todosPixeisB, valor);
                    pixelB = todosPixeisB[valor];


                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A; //Imagem.GetPixel(i + 1, j + 1).A +
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    // vetor = ordenar.BubbleSort(todosPixeisA);
                    mediaP = calcular.MediaPonderada(todosPixeisA, valor);
                    pixelA = todosPixeisG[valor];

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }


        private void FiltroSobel_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Sobely = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };//sobel
            int[,] Sobelx = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Largura - 1; i++)
            {
                for (int j = 1; j < Altura - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novo_rx += Sobelx[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_ry += Sobely[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_gx += Sobelx[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_gy += Sobely[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_bx += Sobelx[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                            novo_by += Sobely[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                        }
                    }
                    if (
                        novo_rx * novo_rx + novo_ry * novo_ry > limite ||
                        novo_gx * novo_gx + novo_gy * novo_gy > limite ||
                        novo_bx * novo_bx + novo_by * novo_by > limite
                        )
                        NovaImagem.SetPixel(i, j, Color.Transparent);
                    else
                        NovaImagem.SetPixel(i, j, Color.Black);

                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void FiltroSobelBranco_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Sobely = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };//sobel
            int[,] Sobelx = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;
            for (int i = 1; i < Imagem.Width - 1; i++)
            {
                for (int j = 1; j < Imagem.Height - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novo_rx += Sobelx[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_ry += Sobely[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_gx += Sobelx[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_gy += Sobely[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_bx += Sobelx[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                            novo_by += Sobely[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                        }
                    }
                    if (
                        novo_rx * novo_rx + novo_ry * novo_ry > limite ||
                        novo_gx * novo_gx + novo_gy * novo_gy > limite ||
                        novo_bx * novo_bx + novo_by * novo_by > limite)
                        NovaImagem.SetPixel(i, j, Color.Black
                       );
                    else
                        NovaImagem.SetPixel(i, j, Color.Transparent);

                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }


        private void FiltroPrewitt_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Prewittx = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };//sobel
            int[,] Prewitty = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };

            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Imagem.Width - 1; i++)
            {
                for (int j = 1; j < Imagem.Height - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novo_rx += Prewittx[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_ry += Prewitty[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_gx += Prewittx[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_gy += Prewitty[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_bx += Prewittx[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                            novo_by += Prewitty[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                        }
                    }
                    if (
                          novo_rx * novo_rx + novo_ry * novo_ry > limite ||
                        novo_gx * novo_gx + novo_gy * novo_gy > limite ||
                        novo_bx * novo_bx + novo_by * novo_by > limite
                        )
                        NovaImagem.SetPixel(i, j, Color.Transparent);
                    else
                        NovaImagem.SetPixel(i, j, Color.Black);
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void FitroPrewittBranco_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Prewittx = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            int[,] Prewitty = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Imagem.Width - 1; i++)
            {
                for (int j = 1; j < Imagem.Height - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novo_rx += Prewittx[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_ry += Prewitty[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_gx += Prewittx[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_gy += Prewitty[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_bx += Prewittx[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                            novo_by += Prewitty[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                        }
                    }
                    if (
                        novo_rx * novo_rx + novo_ry * novo_ry > limite ||
                        novo_gx * novo_gx + novo_gy * novo_gy > limite ||
                        novo_bx * novo_bx + novo_by * novo_by > limite
                        )
                        NovaImagem.SetPixel(i, j, Color.Black);
                    else
                        NovaImagem.SetPixel(i, j, Color.Transparent);
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }


        private void FiltrodeRobertsPreto_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Robertsx = new int[,] { { 1, 0 }, { 0, -1 } };//sobel
            int[,] Robertsy = new int[,] { { 0, 1 }, { -1, 0 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Largura - 1; i++)
            {
                for (int j = 1; j < Altura - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 1; x++)
                    {
                        for (int y = -1; y < 1; y++)
                        {
                            novo_rx += Robertsx[x + 1, y + 1] * todosPixeisR[i, j - 1];
                            novo_ry += Robertsy[x + 1, y + 1] * todosPixeisR[i + y, j - 1];
                            novo_gx += Robertsx[x + 1, y + 1] * todosPixeisG[i, j - 1];
                            novo_gy += Robertsy[x + 1, y + 1] * todosPixeisG[i + y, j - 1];
                            novo_bx += Robertsx[x + 1, y + 1] * todosPixeisB[i, j - 1];
                            novo_by += Robertsy[x + 1, y + 1] * todosPixeisB[i + y, j - 1];
                        }
                    }
                    /* if (
                          (((novo_rx * novo_rx) * (novo_rx * novo_rx)) + ((novo_ry * novo_ry) * (novo_ry * novo_ry)))/2 > limite ||
                         (((novo_gx * novo_gx) * (novo_gx * novo_gx)) + ((novo_gy * novo_gy) * (novo_gy * novo_gy)))/2 > limite ||
                          (((novo_bx * novo_bx) * (novo_bx * novo_bx)) + ((novo_by * novo_by) * (novo_by * novo_by)))/2 > limite
                         )*/
                    if (
                         (((novo_rx * novo_rx) * (novo_rx * novo_rx)) + ((novo_ry * novo_ry) * (novo_ry * novo_ry))) / 2 > limite ||
                        (((novo_gx * novo_gx) * (novo_gx * novo_gx)) + ((novo_gy * novo_gy) * (novo_gy * novo_gy))) / 2 > limite ||
                         (((novo_bx * novo_bx) * (novo_bx * novo_bx)) + ((novo_by * novo_by) * (novo_by * novo_by))) / 2 > limite
                        )

                        NovaImagem.SetPixel(i, j, Color.Transparent);
                    else
                        NovaImagem.SetPixel(i, j, Color.Black);
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void FiltroRobertsBranco_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Robertsx = new int[,] { { 1, 0 }, { 0, -1 } };//sobel
            int[,] Robertsy = new int[,] { { 0, 1 }, { -1, 0 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Largura - 1; i++)
            {
                for (int j = 1; j < Altura - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 1; x++)
                    {
                        for (int y = -1; y < 1; y++)
                        {
                            novo_rx += Robertsx[x + 1, y + 1] * todosPixeisR[i, j - 1];
                            novo_ry += Robertsy[x + 1, y + 1] * todosPixeisR[i + y, j - 1];
                            novo_gx += Robertsx[x + 1, y + 1] * todosPixeisG[i, j - 1];
                            novo_gy += Robertsy[x + 1, y + 1] * todosPixeisG[i + y, j - 1];
                            novo_bx += Robertsx[x + 1, y + 1] * todosPixeisB[i, j - 1];
                            novo_by += Robertsy[x + 1, y + 1] * todosPixeisB[i + y, j - 1];
                        }
                    }
                    if (
                         ((novo_rx * novo_rx) * (novo_rx * novo_rx)) + ((novo_ry * novo_ry) * (novo_ry * novo_ry)) / 2 > limite ||
                         ((novo_gx * novo_gx) * (novo_gx * novo_gx)) + ((novo_gy * novo_gy) * (novo_gy * novo_gy)) / 2 > limite ||
                         ((novo_bx * novo_bx) * (novo_bx * novo_bx)) + ((novo_by * novo_by) * (novo_by * novo_by)) / 2 > limite
                        )
                        NovaImagem.SetPixel(i, j, Color.Black);
                    else
                        NovaImagem.SetPixel(i, j, Color.Transparent);
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }


        private void FiltroLaplace_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Laplace = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i;
            int j;
            int aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            for (i = 0; i < Altura - 2; i++)
            {
                for (j = 0; j < Largura - 2; j++)
                {
                    for (aux = 0; aux < 3; aux++)
                    {
                        for (aux2 = 0; aux2 < 3; aux2++)
                        {
                            todosPixelsR += Imagem.GetPixel(j + aux, i + aux2).R * Laplace[aux2, aux];
                            todosPixelsG += Imagem.GetPixel(j + aux, i + aux2).G * Laplace[aux2, aux];
                            todosPixelsB += Imagem.GetPixel(j + aux, i + aux2).B * Laplace[aux2, aux];
                        }

                    }
                    if (todosPixelsR < 0)
                    {
                        todosPixelsR = 0;
                    }
                    else
                    {
                        if (todosPixelsR > 255)
                        {
                            todosPixelsR = 255;
                        }
                    }
                    if (todosPixelsG < 0)
                    {
                        todosPixelsG = 0;
                    }
                    else
                    {
                        if (todosPixelsG > 255)
                        {
                            todosPixelsG = 255;
                        }
                    }
                    if (todosPixelsB < 0)
                    {
                        todosPixelsB = 0;
                    }
                    else
                    {
                        if (todosPixelsB > 255)
                        {
                            todosPixelsB = 255;
                        }

                    }
                    NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, todosPixelsR, todosPixelsG, todosPixelsB));
                    todosPixelsR = 0;
                    todosPixelsG = 0;
                    todosPixelsB = 0;

                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void FiltroLaplaceOriginal_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Laplace = new int[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i;
            int j;
            int aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            for (i = 0; i < Altura - 2; i++)
            {
                for (j = 0; j < Largura - 2; j++)
                {
                    for (aux = 0; aux < 3; aux++)
                    {
                        for (aux2 = 0; aux2 < 3; aux2++)
                        {
                            todosPixelsR += Imagem.GetPixel(j + aux, i + aux2).R * Laplace[aux2, aux];
                            todosPixelsG += Imagem.GetPixel(j + aux, i + aux2).G * Laplace[aux2, aux];
                            todosPixelsB += Imagem.GetPixel(j + aux, i + aux2).B * Laplace[aux2, aux];
                        }

                    }
                    if (todosPixelsR < 0)
                    {
                        todosPixelsR = 0;
                    }
                    else
                    {
                        if (todosPixelsR > 255)
                        {
                            todosPixelsR = 255;
                        }
                    }
                    if (todosPixelsG < 0)
                    {
                        todosPixelsG = 0;
                    }
                    else
                    {
                        if (todosPixelsG > 255)
                        {
                            todosPixelsG = 255;
                        }
                    }
                    if (todosPixelsB < 0)
                    {
                        todosPixelsB = 0;
                    }
                    else
                    {
                        if (todosPixelsB > 255)
                        {
                            todosPixelsB = 255;
                        }

                    }
                    NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, todosPixelsR, todosPixelsG, todosPixelsB));
                    todosPixelsR = 0;
                    todosPixelsG = 0;
                    todosPixelsB = 0;

                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }


        private void FiltroCannys_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Cannys = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i;
            int j;
            int aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            for (i = 0; i < Altura - 2; i++)
            {
                for (j = 0; j < Largura - 2; j++)
                {
                    for (aux = 0; aux < 3; aux++)
                    {
                        for (aux2 = 0; aux2 < 3; aux2++)
                        {
                            todosPixelsR += Imagem.GetPixel(j + aux, i + aux2).R * Cannys[aux2, aux];
                            todosPixelsG += Imagem.GetPixel(j + aux, i + aux2).G * Cannys[aux2, aux];
                            todosPixelsB += Imagem.GetPixel(j + aux, i + aux2).B * Cannys[aux2, aux];
                        }

                    }

                    /*   if ((todosPixelsR < 255) && (todosPixelsR > 0))
                            {
                                todosPixelsR = 255;
                            }                    
                        else
                         {
                            todosPixelsR = 0;
                         }

                        if ((todosPixelsG < 255) && (todosPixelsG > 0))
                        {
                            todosPixelsG = 255;
                        }
                        else
                        {
                            todosPixelsG = 0;
                        }

                        if ((todosPixelsB < 255) && (todosPixelsB > 0))
                        {
                            todosPixelsB = 255;
                        }
                        else
                        {
                            todosPixelsB = 0;
                        }*/
                    if (todosPixelsR < 0)
                    {
                        todosPixelsR = 0;
                    }
                    else
                    {
                        if (todosPixelsR > 255)
                        {
                            todosPixelsR = 255;
                        }
                    }
                    if (todosPixelsG < 0)
                    {
                        todosPixelsG = 0;
                    }
                    else
                    {
                        if (todosPixelsG > 255)
                        {
                            todosPixelsG = 255;
                        }
                    }
                    if (todosPixelsB < 0)
                    {
                        todosPixelsB = 0;
                    }
                    else
                    {
                        if (todosPixelsB > 255)
                        {
                            todosPixelsB = 255;
                        }

                    }
                    int cinza = (todosPixelsR + todosPixelsG + todosPixelsB) / 3;

                    // NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, todosPixelsR, todosPixelsG, todosPixelsB));
                    NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, cinza, cinza, cinza));
                    todosPixelsR = 0;
                    todosPixelsG = 0;
                    todosPixelsB = 0;
                    cinza = 0;

                }
            }
            pictureBoxResultado.Image = NovaImagem;



        }

        private void FiltroCannysBranco_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Cannys = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i;
            int j;
            int aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            for (i = 0; i < Altura - 2; i++)
            {
                for (j = 0; j < Largura - 2; j++)
                {
                    for (aux = 0; aux < 3; aux++)
                    {
                        for (aux2 = 0; aux2 < 3; aux2++)
                        {
                            todosPixelsR += Imagem.GetPixel(j + aux, i + aux2).R * Cannys[aux2, aux];
                            todosPixelsG += Imagem.GetPixel(j + aux, i + aux2).G * Cannys[aux2, aux];
                            todosPixelsB += Imagem.GetPixel(j + aux, i + aux2).B * Cannys[aux2, aux];
                        }

                    }

                    /*   if ((todosPixelsR < 255) && (todosPixelsR > 0))
                            {
                                todosPixelsR = 255;
                            }                    
                        else
                         {
                            todosPixelsR = 0;
                         }

                        if ((todosPixelsG < 255) && (todosPixelsG > 0))
                        {
                            todosPixelsG = 255;
                        }
                        else
                        {
                            todosPixelsG = 0;
                        }

                        if ((todosPixelsB < 255) && (todosPixelsB > 0))
                        {
                            todosPixelsB = 255;
                        }
                        else
                        {
                            todosPixelsB = 0;
                        }*/
                    if (todosPixelsR > 0)
                    {
                        todosPixelsR = 255;
                    }
                    else
                    {
                        if (todosPixelsR < 255)
                        {
                            todosPixelsR = 0;
                        }
                    }

                    if (todosPixelsG > 0)
                    {
                        todosPixelsG = 255;
                    }
                    else
                    {
                        if (todosPixelsG < 255)
                        {
                            todosPixelsG = 0;
                        }
                    }

                    if (todosPixelsB > 0)
                    {
                        todosPixelsB = 255;
                    }
                    else
                    {
                        if (todosPixelsB < 255)
                        {
                            todosPixelsB = 0;
                        }

                    }
                    int cinza = (todosPixelsR + todosPixelsG + todosPixelsB) / 3;

                    // NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, todosPixelsR, todosPixelsG, todosPixelsB));
                    NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, cinza, cinza, cinza));
                    todosPixelsR = 0;
                    todosPixelsG = 0;
                    todosPixelsB = 0;
                    cinza = 0;

                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }


        private void EscalaCinza_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;
                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void EscalaCinzaHSL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            double cinza;
            int maximo = 0;
            int minimo = 0;
            int resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;



                    if ((todospixelsR > todospixelsG) && (todospixelsR > todospixelsB))
                    {
                        maximo = todospixelsR;
                    }

                    if ((todospixelsG > todospixelsR) && (todospixelsG > todospixelsB))
                    {
                        maximo = todospixelsG;
                    }

                    if ((todospixelsB > todospixelsG) && (todospixelsB > todospixelsR))
                    {
                        maximo = todospixelsB;
                    }
                    //min
                    if ((todospixelsR < todospixelsG) && (todospixelsR < todospixelsB))
                    {
                        minimo = todospixelsR;
                    }

                    if ((todospixelsG < todospixelsR) && (todospixelsG < todospixelsB))
                    {
                        minimo = todospixelsG;
                    }

                    if ((todospixelsB < todospixelsG) && (todospixelsB < todospixelsR))
                    {
                        minimo = todospixelsB;
                    }

                    cinza = ((maximo + minimo) / 2);
                    resultado = Convert.ToInt32(cinza);

                    //  cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, resultado, resultado, resultado));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void EscalaCinzaHSV_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            double cinza;
            int maximo = 0;
            int resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;



                    if ((todospixelsR > todospixelsG) && (todospixelsR > todospixelsB))
                    {
                        maximo = todospixelsR;
                    }

                    if ((todospixelsG > todospixelsR) && (todospixelsG > todospixelsB))
                    {
                        maximo = todospixelsG;
                    }

                    if ((todospixelsB > todospixelsG) && (todospixelsB > todospixelsR))
                    {
                        maximo = todospixelsB;
                    }

                    cinza = maximo;
                    resultado = Convert.ToInt32(cinza);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, resultado, resultado, resultado));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void EscalaCinzaNTSCePAL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            double resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    resultado = ((0.299 * todospixelsR) + (0.587 * todospixelsG) + (0.114 * todospixelsB));
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }


        private void PegarImagem_Click(object sender, EventArgs e)
        {

            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            Bitmap NovaImagem = new Bitmap(pictureBoxResultado.Image);
            pictureBoxOriginal.Image = NovaImagem;

        }


        private void SubstituicaoUniformeHSI_Click(object sender, EventArgs e)
        {
            //MODELO HSI INTENSIDADE I=(R+G+B)/3
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (50 > todospixelsR))
                    {
                        todospixelsR = 0;
                    }

                    if ((51 < todospixelsR) && (101 > todospixelsR))
                    {
                        todospixelsR = 51;
                    }

                    if ((102 < todospixelsR) && (151 > todospixelsR))
                    {
                        todospixelsR = 102;
                    }

                    if ((152 < todospixelsR) && (202 > todospixelsR))
                    {
                        todospixelsR = 152;
                    }

                    if ((203 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 203;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 0;
                    }

                    if ((51 < todospixelsG) && (101 > todospixelsG))
                    {
                        todospixelsG = 51;
                    }

                    if ((102 < todospixelsG) && (151 > todospixelsG))
                    {
                        todospixelsG = 102;
                    }

                    if ((152 < todospixelsG) && (202 > todospixelsG))
                    {
                        todospixelsG = 152;
                    }

                    if ((203 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 203;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (50 > todospixelsB))
                    {
                        todospixelsB = 0;
                    }

                    if ((51 < todospixelsB) && (101 > todospixelsB))
                    {
                        todospixelsB = 51;
                    }

                    if ((102 < todospixelsB) && (151 > todospixelsB))
                    {
                        todospixelsB = 102;
                    }

                    if ((152 < todospixelsB) && (202 > todospixelsB))
                    {
                        todospixelsB = 152;
                    }

                    if ((203 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 203;
                    }

                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void SubstituicaoUniformeHSL_Click(object sender, EventArgs e)
        {
            //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            double resultado;
            int cinza;
            int max = 0;
            int min = 0;


            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (50 > todospixelsR))
                    {
                        todospixelsR = 0;
                    }

                    if ((51 < todospixelsR) && (101 > todospixelsR))
                    {
                        todospixelsR = 51;
                    }

                    if ((102 < todospixelsR) && (151 > todospixelsR))
                    {
                        todospixelsR = 102;
                    }

                    if ((152 < todospixelsR) && (202 > todospixelsR))
                    {
                        todospixelsR = 152;
                    }

                    if ((203 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 203;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 0;
                    }

                    if ((51 < todospixelsG) && (101 > todospixelsG))
                    {
                        todospixelsG = 51;
                    }

                    if ((102 < todospixelsG) && (151 > todospixelsG))
                    {
                        todospixelsG = 102;
                    }

                    if ((152 < todospixelsG) && (202 > todospixelsG))
                    {
                        todospixelsG = 152;
                    }

                    if ((203 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 203;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (50 > todospixelsB))
                    {
                        todospixelsB = 0;
                    }

                    if ((51 < todospixelsB) && (101 > todospixelsB))
                    {
                        todospixelsB = 51;
                    }

                    if ((102 < todospixelsB) && (151 > todospixelsB))
                    {
                        todospixelsB = 102;
                    }

                    if ((152 < todospixelsB) && (202 > todospixelsB))
                    {
                        todospixelsB = 152;
                    }

                    if ((203 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 203;
                    }

                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //min
                    if (todospixelsR < todospixelsG && todospixelsR < todospixelsB)
                    {
                        min = todospixelsR;
                    }
                    if (todospixelsG < todospixelsR && todospixelsG < todospixelsB)
                    {
                        min = todospixelsG;
                    }
                    if (todospixelsB < todospixelsG && todospixelsB < todospixelsR)
                    {
                        min = todospixelsB;
                    }
                    //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
                    resultado = ((max) + (min)) / 2;
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void SubstituicaoUniformeHSV_Click(object sender, EventArgs e)
        {
            //MODELO HSV - VALOR = V= max(r,g,b)
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            int max = 0;

            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (50 > todospixelsR))
                    {
                        todospixelsR = 0;
                    }

                    if ((51 < todospixelsR) && (101 > todospixelsR))
                    {
                        todospixelsR = 51;
                    }

                    if ((102 < todospixelsR) && (151 > todospixelsR))
                    {
                        todospixelsR = 102;
                    }

                    if ((152 < todospixelsR) && (202 > todospixelsR))
                    {
                        todospixelsR = 152;
                    }

                    if ((203 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 203;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 0;
                    }

                    if ((51 < todospixelsG) && (101 > todospixelsG))
                    {
                        todospixelsG = 51;
                    }

                    if ((102 < todospixelsG) && (151 > todospixelsG))
                    {
                        todospixelsG = 102;
                    }

                    if ((152 < todospixelsG) && (202 > todospixelsG))
                    {
                        todospixelsG = 152;
                    }

                    if ((203 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 203;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (50 > todospixelsB))
                    {
                        todospixelsB = 0;
                    }

                    if ((51 < todospixelsB) && (101 > todospixelsB))
                    {
                        todospixelsB = 51;
                    }

                    if ((102 < todospixelsB) && (151 > todospixelsB))
                    {
                        todospixelsB = 102;
                    }

                    if ((152 < todospixelsB) && (202 > todospixelsB))
                    {
                        todospixelsB = 152;
                    }

                    if ((203 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 203;
                    }

                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //MODELO HSV - VALOR = V= max(r,g,b)
                    cinza = max;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void SubstituicaoUniformeNTSCePAL_Click(object sender, EventArgs e)
        {
            //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            double resultado;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (50 > todospixelsR))
                    {
                        todospixelsR = 0;
                    }

                    if ((51 < todospixelsR) && (101 > todospixelsR))
                    {
                        todospixelsR = 51;
                    }

                    if ((102 < todospixelsR) && (151 > todospixelsR))
                    {
                        todospixelsR = 102;
                    }

                    if ((152 < todospixelsR) && (202 > todospixelsR))
                    {
                        todospixelsR = 152;
                    }

                    if ((203 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 203;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 0;
                    }

                    if ((51 < todospixelsG) && (101 > todospixelsG))
                    {
                        todospixelsG = 51;
                    }

                    if ((102 < todospixelsG) && (151 > todospixelsG))
                    {
                        todospixelsG = 102;
                    }

                    if ((152 < todospixelsG) && (202 > todospixelsG))
                    {
                        todospixelsG = 152;
                    }

                    if ((203 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 203;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (50 > todospixelsB))
                    {
                        todospixelsB = 0;
                    }

                    if ((51 < todospixelsB) && (101 > todospixelsB))
                    {
                        todospixelsB = 51;
                    }

                    if ((102 < todospixelsB) && (151 > todospixelsB))
                    {
                        todospixelsB = 102;
                    }

                    if ((152 < todospixelsB) && (202 > todospixelsB))
                    {
                        todospixelsB = 152;
                    }

                    if ((203 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 203;
                    }
                    //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
                    resultado = ((0.299 * todospixelsR) + (0.587 * todospixelsG) + (0.114 * todospixelsB));
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }


        private void AlgoritmodePopulodidadeHSI_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (77 > todospixelsR))
                    {
                        todospixelsR = 42;
                    }

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                    {
                        todospixelsR = 112;
                    }

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                    {
                        todospixelsR = 145;
                    }

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                    {
                        todospixelsR = 153;
                    }

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 42;
                    }

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                    {
                        todospixelsG = 112;
                    }

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                    {
                        todospixelsG = 145;
                    }

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                    {
                        todospixelsG = 153;
                    }

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                    {
                        todospixelsB = 42;
                    }

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                    {
                        todospixelsB = 112;
                    }

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                    {
                        todospixelsB = 145;
                    }

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                    {
                        todospixelsB = 153;
                    }

                    if ((183 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }

                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void AlgorotmodePopulosidadeHSL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            int max = 0;
            int min = 0;
            double resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (77 > todospixelsR))
                    {
                        todospixelsR = 42;
                    }

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                    {
                        todospixelsR = 112;
                    }

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                    {
                        todospixelsR = 145;
                    }

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                    {
                        todospixelsR = 153;
                    }

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 42;
                    }

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                    {
                        todospixelsG = 112;
                    }

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                    {
                        todospixelsG = 145;
                    }

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                    {
                        todospixelsG = 153;
                    }

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                    {
                        todospixelsB = 42;
                    }

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                    {
                        todospixelsB = 112;
                    }

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                    {
                        todospixelsB = 145;
                    }

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                    {
                        todospixelsB = 153;
                    }

                    if ((183 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }
                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //min
                    if (todospixelsR < todospixelsG && todospixelsR < todospixelsB)
                    {
                        min = todospixelsR;
                    }
                    if (todospixelsG < todospixelsR && todospixelsG < todospixelsB)
                    {
                        min = todospixelsG;
                    }
                    if (todospixelsB < todospixelsG && todospixelsB < todospixelsR)
                    {
                        min = todospixelsB;
                    }
                    //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
                    resultado = ((max) + (min)) / 2;
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void AlgoritmodepolulosidadeHSV_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            int max = 0;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (77 > todospixelsR))
                    {
                        todospixelsR = 42;
                    }

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                    {
                        todospixelsR = 112;
                    }

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                    {
                        todospixelsR = 145;
                    }

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                    {
                        todospixelsR = 153;
                    }

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 42;
                    }

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                    {
                        todospixelsG = 112;
                    }

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                    {
                        todospixelsG = 145;
                    }

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                    {
                        todospixelsG = 153;
                    }

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                    {
                        todospixelsB = 42;
                    }

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                    {
                        todospixelsB = 112;
                    }

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                    {
                        todospixelsB = 145;
                    }

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                    {
                        todospixelsB = 153;
                    }

                    if ((183 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }
                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //MODELO HSV - VALOR = V= max(r,g,b)
                    cinza = max;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void AlgoritmodePopulosidadeNTSCePAL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            double resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((0 < todospixelsR) && (77 > todospixelsR))
                    {
                        todospixelsR = 42;
                    }

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                    {
                        todospixelsR = 112;
                    }

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                    {
                        todospixelsR = 145;
                    }

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                    {
                        todospixelsR = 153;
                    }

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((0 < todospixelsG) && (50 > todospixelsG))
                    {
                        todospixelsG = 42;
                    }

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                    {
                        todospixelsG = 112;
                    }

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                    {
                        todospixelsG = 145;
                    }

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                    {
                        todospixelsG = 153;
                    }

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                    {
                        todospixelsB = 42;
                    }

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                    {
                        todospixelsB = 112;
                    }

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                    {
                        todospixelsB = 145;
                    }

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                    {
                        todospixelsB = 153;
                    }

                    if ((183 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }
                    //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
                    resultado = ((0.299 * todospixelsR) + (0.587 * todospixelsG) + (0.114 * todospixelsB));
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }


        private void AlgoritmoCorteMedianoHSI_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((42 < todospixelsR) && (89 > todospixelsR))
                    {
                        // todospixelsR = 75.4;
                        todospixelsR = 75;
                    }

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                    {
                        //todospixelsR = 108.7;
                        todospixelsR = 108;
                    }

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                    {
                        todospixelsR = 139;
                    }

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                    {
                        todospixelsR = 175;
                    }

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((42 < todospixelsG) && (89 > todospixelsG))
                    {
                        // todospixelsG = 75.4;
                        todospixelsG = 75;
                    }

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                    {
                        // todospixelsG = 108.8;
                        todospixelsG = 108;
                    }

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                    {
                        todospixelsG = 139;
                    }

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                    {
                        todospixelsG = 175;
                    }

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                    {
                        //todospixelsB = 75.4;
                        todospixelsB = 75;
                    }

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                    {
                        //todospixelsB = 108.7;
                        todospixelsB = 108;
                    }

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                    {
                        todospixelsB = 139;
                    }

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                    {
                        todospixelsB = 175;
                    }

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }

                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void AlgoritmoCorteMedianoHSL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            int max = 0;
            int min = 0;
            double resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((42 < todospixelsR) && (89 > todospixelsR))
                    {
                        // todospixelsR = 75.4;
                        todospixelsR = 75;
                    }

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                    {
                        //todospixelsR = 108.7;
                        todospixelsR = 108;
                    }

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                    {
                        todospixelsR = 139;
                    }

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                    {
                        todospixelsR = 175;
                    }

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((42 < todospixelsG) && (89 > todospixelsG))
                    {
                        // todospixelsG = 75.4;
                        todospixelsG = 75;
                    }

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                    {
                        // todospixelsG = 108.8;
                        todospixelsG = 108;
                    }

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                    {
                        todospixelsG = 139;
                    }

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                    {
                        todospixelsG = 175;
                    }

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                    {
                        //todospixelsB = 75.4;
                        todospixelsB = 75;
                    }

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                    {
                        //todospixelsB = 108.7;
                        todospixelsB = 108;
                    }

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                    {
                        todospixelsB = 139;
                    }

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                    {
                        todospixelsB = 175;
                    }

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }
                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //min
                    if (todospixelsR < todospixelsG && todospixelsR < todospixelsB)
                    {
                        min = todospixelsR;
                    }
                    if (todospixelsG < todospixelsR && todospixelsG < todospixelsB)
                    {
                        min = todospixelsG;
                    }
                    if (todospixelsB < todospixelsG && todospixelsB < todospixelsR)
                    {
                        min = todospixelsB;
                    }
                    //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
                    resultado = ((max) + (min)) / 2;
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;

        }

        private void AlgoritmodeCorteMedianoHSV_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            int max = 0;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((42 < todospixelsR) && (89 > todospixelsR))
                    {
                        // todospixelsR = 75.4;
                        todospixelsR = 75;
                    }

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                    {
                        //todospixelsR = 108.7;
                        todospixelsR = 108;
                    }

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                    {
                        todospixelsR = 139;
                    }

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                    {
                        todospixelsR = 175;
                    }

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((42 < todospixelsG) && (89 > todospixelsG))
                    {
                        // todospixelsG = 75.4;
                        todospixelsG = 75;
                    }

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                    {
                        // todospixelsG = 108.8;
                        todospixelsG = 108;
                    }

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                    {
                        todospixelsG = 139;
                    }

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                    {
                        todospixelsG = 175;
                    }

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                    {
                        //todospixelsB = 75.4;
                        todospixelsB = 75;
                    }

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                    {
                        //todospixelsB = 108.7;
                        todospixelsB = 108;
                    }

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                    {
                        todospixelsB = 139;
                    }

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                    {
                        todospixelsB = 175;
                    }

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }
                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                    {
                        max = todospixelsR;
                    }
                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                    {
                        max = todospixelsG;
                    }
                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                    {
                        max = todospixelsB;
                    }
                    //MODELO HSV - VALOR = V= max(r,g,b)
                    cinza = max;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void AlgotimodeCorteMedianoNTSCePAL_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            double resultado;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;

                    // pixels R 

                    if ((42 < todospixelsR) && (89 > todospixelsR))
                    {
                        // todospixelsR = 75.4;
                        todospixelsR = 75;
                    }

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                    {
                        //todospixelsR = 108.7;
                        todospixelsR = 108;
                    }

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                    {
                        todospixelsR = 139;
                    }

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                    {
                        todospixelsR = 175;
                    }

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                    {
                        todospixelsR = 211;
                    }

                    // pixels G

                    if ((42 < todospixelsG) && (89 > todospixelsG))
                    {
                        // todospixelsG = 75.4;
                        todospixelsG = 75;
                    }

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                    {
                        // todospixelsG = 108.8;
                        todospixelsG = 108;
                    }

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                    {
                        todospixelsG = 139;
                    }

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                    {
                        todospixelsG = 175;
                    }

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                    {
                        todospixelsG = 211;
                    }

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                    {
                        //todospixelsB = 75.4;
                        todospixelsB = 75;
                    }

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                    {
                        //todospixelsB = 108.7;
                        todospixelsB = 108;
                    }

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                    {
                        todospixelsB = 139;
                    }

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                    {
                        todospixelsB = 175;
                    }

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                    {
                        todospixelsB = 211;
                    }

                    //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
                    resultado = ((0.299 * todospixelsR) + (0.587 * todospixelsG) + (0.114 * todospixelsB));
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));

                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

                int todospixelsR;
                int todospixelsG;
                int todospixelsB;
                int Largura = Imagem.Width;
                int Altura = Imagem.Height;
                double cinza;
                int maximo = 0;
                int minimo = 0;
                int resultado;
                Bitmap NovaImagem = new Bitmap(Largura, Altura);
                for (int x = 0; x < Largura; x++)
                {
                    for (int y = 0; y < Altura; y++)
                    {
                        todospixelsR = Imagem.GetPixel(x, y).R;
                        todospixelsG = Imagem.GetPixel(x, y).G;
                        todospixelsB = Imagem.GetPixel(x, y).B;



                        if ((todospixelsR > todospixelsG) && (todospixelsR > todospixelsB))
                        {
                            todospixelsR = 255;
                        }

                        if ((todospixelsG > todospixelsR) && (todospixelsG > todospixelsB))
                        {
                          todospixelsB = 255;
                        }

                        if ((todospixelsB > todospixelsG) && (todospixelsB > todospixelsR))
                        {
                           todospixelsB = 255;
                        }
                           //min
                        if ((todospixelsR < todospixelsG) && (todospixelsR < todospixelsB))
                             {
                               todospixelsR = 0;
                             }

                             if ((todospixelsG < todospixelsR) && (todospixelsG < todospixelsB))
                             {
                                todospixelsG = 0;
                             }

                             if ((todospixelsB < todospixelsG) && (todospixelsB < todospixelsR))
                             {
                                todospixelsB =0;
                             }
    
                            //cinza = ((maximo + minimo) / 2);
                            // resultado = Convert.ToInt32(cinza);

                            //  cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                            //NovaImagem.SetPixel(x, y, Color.FromArgb(255, resultado, resultado, resultado));
                            NovaImagem.SetPixel(x, y, Color.FromArgb(255, todospixelsR, todospixelsG, todospixelsB));
                        }
                    }
                    pictureBoxResultado.Image = NovaImagem;
                }















            }

        }
    }

    
