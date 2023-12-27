char[] array = new char[20]; 
Console.WriteLine("Введите 20 символов (строчные буквы и пробелы):");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadKey().KeyChar; 
}

string word = FindWord(array); 

Console.WriteLine("\nСлово, начинающееся и заканчивающееся на одну и ту же букву: " + word);
Console.ReadLine();


static string FindWord(char[] array)
{
    string word = ""; 

    for (int i = 0; i < array.Length; i++)
    {
        if (char.IsLetter(array[i])) 
        {
            int j = i + 1;
            while (j < array.Length && (char.IsLetter(array[j]) || array[j] == ' ')) 
            {
                j++;
            }

            if (j - i >= 2 && char.ToLower(array[i]) == char.ToLower(array[j - 1])) 
            {
                word = new string(array, i, j - i); 
                break;
            }

            i = j; 
        }
    }

    return word;
}
