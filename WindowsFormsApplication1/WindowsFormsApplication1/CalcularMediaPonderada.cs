using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class CalcularMediaPonderada
    {
        public static int[] Compute(int[] mediaP, int valor)                //retorna a array ordenada
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
