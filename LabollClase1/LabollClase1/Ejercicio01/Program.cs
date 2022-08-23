<<<<<<< HEAD
﻿using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxMaxNum = 0;
            int auxMinNum = 0;
            float auxPromNum = 0;
            int i = 0;

            while (i != 5)
           
            {
                int varEscalar = int.Parse(Console.ReadLine());

                if (varEscalar > auxMaxNum)
                {
                    auxMaxNum = varEscalar;
                }
                else if (varEscalar < auxMinNum)
                {
                    auxMinNum = varEscalar;
                }

                auxPromNum = auxPromNum + varEscalar;
                i++;
            }
            auxPromNum = auxPromNum / 5;
            Console.WriteLine("El num max es : {0} El num min: {1} y el prom: {2}" ,auxMaxNum ,auxMinNum ,auxPromNum);
        }
    }
}
=======
﻿using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxMaxNum = 0;
            int auxMinNum = 0;
            float auxPromNum = 0;
            int i = 0;

            while (i != 5)
           
            {
                int varEscalar = int.Parse(Console.ReadLine());

                if (varEscalar > auxMaxNum)
                {
                    auxMaxNum = varEscalar;
                }
                else if (varEscalar < auxMinNum)
                {
                    auxMinNum = varEscalar;
                }

                auxPromNum = auxPromNum + varEscalar;
                i++;
            }
            auxPromNum = auxPromNum / 5;
            Console.WriteLine("El num max es : {0} El num min: {1} y el prom: {2}" ,auxMaxNum ,auxMinNum ,auxPromNum);
        }
    }
}
>>>>>>> 7deca8c9e96887cb1206b1acd045eab5265dd2d4
