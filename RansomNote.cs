using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Leetcode
{
    public class RansomNote {
        public bool CanConstruct(string ransomNote, string magazine) {
            if(magazine.Length < ransomNote.Length){
                return false;
            }

            Dictionary<char,int> dict = new Dictionary<char, int>();
            for(int i = 0; i< magazine.Length;i++){
                if(dict.ContainsKey(magazine[i])){
                    dict[magazine[i]] += 1;
                }
                else{
                    dict.Add(magazine[i], 1);
                }
            }

            for(int i = 0; i< ransomNote.Length;i++){
                int x;
                if(dict.TryGetValue(ransomNote[i], out x)){
                    if(x <= 0){
                        return false;
                    }
                    dict[ransomNote[i]] = x - 1; 
                }
                else{
                    return false;
                }
            }

            return true;
            
        }
    }   
}