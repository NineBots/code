using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_quad
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool checkQuad = false;
            int side;
            int[,] array = new int [7,7];
            for(int x = 0; x < array.GetLength(0); x++)//создание массива
            {
                for(int y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = 1;
                }
            }
            for (int y = 2; y < 6; y++)////заполнение кадрата
            {
                for (int x = 2; x < 7; x++)
                {
                    array[x, y] = 0;
                }
            }
            for (int y = 0; y < array.GetLength(1); y++)//вывод массива
            {
                for (int x = 0; x < array.GetLength(0); x++)
                {
                    Console.Write($"{array[x, y]} " );
                    if (x == array.GetLength(0) - 1) { Console.WriteLine(); }
                }
            }
            
            for (int y = 0; y < array.GetLength(1) && checkQuad == false; y++)
            {
                if (checkQuad == true)
                {
                    break;
                }
                for (int x = 0; x < array.GetLength(0) && checkQuad == false; x++)
                {
                    if(checkQuad == true)
                    {
                        break;
                    }
                    side = 1;
                    int summX =0;
                    int summY=0;
                    if (x + 1 < array.GetLength(0) && y + 1 < array.GetLength(1))
                    {

                        if (array[x, y] == 0 && array[x + side, y + side] == 0)//условие наименьшего квадрата
                        {
                            do
                            {
                                if (x + side >= array.GetLength(0)-1 || y + side >= array.GetLength(1)-1)
                                {
                                    break;
                                }

                                for (int j = y + side-1; j >= y; j--)//уходим в нижний правый угол и считем стороны
                                {
                                    summY += array[x + side, j];//права сторона
                                }
                                for (int i = x + side-1; i >= x; i--)
                                {
                                    summX += array[i, y + side];//нижняя сторона
                                }
                                if (summX != 0 || summY != 0 && side >= 2)
                                {
                                    summX = 0;
                                    summY = 0;
                                    if (y - 1 >= 0 && y + side <= array.GetLength(1))//проверяем на наличие лишних нулей сверху и снизу
                                    {
                                        for (int k = 0; k <= side; k++)
                                        {
                                            summX += array[x + k, y - 1];
                                            summX += array[x + k, y + side];
                                        }
                                    }
                                    if (x - 1 >= 0 && x + side <= array.GetLength(0))//проверяем на наличие нулей слева и справа
                                    {
                                        for (int k = 0; k <= side; k++)
                                        {
                                            summY += array[x - 1, y + k];
                                            summY += array[x + side, y + k];
                                        }
                                    }
                                    if ((side + 1) * 4 == summX + summY)
                                    {
                                        Console.WriteLine($"квадрат с координатами X:{x} Y: {y} и стороной: {side}");
                                        checkQuad = true;
                                        break;
                                    }
                                    else { break; }
                                }
                                else if (summX == 0 && summY == 0 && x + side < array.GetLength(0) && y + side < array.GetLength(1)) { side++; }
                                else break;
                            } while (true);
                        }
                    }
                }

            }
            if( checkQuad == false) { Console.WriteLine("Квадрата нет"); }
        }
    }
}
