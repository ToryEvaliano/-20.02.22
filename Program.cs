// // Программа, кот-ая из массива строк форм-т массив из строк, длина кот-х <= 3 символам

string [] arrayString = new string [5] {"Hello", "Hi", "Privet", "Chao", "Ola"};
for (int count = 0; count < 5; count++)
{
    Console.Write(arrayString[count]);
    Console.Write(" ");
}
Console.WriteLine(" ");

for (int count = 0; count < 5; count++)
{
    if (arrayString[count].Length <= 3)
        {
            Console.Write(arrayString[count]);
            Console.Write(" ");
        }
}
Console.WriteLine(" ");