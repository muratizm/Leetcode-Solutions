namespace Leetcode
{
    public class LongestSubstringWithoutRepeatingCharacters {
        public int LengthOfLongestSubstring(string s) {
            HashSet<int> hash = new HashSet<int>();
            int l = 0;
            int max = 0;

            for(int r = 0; r < s.Length; r++){                
                while(hash.Contains(s[r])){
                    l++;
                    hash.Remove(s[l]);
                }
                hash.Add(s[r]);
                r++;
                max = Math.Max(max, r-l+1);
            }
            return max;
        }
    }
}