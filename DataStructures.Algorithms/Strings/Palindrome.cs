/********************************************************************************************
* Given a string, find the shortest possible string which can be achieved by adding characters
* to the end of initial string to make it a palindrome. 
* 
* For Example, input = "abcdc", the output should be = "abcdcba".
*  
* Company : Agoda
********************************************************************************************/

namespace DataStructures.Algorithms.Strings
{
    public class Palindrome : IExecute
    {
        string AddAuxiliaryCharacters(string inputString)
        {
            int i = 0;
            string aux;

            while (inputString != new string(inputString.ToCharArray().Reverse().ToArray()))
            {
                aux = inputString;
                aux = aux.Insert(inputString.Length - i, inputString[i].ToString());
                inputString = aux;
                i++;
            }

            return inputString;
        }

        public void Execute()
        {
            Console.WriteLine("#################Agoda#####################");
            Console.WriteLine("Add Auxiliary characters to make string a Palindrome");
            string inputString = "abbaca";
            Console.WriteLine(AddAuxiliaryCharacters(inputString));
        }
    }
}
