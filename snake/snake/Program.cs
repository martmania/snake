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

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*');
            snake Snake = new snake(p, 4, Direction.RIGHT);
            Snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(Snake) || Snake.IsHitTail())
                {
                    break;
                }
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
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey(key.Key);
                }
            }
        }
    }
}
      

