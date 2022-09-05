// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78->8
// 12->2
// 85->8

int number = new Random().Next(10, 100);
// int firstDigit = number / 10;  //7
// int secondDigit = number % 10; //8 (остаток от деления на 10)

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

// if (firstDigit == secondDigit) Console.WriteLine($"Цифры равны"); //Если цифры в числе равны, то выводим на экран "Цифры равны"
// else                                                              //Иначе...  
// {
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
// }

int MaxDigit(int num)                    //метод. Получил на вход число которое передали мы ему num
{
   int firstDigit = num / 10;           //тело метода
   int secondDigit = num % 10; 
   return firstDigit > secondDigit ? firstDigit : secondDigit; //возвращаем переменную 
}

int maxDigit = MaxDigit(number);                           //созд. переменную maxDigit, вызвали наш метод
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны"; // выводим на экран проверку при равных цифрах в числе
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");