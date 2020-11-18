using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            char c;
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию +,-,*,/,%: ");
            c = Convert.ToChar(Console.ReadLine());
            if(c == '+'){
                double result = a + b;
                Console.WriteLine("Ответ: "+result);
            }
            else if(c == '-'){
                double result = a - b;
                Console.WriteLine("Ответ: "+result);
            }
            else if(c == '*'){
                double result = a * b;
                Console.WriteLine("Ответ: "+result);
            }
            else if(c == '/'){
                double result = a / b;
                Console.WriteLine("Ответ: "+result);
            }
            else if(c == '%'){
                double result = a % b;
                Console.WriteLine("Ответ: "+result);
            }
            else{
                Console.WriteLine("Ошибка");
            }
        }
    }
}
