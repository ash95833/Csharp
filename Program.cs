using System;

namespace Day01
{
    class Program
    {
        static void Main()
        {
            Console.Title = "俺的第一个程序";

            Console.WriteLine("请输入您的姓名!");
            String name = Console.ReadLine();

            Console.WriteLine("您好" + name);
            Console.ReadLine();




            //float num01 = 3.0f;
            //float num02 = 2.9f;
            //float result = num01 - num02;
            //bool b1 = result == 0.1f;
            //Console.WriteLine(b1);

            decimal num01 = 0.1m;
            decimal num02 = 0.9m;
            decimal result = num01 - num02;
            bool b1 = result == 0.1m;
            Console.WriteLine(b1);

            Console.WriteLine("请输入枪的名称");
            String gunName = Console.ReadLine();
            Console.WriteLine("请输入弹匣容量!");
            string magazinesCarry = Console.ReadLine();
            Console.WriteLine("请输入当前弹匣内子弹数量!");
            string roundNumber = Console.ReadLine();
            Console.WriteLine("请输入剩余子弹数量!");
            string endnessNumber = Console.ReadLine();
            Console.WriteLine("枪的名称是：" + gunName + "，弹匣容量" + magazinesCarry + "，弹匣子弹数" + roundNumber + ",剩余子弹数" + endnessNumber);

            Console.ReadLine();
        }

        static void Main1()
        {
            Console.WriteLine("请输入第一个数字：");
            int numberOne = float.Parse(Console.WriteLine());

            Console.WriteLine("请输入第二个数字：");
            int numberTwo = float.Parse(Console.WriteLine());

            Console.WriteLine("请输入运算符：");
            string op = Console.ReadLine();
        }

        static void Main2()
        {
            Console.WriteLine("请输入您的成绩：");
            string strNumberOne = Console.ReadLine();
            float numberOne = float.Parse(strNumberOne);






























        }
}