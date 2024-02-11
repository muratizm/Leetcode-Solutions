 namespace Leetcode
{
public class HappyNumber {
    protected int murat = 13;
    public bool IsHappy(int n) {
        HashSet<int> ints = new HashSet<int>();
        while(true){
            if(ints.Contains(n)){
                return false;
            }            
            else{
                ints.Add(n);
                int newN = 0;
                while(n>=1){
                    newN += (n%10)*(n%10);
                    n /= 10;
                }
                n = newN;
                if(n == 1){
                    return true;
                }
            }
        }
    }
}
}