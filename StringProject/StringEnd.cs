using System;

namespace StringProject
{
    public class StringEnd
    {        
        public bool StrEnd(string firstStr, string secondStr)
        {
            firstStr = StrReplace(firstStr);
            secondStr = StrReplace(secondStr);
            
            int difference = firstStr.Length - secondStr.Length - 1;
            int indexOfSubstring = firstStr.LastIndexOf(secondStr);
            if (indexOfSubstring > difference)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public string StrReplace(string str)
        {
            str = str.Trim();
            str = str.Replace(" ", "");
            str = str.Replace("\t", "");
            str = str.Replace("\n", "");
            return str;
        }


    }
}
