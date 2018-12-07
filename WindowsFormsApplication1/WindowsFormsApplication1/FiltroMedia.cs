using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroMedia : FiltroBase
    {
        public Bitmap Media(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int i, j;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
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

                             Imagem.GetPixel(i + 1, j - 1).R +
                             Imagem.GetPixel(i + 1, j).R +
                             Imagem.GetPixel(i + 1, j + 1).R) / 9;

                    pixelG = (
                             Imagem.GetPixel(i - 1, j - 1).G +
                             Imagem.GetPixel(i - 1, j).G +
                             Imagem.GetPixel(i - 1, j + 1).G +

                             Imagem.GetPixel(i, j - 1).G +
                             Imagem.GetPixel(i, j).G +
                             Imagem.GetPixel(i, j + 1).G +

                             Imagem.GetPixel(i + 1, j - 1).G +
                             Imagem.GetPixel(i + 1, j).G +
                             Imagem.GetPixel(i + 1, j + 1).G) / 9;

                    pixelB = (
                              Imagem.GetPixel(i - 1, j - 1).B +
                              Imagem.GetPixel(i - 1, j).B +
                              Imagem.GetPixel(i - 1, j + 1).B +

                              Imagem.GetPixel(i, j - 1).B +
                              Imagem.GetPixel(i, j).B +
                              Imagem.GetPixel(i, j + 1).B +

                              Imagem.GetPixel(i + 1, j - 1).B +
                              Imagem.GetPixel(i + 1, j).B +
                              Imagem.GetPixel(i + 1, j + 1).B) / 9;

                    pixelA = (
                             Imagem.GetPixel(i - 1, j - 1).A +
                             Imagem.GetPixel(i - 1, j).A +
                             Imagem.GetPixel(i - 1, j + 1).A +

                             Imagem.GetPixel(i, j - 1).A +
                             Imagem.GetPixel(i, j).A +
                             Imagem.GetPixel(i, j + 1).A +

                             Imagem.GetPixel(i + 1, j - 1).A +
                             Imagem.GetPixel(i + 1, j).A +
                             Imagem.GetPixel(i + 1, j + 1).A) / 9;

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            return NovaImagem;
        }

        public Bitmap MediaPonderada(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int i, j;
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

                    todosPixeisR[6] = Imagem.GetPixel(i + 1, j - 1).R;
                    todosPixeisR[7] = Imagem.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = Imagem.GetPixel(i + 1, j + 1).R;

                    CalcularMediaPonderada(todosPixeisR, valor);
                    pixelR = todosPixeisR[valor];

                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G;
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    CalcularMediaPonderada(todosPixeisG, valor);
                    pixelG = todosPixeisG[valor];

                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B;
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    CalcularMediaPonderada(todosPixeisB, valor);
                    pixelB = todosPixeisB[valor];

                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A;
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    CalcularMediaPonderada(todosPixeisA, valor);
                    pixelA = todosPixeisG[valor];

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            return NovaImagem;
        }

        public static int[] CalcularMediaPonderada(int[] mediaP, int valor)                //retorna a array ordenada
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
}
