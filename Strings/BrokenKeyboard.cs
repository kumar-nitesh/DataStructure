/********************************************************************************************
* You have a passage of text that needs to be retyped. But, some of the letter keys on your 
* keyboard are broken! Given an array letters  representing the working letter keys and a 
* stringtext, your task is to determine how many words from text can be typed in full using 
* the broken keyboard. It is guaranteed that all non-letter keys are working.
*  
* For text = "Hello, this is CodeSignal!" and letters = ['e', 'i', 'h', 'l', 'o', 's'], 
* the output should be solution(text, letters) = 2.
*   i.	"Hello," can be typed since the characters 'h', 'e', 'l' and 'o' are all in letters. 
*        Note that the symbol ',' also belongs to the current word and can be typed.
*   ii.	"this" cannot be typed because the character 't' is not in letters.
*   iii."is" can be typed (both 'i' and 's' appear in letters).
*   iv.	"CodeSignal!" cannot be typed because the character 'c' is not in letters 
*        (nor are 'd', 'g', 'n', and 'a').
*  
* Company : Agoda
********************************************************************************************/

namespace Strings
{
    public class BrokenKeyboard : IExecute
    {
        public int NoOfWords(string text, char[] letters)
        {
            string[] words = text.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                bool canType = true;

                foreach (char ch in word)
                {
                    if (char.IsLetter(ch) && Array.IndexOf(letters, char.ToLower(ch)) == -1)
                    {
                        canType = false;
                        break;
                    }
                }

                if (canType)
                    count++;
            }

            return count;
        }

        public void Execute()
        {
            Console.WriteLine("#################Agoda#####################");
            Console.WriteLine("Broken Keyboard");

            string text = "Hello, this is CodeSignal!";
            char[] letters = new char[] { 'e', 'i', 'h', 'l', 'o', 's' };

            Console.WriteLine(NoOfWords(text, letters));
        }
    }
}
