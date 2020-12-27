public class Solution {
    public int MaxNumberOfBalloons(string text) {
        
 int b = 1;

 int a = 1;

 int l = 2;

 int o = 2;

 int n = 1;



int b1 = 0;

 int a1 = 0;

 int l1 = 0;

 int o1 = 0;

 int n1 = 0;



// Insert code that breaks string into individual characters



char[] balloonArray = text.ToCharArray();



foreach (char item in balloonArray)

 {

 if (item == 'b')

 {

 b1++;

 }

 if (item == 'a')

 {

 a1++;

 }

 if (item == 'l')

 {

 l1++;

 }

 if (item == 'o')

 {

 o1++;

 }

 if (item == 'n')

 {

 n1++;

 }

 }



int b2 = b1 / b;

 int a2 = a1 / a;

 int l2 = l1 / l;

 int o2 = o1 / o;

 int n2 = n1 / n;



// Insert code that determines the smallest of b2, a2, l2, o2, and n2, and returns the smallest value as an int.



Console.WriteLine(b2); //2 b's

 Console.WriteLine(a2);

 Console.WriteLine(l2); //7 l's

 Console.WriteLine(o2); //9 o'x

 Console.WriteLine(n2);



int x = Math.Min(b2, a2);

 int y = Math.Min(l2, o2);

 int z = Math.Min(x, y);

 int w = Math.Min(z, n2);

        return w;
    }
}