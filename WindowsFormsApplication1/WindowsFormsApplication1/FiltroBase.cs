using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class FiltroBase
    {
        public int Largura { get; protected set; }
        public int Altura { get; protected set; }
        public int pixelR { get; protected set; }
        public int pixelG { get; protected set; }
        public int pixelB { get; protected set; }
        public int pixelA { get; protected set; }

        public int[] todosPixeisR { get; protected set; }
        public int[] todosPixeisG { get; protected set; }
        public int[] todosPixeisB { get; protected set; }
        public int[] todosPixeisA { get; protected set; }

        public FiltroBase()
        {
            Largura = 0;
            Altura = 0;
            pixelR = 0;
            pixelG = 0;
            pixelB = 0;
            pixelA = 0;
            todosPixeisR = new int[9];
            todosPixeisG = new int[9];
            todosPixeisB = new int[9];
            todosPixeisA = new int[9];
        }
    }
}
