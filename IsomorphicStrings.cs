using System;

namespace Leetcode
{
    class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t) {
            Dictionary<char,char> values = new Dictionary<char, char>();
            if(s.Length != t.Length){
                return false;
            }
            for(int i = 0; i < s.Length; i++){

                if(values.ContainsKey(s[i])){
                    char value;
                    values.TryGetValue(s[i],  out value);
                    if(value != t[i]){
                        return false;

                    }
                }
                else if(values.ContainsValue(t[i])){
                    return false;
                }
                else{
                    values.Add(s[i], t[i]);
                }
            }
            return true;
        }

        //better
        public bool CanConstruct2(string ransomNote, string magazine) {
            var map = new int[26];

            for (int i = 0; i < magazine.Length; i++)
            {
                map[magazine[i] - 'a']++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (map[ransomNote[i] - 'a'] == 0)
                {
                    return false;
                }

                map[ransomNote[i] - 'a']--;
            }

            return true;
        }
    }


    
}
