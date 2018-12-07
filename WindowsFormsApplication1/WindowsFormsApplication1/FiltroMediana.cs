using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroMediana : FiltroBase
    {
        public Bitmap Mediana(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int i, j;

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

                    Ordenacao.quickSort(todosPixeisR);
                    pixelR = todosPixeisR[4];

                    todosPixeisG[0] = Imagem.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = Imagem.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = Imagem.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = Imagem.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = Imagem.GetPixel(i, j).G;
                    todosPixeisG[5] = Imagem.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = Imagem.GetPixel(i + 1, j - 1).G;
                    todosPixeisG[7] = Imagem.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = Imagem.GetPixel(i + 1, j + 1).G;

                    Ordenacao.quickSort(todosPixeisG);
                    pixelG = todosPixeisG[4];

                    todosPixeisB[0] = Imagem.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = Imagem.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = Imagem.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = Imagem.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = Imagem.GetPixel(i, j).B;
                    todosPixeisB[5] = Imagem.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = Imagem.GetPixel(i + 1, j - 1).B;
                    todosPixeisB[7] = Imagem.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = Imagem.GetPixel(i + 1, j + 1).B;

                    Ordenacao.quickSort(todosPixeisB);
                    pixelB = todosPixeisB[4];

                    todosPixeisA[0] = Imagem.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = Imagem.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = Imagem.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = Imagem.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = Imagem.GetPixel(i, j).A;
                    todosPixeisA[5] = Imagem.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = Imagem.GetPixel(i + 1, j - 1).A;
                    todosPixeisA[7] = Imagem.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = Imagem.GetPixel(i + 1, j + 1).A;

                    Ordenacao.quickSort(todosPixeisA);
                    pixelA = todosPixeisA[4];

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            return NovaImagem;
        }

    }
}
