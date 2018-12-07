using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class FiltroBordas : FiltroBase
    {
        public Bitmap Sobel(Bitmap Imagem, int opcao)
        {
            // Opção =>  = 0  normal ;  != 0  invertido
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int[,] Sobely = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] Sobelx = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            int limite = 128 * 128;
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;

            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
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
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                        else
                            NovaImagem.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Black);
                        else
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                    }
                }
            }
            return NovaImagem;
        }

        public Bitmap Prewitt(Bitmap Imagem, int opcao)
        {
            // Opção =>  = 0  normal ;  != 0  invertido
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int[,] Prewittx = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            int[,] Prewitty = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };

            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            int limite = 128 * 128;
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
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
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                        else
                            NovaImagem.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Black);
                        else
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                    }
                }
            }
            return NovaImagem;
        }

        public Bitmap Roberts(Bitmap Imagem, int opcao)
        {
            // Opção =>  = 0  normal ;  != 0  invertido
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int[,] Robertsx = new int[,] { { 1, 0 }, { 0, -1 } };
            int[,] Robertsy = new int[,] { { 0, 1 }, { -1, 0 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            int limite = 128 * 128;
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
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
                         (((novo_rx * novo_rx) * (novo_rx * novo_rx)) + ((novo_ry * novo_ry) * (novo_ry * novo_ry))) / 2 > limite ||
                        (((novo_gx * novo_gx) * (novo_gx * novo_gx)) + ((novo_gy * novo_gy) * (novo_gy * novo_gy))) / 2 > limite ||
                         (((novo_bx * novo_bx) * (novo_bx * novo_bx)) + ((novo_by * novo_by) * (novo_by * novo_by))) / 2 > limite
                        )
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                        else
                            NovaImagem.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        if (opcao == 0)
                            NovaImagem.SetPixel(i, j, Color.Black);
                        else
                            NovaImagem.SetPixel(i, j, Color.Transparent);
                    }
                }
            }
            return NovaImagem;
        }

        public Bitmap LaPlace(Bitmap Imagem, int[,] filtroWindow)
        {
            // filtroWindow recebe o filtro que será convoluido com a imagem
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int[,] Laplace = filtroWindow;
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i, j, aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
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
            return NovaImagem;
        }

        public Bitmap Cannys(Bitmap Imagem, int opcao)
        {
            // Opção =>  = 0  normal ;  != 0  invertido
            Largura = Imagem.Width;
            Altura = Imagem.Height;
            int[,] Cannys = new int[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            int todosPixelsR = 0;
            int todosPixelsG = 0;
            int todosPixelsB = 0;
            int i, j, aux, aux2;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
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
                    if (opcao == 0)
                    {
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
                    }
                    else
                    {
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
                    }
                    int cinza = (todosPixelsR + todosPixelsG + todosPixelsB) / 3;

                    NovaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, cinza, cinza, cinza));
                    todosPixelsR = 0;
                    todosPixelsG = 0;
                    todosPixelsB = 0;
                }
            }
            return NovaImagem;
        }


    }
}
