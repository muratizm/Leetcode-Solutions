using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Leetcode
{
    class UniquePaths {
        public int Paths(int m, int n) {
            var map = new int[m+n-2];
            double answer = 1;
            for(int i = 0; i < m+n-2 ; i++){
                map[i]++;
            }
            for(int i = 0; i < m-1; i++){
                map[i]--;
            }
            for(int i = 0; i < n-1; i++){
                map[i]--;
            }

            for(int i = 0; i < m+n-2; i++){
                answer *= Math.Pow((double)i+1, (double)map[i]);
            }
            return (int)Math.Round((double)answer);
        }

        public int Paths2(int m, int n) {
            long ans = 1;
            for (int i = 1; i <= m - 1; i++) {
                ans = ans * (n - 1 + i) / i;
            }
        return (int)ans;
    }

    }   
}
