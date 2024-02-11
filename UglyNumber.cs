 namespace Leetcode
{
    public class UglyNumber {
        public bool IsUgly(int n) {
            if(n == 0){
                return true;
            }

            while(n % 2 == 0){
                n /= 2;
            }

            while(n % 3 == 0){
                n /= 3;
            }

            while(n % 5 == 0){
                n /= 5;
            }

            return n == 1;
        }
    }
}