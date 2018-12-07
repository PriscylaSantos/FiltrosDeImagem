using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroModa : FiltroBase
    {
        public Bitmap Moda(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int i, j;
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

                    Ordenacao.quickSort(todosPixeisR);
                    CalcularModa(todosPixeisR, valor);
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

                    Ordenacao.quickSort(todosPixeisG);
                    CalcularModa(todosPixeisG, valor);
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

                    Ordenacao.quickSort(todosPixeisB);
                    CalcularModa(todosPixeisB, valor);
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

                    Ordenacao.quickSort(todosPixeisA);
                    CalcularModa(todosPixeisA, valor);
                    pixelA = todosPixeisG[valor];

                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            return NovaImagem;
        }

        public static int[] CalcularModa(int[] moda, int valor)                //retorna a array ordenada
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
}
