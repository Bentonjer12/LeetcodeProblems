public class Solution {

        public int Reverse(int x)
{
	int result = 0;
	try
	{
		while (x != 0)
		{
			result = checked(result * 10 + x % 10);
			x /= 10;
		}
	}
	catch(OverflowException)
	{
		return 0;
	}
	return result;
}
    }
