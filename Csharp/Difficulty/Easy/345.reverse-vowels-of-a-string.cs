/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */

// @lc code=start
public partial class Easy {
    public class ReverseVowelsOfAString{
        public static void Run(){
            Console.WriteLine(ReverseVowels("hello"));
            Console.WriteLine(ReverseVowels("aA"));
        }
        public static string ReverseVowels(string s) {
            char[] characterString = s.ToArray();
            int left = 0;
            int right = characterString.Length-1;
            HashSet<char> vowels = new HashSet<char>(){'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};

            while(left < right){
                if(vowels.Contains(characterString[left])){
                    while(!vowels.Contains(characterString[right])){
                        right--;
                    }
                    char temp = characterString[left];
                    characterString[left] = characterString[right];
                    characterString[right] = temp;
                    right--;
                }
                left++;
            }
            return String.Join("", characterString) ?? s;
        }
    }
    
}
// @lc code=end

