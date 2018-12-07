using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroCinza : FiltroBase
    {
        public Bitmap HSI(Bitmap Imagem)
        {
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            Largura = Imagem.Width;
            Altura = Imagem.Height;
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
            return NovaImagem;
        }

        public Bitmap HSL(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
                        maximo = todospixelsR;

                    if ((todospixelsG > todospixelsR) && (todospixelsG > todospixelsB))
                        maximo = todospixelsG;

                    if ((todospixelsB > todospixelsG) && (todospixelsB > todospixelsR))
                        maximo = todospixelsB;

                    if ((todospixelsR < todospixelsG) && (todospixelsR < todospixelsB))
                        minimo = todospixelsR;

                    if ((todospixelsG < todospixelsR) && (todospixelsG < todospixelsB))
                        minimo = todospixelsG;

                    if ((todospixelsB < todospixelsG) && (todospixelsB < todospixelsR))
                        minimo = todospixelsB;

                    cinza = ((maximo + minimo) / 2);
                    resultado = Convert.ToInt32(cinza);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, resultado, resultado, resultado));
                }
            }
            return NovaImagem;
        }

        public Bitmap HSV(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
                        maximo = todospixelsR;

                    if ((todospixelsG > todospixelsR) && (todospixelsG > todospixelsB))
                        maximo = todospixelsG;

                    if ((todospixelsB > todospixelsG) && (todospixelsB > todospixelsR))
                        maximo = todospixelsB;

                    cinza = maximo;
                    resultado = Convert.ToInt32(cinza);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, resultado, resultado, resultado));
                }
            }
            return NovaImagem;
        }

        public Bitmap NTSCePAL(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
            return NovaImagem;
        }

    }
}
