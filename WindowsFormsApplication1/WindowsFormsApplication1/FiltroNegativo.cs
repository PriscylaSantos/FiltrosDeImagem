using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroNegativo : FiltroBase
    {
        public Bitmap Negativo(Bitmap Imagem, int opcao)
        {
            // Opção =>  = 0  Negativo Escala Cinza ;  != 0  Negativo Normal
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            Color originalCor, CorEmNegativo;
            Bitmap ImagemCinza, NovaImagem = new Bitmap(Largura, Altura);

            if (opcao == 0)
            {
                FiltroCinza filtro = new FiltroCinza();
                ImagemCinza = filtro.HSI(Imagem);

                for (int i = 0; i < Largura; i++)
                {
                    for (int j = 0; j < Altura; j++)
                    {
                        originalCor = ImagemCinza.GetPixel(i, j);
                        CorEmNegativo = Color.FromArgb(255 - originalCor.R, 
                            255 - originalCor.G, 255 - originalCor.B);

                        NovaImagem.SetPixel(i, j, CorEmNegativo);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Largura; i++)
                {
                    for (int j = 0; j < Altura; j++)
                    {
                        originalCor = Imagem.GetPixel(i, j);
                        CorEmNegativo = Color.FromArgb(255 - originalCor.R, 255 - originalCor.G, 255 - originalCor.B);

                        NovaImagem.SetPixel(i, j, CorEmNegativo);
                    }
                }
            }
            return NovaImagem;
        }

    }
}
