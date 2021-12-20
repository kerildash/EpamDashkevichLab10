using System;

namespace EpamDashkevichLab10
{
    class Program
    {
        //пример строки для теста
        //Обращайте внимание на денежные купюры, получаемые из рук незнакомцев. Надпись «КУПЮРА БАНКА ПРИКОЛОВ» означает, что она СУВЕНИРНАЯ.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();
            Console.WriteLine(MoveVowelsToTheStart(text));
        }

        static string MoveVowelsToTheStart(string text)
        {
            string[] words = text.Split(' ');
            string fixedText = "";
            foreach (string word in words)
            {
                fixedText += FixWord(word) + " ";
            }
            fixedText.Trim();
            return fixedText;
        }

        private static string FixWord(string word)
        {
            string vowels = "";
            string other = "";
            for (int i = 0; i < word.Length; i++)
            {
                bool isVowel = false;
                isVowel = IsVowel(word[i]);
                if (isVowel)
                {
                    vowels += word[i];
                }
                else
                {
                    other += word[i];
                }
            }
            string fixedWord = vowels + other;
            return fixedWord;
        }

        private static bool IsVowel(char letter)
        {
            foreach (char vowel in wovels)
            {
                if (letter == vowel)
                {
                    return true;
                }
            }
            return false;
        }


        //неоднозначное решение, но
        //добавил открывающие кавычки и скобки,
        //чтобы оставить их в начале слова
        static char[] wovels =
        {
            'а',
            'о',
            'у',
            'э',
            'ы',
            'я',
            'ё',
            'ю',
            'е',
            'и',
            'А',
            'О',
            'У',
            'Э',
            'Ы',
            'Я',
            'Ё',
            'Ю',
            'Е',
            'И',
            'a',
            'e',
            'i',
            'o',
            'u',
            'A',
            'E',
            'I',
            'O',
            'U',
            '"',
            '\'',
            '«',
            '<',
            '('
        };
    }
}
