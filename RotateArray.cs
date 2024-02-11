 namespace Leetcode
{
    class RotateArray {
        public void Rotate(int[] nums, int k) {
            int[] newArr = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++){
                newArr[i+k % nums.Length] = nums[i]; 
            }
            nums = newArr;
        }
    }
}