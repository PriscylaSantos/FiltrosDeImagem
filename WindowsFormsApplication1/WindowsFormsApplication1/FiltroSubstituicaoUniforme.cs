using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroSubstituicaoUniforme : FiltroBase
    {
        public Bitmap HSI(Bitmap Imagem)
        {
            //MODELO HSI INTENSIDADE I=(R+G+B)/3
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
            return NovaImagem;
        }

        public Bitmap HSL(Bitmap Imagem)
        {
            //MODELO HSL - LUMINOSIDADE= L(max(r,g,b) + min(r,g,b))/2
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
                    resultado = ((double)(max) + (double)(min)) / 2;
                    cinza = Convert.ToInt32(resultado);
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            return NovaImagem;
        }

        public Bitmap HSV(Bitmap Imagem)
        {
            //MODELO HSV - VALOR = V= max(r,g,b)
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
            return NovaImagem;
        }

        public Bitmap NTSCePal(Bitmap Imagem)
        {
            //MODELO NTSC/PAL - LUMINANCIA = Y=(0.299*R)+(0.587*G)+(0.114*B)
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
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
                        todospixelsR = 0;

                    if ((51 < todospixelsR) && (101 > todospixelsR))
                        todospixelsR = 51;

                    if ((102 < todospixelsR) && (151 > todospixelsR))
                        todospixelsR = 102;

                    if ((152 < todospixelsR) && (202 > todospixelsR))

                        todospixelsR = 152;

                    if ((203 < todospixelsR) && (255 > todospixelsR))
                        todospixelsR = 203;

                    // pixels G
                    if ((0 < todospixelsG) && (50 > todospixelsG))
                        todospixelsG = 0;

                    if ((51 < todospixelsG) && (101 > todospixelsG))
                        todospixelsG = 51;

                    if ((102 < todospixelsG) && (151 > todospixelsG))
                        todospixelsG = 102;

                    if ((152 < todospixelsG) && (202 > todospixelsG))
                        todospixelsG = 152;

                    if ((203 < todospixelsG) && (255 > todospixelsG))
                        todospixelsG = 203;

                    //pixels B
                    if ((0 < todospixelsB) && (50 > todospixelsB))
                        todospixelsB = 0;

                    if ((51 < todospixelsB) && (101 > todospixelsB))
                        todospixelsB = 51;

                    if ((102 < todospixelsB) && (151 > todospixelsB))
                        todospixelsB = 102;

                    if ((152 < todospixelsB) && (202 > todospixelsB))
                        todospixelsB = 152;

                    if ((203 < todospixelsB) && (255 > todospixelsB))
                        todospixelsB = 203;

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
