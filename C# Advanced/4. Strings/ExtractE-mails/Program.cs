using System;

namespace ExtractE_mails
{
    class Program
    {
        static void Main()
        {
            string text = "pesho@abv.bg; на имейл адрес: pesho@abv.bg; затова ви оставям pesho@abv.bg.";
            while (text.Contains("@"))
            {//Ориентир ще ни бъде индекса на @
                int indexOfA = text.IndexOf("@");
                int firstIndex = text.LastIndexOf(" ", indexOfA) > 0 ? text.LastIndexOf(" ", indexOfA) : 0;//Намираме @ и вървим назад до " "
                int lastIndex = text.IndexOf(" ", indexOfA) < 0 ? text.Length  - 1: text.IndexOf(" ", indexOfA);//Намираме @ и вървим напред до " "
                string email = text.Substring(firstIndex, lastIndex - firstIndex);
                int firstLetter = 0;
                int lastLetter = email.Length - 1;
                while (!char.IsLetter(email[firstLetter]) || !char.IsLetter(email[lastLetter]))
                {//Докато поне едното не е буква
                    if (!char.IsLetter(email[firstLetter]))
                    {
                        firstLetter++;
                    }
                    if (!char.IsLetter(email[lastLetter]))
                    {
                        lastLetter--;
                    }
                }//Вече знаем че и двата индекса пазят буква
                email = email.Substring(firstLetter, lastLetter - firstLetter + 1);
                text = text.Remove(firstIndex, lastIndex - firstIndex + 1);
                Console.WriteLine(email);
            }
        }
    }
}
