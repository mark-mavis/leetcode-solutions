public partial class Medium{
    
    public class LongestSubstringWithoutRepeatingCharacters{
        //Tags: Hashtables, String, Sliding Window
        public static void Run(){
            BruteForce("abcabcbb");
            SlidingWindows("abcabcbb");
        }

        public static int BruteForce(string s){
            int n = s.Length;

            int res = 0;
            for(int i = 0; i < n; i++){
                for(int j = i; j < n; j++){
                    if(CheckRepetitionWithHashSet(s, i, j)){
                        res = Math.Max(res, j-i+1);
                    }
                }
            }
            return res;
        }
        private static bool CheckRepetitionWithHashSet(String s, int start, int end){

            HashSet<char> chars = new HashSet<char>();
            for(int i = start; i <= end; i++){
                char ch = s[i];
                if(chars.Contains(ch)){
                    return false;
                }
                chars.Add(ch);
            }
            return true;

        }
        private static bool CheckRepetitionWithIntArray(String s, int start, int end){
            int[] chars = new int[128];
            for(int i = start; i <= end; i++){
                char ch = s[i];
                if(chars[(int)ch] == ch){
                    return false;
                }
                chars[(int)ch] = ch;
            }
            return true;
        }
        public static int SlidingWindows(string s){
            int[] chars = new int[128];
            
            int left = 0;
            int right = 0;
            int n = s.Length;
            int res = 0;
            while(right < n){
                char r = s[right];
                
                int index = chars[(int)r];
                if(index != 0 && index >= left && index < right) left = index+1;

                res = Math.Max(res, right-left+1);
                chars[r] = right;
                right++;
            }
            return res;
        }
        
    }
}