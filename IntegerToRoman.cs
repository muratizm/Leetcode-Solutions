 namespace Leetcode
{
    public class IntegerToRoman {

        public string IntToRoman(int num) { // benim


            string output = "";
            int index = 0;

            List<string[]> arrays = new List<string[]>{
                new string[10]{"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
                new string[10]{"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
                new string[10]{"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
                new string[4]{"", "M", "MM", "MMM"},
            };

            while(num >= 1){
                int digit = num%10;
                output = arrays.ElementAt(index)[digit] + output;
                index++;
                num /= 10;
            }
            return output;
        }


        public string IntToRoman2(int num) { //benden daha zeki bir arkadaşın
            string[] thousands = new string[]{"","M","MM","MMM"};
            string[] hundreds = new string[]{"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
            string[] tens = new string[]{"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
            string[] ones = new string[]{"","I","II","III","IV","V","VI","VII","VIII","IX","X"};
            
            return thousands[num/1000]+hundreds[(num%1000)/100]+tens[(num%100)/10]+ones[num%10];
        }



        public string IntToRoman3(int num) { //bizden daha zeki bir arkadaşın
            var romanNumerals = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            var decimalValues = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var result = string.Empty;
            var currentValue = num;

            for (int i = 0; i < decimalValues.Length; i++)
            {
                while (currentValue >= decimalValues[i])
                {
                    currentValue -= decimalValues[i];
                    result += romanNumerals[i];
                }
            }

            return result;
        }

        public string IntToRoman4(int num) {
            int[] values = new int[]{1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] symbols = new[]{"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX","V", "IV","I"};
        
            string romanValue = "";
            for (int i = 0; i < 13 && num > 0;)
            {
                if (num >= values[i]) {
                    romanValue += symbols[i];
                    num -= values[i];
                }
                else {
                    i++;
                }
            }

            return romanValue;
        }



    }
}