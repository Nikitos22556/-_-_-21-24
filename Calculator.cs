using System;
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Обычный калькулятор на C# для обучения");
            Console.Write("Введите первое число: ");
            string num1 = Console.ReadLine();
            double num1_double = Convert.ToDouble(num1);
            Console.Write("Введите второе число: ");
            string num2 = Console.ReadLine();
            double num2_double = Convert.ToDouble(num2);
            double temp1 = num1_double;
            double temp2 = num2_double;
            bool tempbool1 = Convert.ToBoolean(num1_double);
            bool tempbool2 = Convert.ToBoolean(num2_double);
            int tempint1 = Convert.ToInt32(num1);
            int tempint2 = Convert.ToInt32(num2);
            int sdvig = tempint1 << tempint2;
            int sdvigpr = tempint1 >> tempint2;
            Console.WriteLine($"Сложение: {num1_double} + {num2_double} = {num1_double + num2_double}");
            Console.WriteLine($"Вычитание: {num1_double} - {num2_double} = {num1_double - num2_double}");
            Console.WriteLine($"Умножение: {num1_double} * {num2_double} = {num1_double * num2_double}");
            Console.WriteLine($"Деление: {num1_double} / {num2_double} = {num1_double / num2_double}");
            Console.WriteLine($"Остаток от деления: {num1_double} % {num2_double} = {num1_double % num2_double}");
            Console.WriteLine($"Инкремент первого числа: {temp1}++ = {++temp1}");
            temp1 = num1_double;
            Console.WriteLine($"Декремент первого числа: {temp1}-- = {--temp1}");
            Console.WriteLine($"Инкремент второго числа: {temp2}++ = {++temp2}");
            temp2 = num2_double;
            Console.WriteLine($"Декремент второго числа: {temp2}-- = {--temp2}");
            Console.WriteLine("КОНЕЦ ОСНОВНЫХ ОПЕРАЦИЙ!!! НАЧАЛО ЛОГИЧЕСКИХ!!!");
            Console.WriteLine($"Логическое умножение (&): {tempint1} & {tempint2} = {tempint1 & tempint2}");
            Console.WriteLine($"Логическое сложение: {tempint1} | {tempint2} = {tempint1 | tempint2}");
            Console.WriteLine($"Логическое исключающее ИЛИ: {tempint1} ^ {tempint2} = {tempint1 ^ tempint2}");
            Console.WriteLine($"Поразрядная исключающее ИЛИ: {tempint1} ^ {tempint2} = {tempint1 ^ tempint2}");
            Console.WriteLine($"Сдвиг влево: {num1} << {num2} = {sdvig}");
            Console.WriteLine($"Сдвиг вправо: {num1} >> {num2} = {sdvigpr}");
            Console.WriteLine($"Логическая инверсия: !({tempbool1} == {tempbool2}) = !{tempbool1 == tempbool2}");

        }
    }