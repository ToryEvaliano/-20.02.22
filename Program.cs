// // Программа, кот-ая из массива строк форм-т массив из строк, длина кот-х <= 3 символам

string [] arrayString = new string [5] {"Hello", "Hi", "Privet", "Chao", "Ola"};
    int stringsWithLess3Symbols= 0;
for (int count = 0; count < 5; count++)
{
    if (arrayString[count].Length <=3)
    {
        stringsWithLess3Symbols++;
    }
    Console.Write(arrayString[count]);
    Console.Write(" ");
}
Console.WriteLine(" ");
Console.WriteLine($"Words with less 3 numbers = {stringsWithLess3Symbols}");
Console.WriteLine(" ");

string [] newArrayString = new string [stringsWithLess3Symbols];
int i = 0;
for (int count = 0; count < 5; count++)
{
    if (arrayString[count].Length <=3)
    {
        newArrayString[i] = arrayString[count];
        i++;
    }
}

for (int count = 0; count < newArrayString.Length; count++)
{
    Console.Write(newArrayString[count]);
    Console.Write(" ");
}
Console.WriteLine(" ");

