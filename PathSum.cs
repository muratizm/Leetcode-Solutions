using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Leetcode
{


  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left =null, TreeNode right =null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null){
            return false;
        }

        if(root.left == null && root.right == null){
            if(root.val == targetSum){
                return true;
            }
            return false;
        }
        else{
            bool lbool = false;
            bool rbool = false;
            if(root.left != null){
                lbool = HasPathSum(root.left, targetSum - root.val);
            }
            if(root.right != null){
                rbool = HasPathSum(root.right, targetSum - root.val);
            }
            return lbool || rbool;
        }

    }

    public bool HasPathSum2(TreeNode root, int targetSum) {


        bool PathSum(TreeNode root, int currentSum){
            if(root == null){
                return false;
            }

            currentSum += root.val;
            if(root.left == null && root.right == null){
                return currentSum == targetSum;
            }
            else{
                return PathSum(root.left, currentSum) || PathSum(root.right, currentSum);
            }
        }
        
        return PathSum(root, 0);

    }

        public bool HasPathSum3(TreeNode root, int targetSum) {
            if(root==null) return false;
            return root.left==null && root.right==null ? root.val==targetSum
                :HasPathSum(root.left, targetSum-root.val)||HasPathSum(root.right, targetSum-root.val);
        }

}
}