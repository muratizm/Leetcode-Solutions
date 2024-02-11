using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Leetcode
{


    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 


    class MergeLinkedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

            ListNode sorted = new ListNode();
            ListNode first = sorted;

            while(list1 != null && list2 != null){
                if(list1.val < list2.val){
                    sorted.next = list1;
                    list1 = list1.next;
                    sorted = sorted.next;
                }
                else{
                    sorted.next = list2;
                    list2 = list2.next;
                    sorted = sorted.next;
                }
            }

            if(list1 != null){
                sorted.next = list1;
            }
            if(list2 != null){
                sorted.next = list2;
            }

            return first.next;
        }

        public ListNode MergeTwoListsRecursive(ListNode list1, ListNode list2) {

            
            if(list1 == null){
                return list2;
            }
            if(list2 == null){
                return list1;
            }


            if(list1.val < list2.val){
                list1.next =  MergeTwoListsRecursive(list1.next, list2);
                return list1;
            }
            else{
                list2.next =  MergeTwoListsRecursive(list1, list2.next);
                return list2;
            }
        
        }
    }
}
