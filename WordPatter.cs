 namespace Leetcode
{
    class WordPatter {
        public bool WordPattern(string pattern, string s) {
            Dictionary<char,string> keyValuePairs = new Dictionary<char, string>();
            string[] strs = s.Split(' ');
            if(pattern.Length != strs.Length){
                return false;
            }
            for (int i = 0; i < pattern.Length ; i++)
            {
                if(!keyValuePairs.ContainsKey(pattern[i])){
                    if(keyValuePairs.ContainsValue(strs[i])){
                        return false;
                    }
                    keyValuePairs.Add(pattern[i], strs[i]);
                }
                else{
                    if(keyValuePairs[pattern[i]] != strs[i]){
                        return false;
                    }
                }
            }


            return true;
        }
    }
}