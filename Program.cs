using Calculator;

Console.WriteLine("Введите первое число:");
double num1 = Convert.ToDouble(Console.ReadLine());

double num2 = 0;
string sign = "";
string input = "";
double tempRes = 0;

Operations sentence = new Operations();

while (true)
{
    Console.WriteLine("Введите знак операции ('+', '-', '*', '/') для продолжения вычислений или \'=\' для завершения вычислений и отображения результата.\nДля отображения истории текущего сеанса введите \'@\':");
    Console.WriteLine("Для выхода из программы введите \'#\'");
    input = Console.ReadLine();
    if (input == "=")
    {
        Console.WriteLine($"Результат: {num1}");
        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());
    }
    else if (input == "@")
    {
        Console.WriteLine(sentence.Cache);
        Console.WriteLine("Для очистки истории введите \'!\'.\nЧтобы вернуться к вычислениям, введите \'$\'");
        string inputHist = Console.ReadLine();
        if (inputHist == "!")
        {
            sentence.CleanCache();
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToDouble(Console.ReadLine());
        }
        else if(inputHist == "$")
        {
            continue;
        }
    }
    else if (input == "#")
    {
        break;
    }
    else
    {
        sign = input;

        Console.WriteLine("Введите следующее число:");

        num2 = Convert.ToDouble(Console.ReadLine());

        switch (sign)
        {
            case "+":
                tempRes = sentence.Add(num1, num2);
                break;
            case "-":
                tempRes = sentence.Subtract(num1, num2);
                break;
            case "*":
                tempRes = sentence.Multiply(num1, num2);
                break;
            case "/":
                tempRes = sentence.Divide(num1, num2);
                break;
        }
        sentence.Cache = $"{num1} {sign} {num2} = {tempRes}";
        num1 = tempRes;
    }
    //Console.ReadKey();
}


