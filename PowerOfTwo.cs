 namespace Leetcode
{
    public class PowerOfTwo {
        public bool IsPowerOfTwo(int n) {
            return Math.Log2(n) % 1 == 0;    
            //eğer log2(n) tam sayı döndürüyorsa bu sayı 2nin kuvvetidir mesela 8 16 32 gibi
            //ama ondalıklı sayı döndürüyorsa 2nin kuvveti değildir 48 veya 6 olabilir mesela
            //bunu detect etmek için ise %1 == 0 tekniğini kullandım
        }
    }
}