using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_8
{
    class Calculator
    {
        int mode;
        int num1;
        int num2;
        char step;
        int num3;
        bool isOK;
        string str1;
        string str2;
        string str3;
        public void Func()
        {            
                Input();
                Calculate();
                Output();                    
        }
        void Input()
        {
            Reset();
            try
            {
                Console.WriteLine("输入第一个整数或字符串");
                str1 = Console.ReadLine();
                num1 = int.Parse(str1);
            }
            catch (Exception)
            {
                mode = 2;
            }
            try
            {
                Console.WriteLine("输入运算符");
                step = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("运算符只能输入+-*/");
            }
            try
            {
                Console.WriteLine("输入第二个整数或字符串");
                str2 = Console.ReadLine();
                num2 = int.Parse(str2);
            }
            catch (Exception)
            {
                mode = 2;
            }

        }
        void Calculate()
        {
            if (mode == 1)
            {
                switch (step)
                {
                    case '+':
                        num3 = Add(num1, num2);
                        break;
                    case '-':
                        num3 = Remove(num1, num2);
                        break;
                    case '*':
                        num3 = Multiply(num1, num2);
                        break;
                    case '/':
                        num3 = Division(num1, num2);
                        break;                    
                    default:
                        isOK = false;
                        Console.WriteLine("运算符错误");
                        break;
                }
               
            }
            else if (mode == 2)
            {
                switch (step)
                {
                    case '+':
                        str3 = Add(str1, str2);
                        break;
                    case '-':
                        str3 = Remove(str1, str2);
                        break;
                    default:
                        isOK = false;
                        Console.WriteLine("运算符错误");
                        break;
                }                
            }
        }
        void Output()
        {
            if (isOK)
            {
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("=" + num3);
                        break;
                    case 2:
                        Console.WriteLine("=" + str3);
                        break;
                }
            }
            else
                Console.WriteLine("无法得出结果");
        }
        void Reset()
        {
            mode = 1;
            isOK = true;
            step = '!';
            num3=num1=num2 = 0;
            str3 = str1 = str2 = "";
        }
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
        public string Remove(string str1, string str2)
        {
            int index=str1.IndexOf(str2);
            if (index == -1)
            {
                return str1;
            }
            else
            {
                return str1.Remove(index, str2.Length);
            }
        }
        public int Add(int x, int y)
        {
            return x+y;
        }
        public int Remove(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            if (y == 0)
            {
                isOK = false;
                return 0;
            }
            return x / y;
        }
    }
}
