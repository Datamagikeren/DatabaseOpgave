using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOpgave
{
    public class ColorPalette
    {
       /// <summary>
       /// Ændrer farven på alt Console text. Husk at reset
       /// </summary>
       /// <param name="color">Hvilken farve skriften bliver</param>
       public void Color(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
