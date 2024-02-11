 namespace Leetcode
{
    public class MergeIntervals {
        public int[][] Merge(int[][] intervals) {

            List<int[]> output = new List<int[]>();

            Array.Sort(intervals, (a,b)=>{return a[0]-b[0];});

            output.Add(intervals[0]);

            for(int i = 1; i < intervals.Length; i++)
            {
                if(output[output.Count - 1][1] >= intervals[i][0])
                {
                    if(output[output.Count - 1][1] <= intervals[i][1]) 
                        output[output.Count - 1][1] = intervals[i][1];
                }
                else output.Add(intervals[i]);
            }

            return output.ToArray();
        }
    }
}