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
            Console.SetBufferSize(80, 25);
            //рамка
            HorizontaiLine upline = new HorizontaiLine(0,78,0,'+');
            HorizontaiLine downline = new HorizontaiLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rigthline = new VerticalLine(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rigthline.Drow();

            // точка
            Point p = new Point(4, 5, '*');
            snake Snake = new snake(p, 4, Direction.RIGHT);
            Snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (Snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    Snake.Move();
                }
                Thread.Sleep(100);
               
           
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey(key.Key);
              
                }
            }
        }
    }
      
    }

