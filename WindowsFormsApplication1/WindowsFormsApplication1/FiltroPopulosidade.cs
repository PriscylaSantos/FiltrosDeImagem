using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class FiltroPopulosidade : FiltroBase
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
                    if ((0 < todospixelsR) && (77 > todospixelsR))
                        todospixelsR = 42;

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                        todospixelsR = 112;

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                        todospixelsR = 145;

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                        todospixelsR = 153;

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((0 < todospixelsG) && (50 > todospixelsG))
                        todospixelsG = 42;

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                        todospixelsG = 112;

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                        todospixelsG = 145;

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                    {
                        todospixelsG = 153;
                    }

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                        todospixelsB = 42;

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                        todospixelsB = 112;

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                        todospixelsB = 145;

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                        todospixelsB = 153;

                    if ((183 < todospixelsB) && (255 > todospixelsB))
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
                    if ((0 < todospixelsR) && (77 > todospixelsR))
                        todospixelsR = 42;

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                        todospixelsR = 112;

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                        todospixelsR = 145;

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                        todospixelsR = 153;

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((0 < todospixelsG) && (50 > todospixelsG))
                        todospixelsG = 42;

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                        todospixelsG = 112;

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                        todospixelsG = 145;

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                        todospixelsG = 153;

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                        todospixelsB = 42;

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                        todospixelsB = 112;

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                        todospixelsB = 145;

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                        todospixelsB = 153;

                    if ((183 < todospixelsB) && (255 > todospixelsB))
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
                    if ((0 < todospixelsR) && (77 > todospixelsR))
                        todospixelsR = 42;

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                        todospixelsR = 112;

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                        todospixelsR = 145;

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                        todospixelsR = 153;

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((0 < todospixelsG) && (50 > todospixelsG))
                        todospixelsG = 42;

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                        todospixelsG = 112;

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                        todospixelsG = 145;

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                        todospixelsG = 153;

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                        todospixelsB = 42;

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                        todospixelsB = 112;

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                        todospixelsB = 145;

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                        todospixelsB = 153;

                    if ((183 < todospixelsB) && (255 > todospixelsB))
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
                    if ((0 < todospixelsR) && (77 > todospixelsR))
                        todospixelsR = 42;

                    if ((78 < todospixelsR) && (128 > todospixelsR))
                        todospixelsR = 112;

                    if ((129 < todospixelsR) && (149 > todospixelsR))
                        todospixelsR = 145;

                    if ((150 < todospixelsR) && (182 > todospixelsR))
                        todospixelsR = 153;

                    if ((183 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 211;

                    // pixels G
                    if ((0 < todospixelsG) && (50 > todospixelsG))
                        todospixelsG = 42;

                    if ((78 < todospixelsG) && (128 > todospixelsG))
                        todospixelsG = 112;

                    if ((129 < todospixelsG) && (149 > todospixelsG))
                        todospixelsG = 145;

                    if ((150 < todospixelsG) && (182 > todospixelsG))
                        todospixelsG = 153;

                    if ((183 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 211;

                    //pixels B
                    if ((0 < todospixelsB) && (77 > todospixelsB))
                        todospixelsB = 42;

                    if ((78 < todospixelsB) && (128 > todospixelsB))
                        todospixelsB = 112;

                    if ((129 < todospixelsB) && (149 > todospixelsB))
                        todospixelsB = 145;

                    if ((150 < todospixelsB) && (182 > todospixelsB))
                        todospixelsB = 153;

                    if ((183 < todospixelsB) && (255 > todospixelsB))
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
