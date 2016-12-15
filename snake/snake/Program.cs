using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
           //рамка
            HorizontaiLine line = new HorizontaiLine(0,78,0,'+');
            HorizontaiLine line1 = new HorizontaiLine(0, 78, 24, '+');
            VerticalLine line2 = new VerticalLine(0, 24, 0, '+');
            VerticalLine line3 = new VerticalLine(0, 24, 78, '+');
            line.Drow();
            line1.Drow();
            line2.Drow();
            line3.Drow();

            // точка
            Point p = new Point(4, 5, '+');
            p.Draw();
            Console.ReadLine();
        }
      
    }

}
