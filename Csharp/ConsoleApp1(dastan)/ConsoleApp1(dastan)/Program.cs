﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_dastan_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Сколько вам лет?");
            //int age = Convert.ToInt32(Console.ReadLine());

            ////string s_age = Convert.ToString(age); 

            //Console.WriteLine("Ваш возвраст:"+age);
            //if(age > 18)
            //{
            //    Console.WriteLine("Вы большой!");
            //}

            //int a = 0;
            //while (a < 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

            var arr = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7 };

            foreach(int num in arr){
                Console.WriteLine(num);

            }

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            
        }
    }
}
