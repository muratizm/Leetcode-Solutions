 namespace Leetcode
{
    public class PowerOfTwo {
        public bool IsPowerOfTwo(int n) {
            return Math.Log2(n) % 1 == 0;    
            //if log2(n) returns an integer, this number is a power of 2, such as 8 16 32
             //but if it returns a decimal number, it is not a power of 2, it could be 48 or 6 for example
             //I used the %1 == 0 technique to detect this
        }
    }
}