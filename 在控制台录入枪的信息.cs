using System;

namespace Day02
{
    class 在控制台录入枪的信息
    {
        static void Main()
        {
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
    }
}
