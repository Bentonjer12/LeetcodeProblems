public class Solution {
    public int ClimbStairs(int n) {
        
            int smallestAmountofStairs=n+1;//Since arrays are 0 based 0=1,1=1,2=2,3=3,4=(3+2=5)=>'start count'.   
            int[] Amount = new int[smallestAmountofStairs + 1];//testcase was 2 so 2+1+1=4 which is equal to start at 3
            Amount[0] = 0;//Array index foundation 
            Amount[1] = 1;//array[0,1,1,2,'start count']
            for (int StartCount = 2; StartCount <= smallestAmountofStairs; StartCount++)//Start after the third count
            {   //Fib equation
                Amount[StartCount] = Amount[StartCount - 2] + Amount[StartCount - 1];//recursion =)
            }
            return Amount[smallestAmountofStairs];//Returning the count at that current index 
        }