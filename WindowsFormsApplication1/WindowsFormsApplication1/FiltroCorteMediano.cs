using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroCorteMediano : FiltroBase
    {
        public Bitmap HSI(Bitmap Imagem)
        {
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
                        todospixelsR = 75;

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                        todospixelsR = 108;

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                        todospixelsR = 139;

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                        todospixelsR = 175;

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((42 < todospixelsG) && (89 > todospixelsG))
                        todospixelsG = 75;

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                        todospixelsG = 108;

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                        todospixelsG = 139;

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                        todospixelsG = 175;

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                        todospixelsB = 75;

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                        todospixelsB = 108;

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                        todospixelsB = 139;

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                        todospixelsB = 175;

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                        todospixelsB = 211;

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
                        todospixelsR = 75;

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                        todospixelsR = 108;

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                        todospixelsR = 139;

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                        todospixelsR = 175;

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((42 < todospixelsG) && (89 > todospixelsG))
                        todospixelsG = 75;

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                        todospixelsG = 108;

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                        todospixelsG = 139;

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                        todospixelsG = 175;

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                        todospixelsB = 75;

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                        todospixelsB = 108;

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                        todospixelsB = 139;

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                        todospixelsB = 175;

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                        todospixelsB = 211;

                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                        max = todospixelsR;

                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                        max = todospixelsG;

                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                        max = todospixelsB;

                    //min
                    if (todospixelsR < todospixelsG && todospixelsR < todospixelsB)
                        min = todospixelsR;

                    if (todospixelsG < todospixelsR && todospixelsG < todospixelsB)
                        min = todospixelsG;

                    if (todospixelsB < todospixelsG && todospixelsB < todospixelsR)
                        min = todospixelsB;

                    //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
                    resultado = ((double)(max) + (double)(min)) / 2;
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
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
                        todospixelsR = 75;

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                        todospixelsR = 108;

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                        todospixelsR = 139;

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                        todospixelsR = 175;

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G               
                    if ((42 < todospixelsG) && (89 > todospixelsG))
                        todospixelsG = 75;

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                        todospixelsG = 108;

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                        todospixelsG = 139;

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                        todospixelsG = 175;

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                        todospixelsB = 75;

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                        todospixelsB = 108;

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                        todospixelsB = 139;

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                        todospixelsB = 175;

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                        todospixelsB = 211;

                    //max
                    if (todospixelsR > todospixelsG && todospixelsR > todospixelsB)
                        max = todospixelsR;

                    if (todospixelsG > todospixelsR && todospixelsG > todospixelsB)
                        max = todospixelsG;

                    if (todospixelsB > todospixelsG && todospixelsB > todospixelsR)
                        max = todospixelsB;

                    //MODELO HSV - VALOR = V= max(r,g,b)
                    cinza = max;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
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

                    // pixels R 
                    if ((42 < todospixelsR) && (89 > todospixelsR))
                        todospixelsR = 75;

                    if ((90 < todospixelsR) && (123 > todospixelsR))
                        todospixelsR = 108;

                    if ((124 < todospixelsR) && (145 > todospixelsR))
                        todospixelsR = 139;

                    if ((146 < todospixelsR) && (189 > todospixelsR))
                        todospixelsR = 175;

                    if ((190 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((42 < todospixelsG) && (89 > todospixelsG))
                        todospixelsG = 75;

                    if ((90 < todospixelsG) && (123 > todospixelsG))
                        todospixelsG = 108;

                    if ((124 < todospixelsG) && (145 > todospixelsG))
                        todospixelsG = 139;

                    if ((146 < todospixelsG) && (189 > todospixelsG))
                        todospixelsG = 175;

                    if ((190 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((42 < todospixelsB) && (89 > todospixelsB))
                        todospixelsB = 75;

                    if ((90 < todospixelsB) && (123 > todospixelsB))
                        todospixelsB = 108;

                    if ((124 < todospixelsB) && (145 > todospixelsB))
                        todospixelsB = 139;

                    if ((146 < todospixelsB) && (189 > todospixelsB))
                        todospixelsB = 175;

                    if ((190 < todospixelsB) && (255 > todospixelsB))
                        todospixelsB = 211;

                    //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
                    resultado = ((0.299 * todospixelsR) + (0.587 * todospixelsG) + (0.114 * todospixelsB));
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            return NovaImagem;
        }

    }
}
