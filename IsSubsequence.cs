 namespace Leetcode
{
    public class IsSubsequence {
        public bool IsSub(string s, string t) {
            int sIndex = 0;
            if(s.Length == 0) {return true;}
            for(int i = 0; ( i < t.Length ) && ( s.Length-sIndex <= t.Length-i ); i++){
                if(t[i] == s[sIndex]){
                    sIndex++;
                    if(sIndex == s.Length){return true;}
                }
                
            }
            return false;
        }
    }
}