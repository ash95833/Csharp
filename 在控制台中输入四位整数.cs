﻿using System;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.从整数中获取每位         
            Console.WriteLine("请输入4位整数");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            int result = number % 10;
            result += number / 10 % 10;
            result += number / 100 % 10;
            result += number / 1000;
            Console.WriteLine("结果为：" + result);

            #region 2.从字符串中获取每个字符
            char c1 = strNumber[0];
            string s1 = c1.ToString();
            int n1 = int.Parse(s1);
            int result02 = n1;
            result02 += int.Parse(strNumber[1].ToString());
            result02 += int.Parse(strNumber[2].ToString());
            result02 += int.Parse(strNumber[3].ToString());
            Console.WriteLine("结果为：=result02");
            #endregion 
        }
    }
}