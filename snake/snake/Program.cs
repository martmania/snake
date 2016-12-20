using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {

        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figures fSnake = new snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            snake Snake = (snake)fSnake;

            HorizontaiLine h1 = new HorizontaiLine(0, 5, 6, '&');

            List<Figures> figures = new List<Figures>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }
            static void Draw(Figures figures)
            {
                figures.Draw();
            }
        }
    }
      

