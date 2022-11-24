/* TASK:You will explore what pops up after appending a dot to a numeric variable, and you will
learn how to convert from a number to text.
*/

// Some number
int number = 1234;

// Conversion to text
//nstring numberAsText = number; // Does not work
string numberAsText = number.ToString();

//Output
Console.WriteLine("Output of number - " +number);
Console.WriteLine("Output of text - " + numberAsText);

// Waiting for Enter
Console.ReadLine();


/* DISCUSSION:
 * 
 *  You can see that a value of type int cannot be directly assigned to a variable of type
    string. You have to convert it to text form first.
    Of course, in the output, you cannot see any difference
 *
    I will tell you the reasons why you cannot see any
    difference in the two displayed lines of Figure
 *
 *  The Console.WriteLine method converts everything it gets into text.
    It does this silently using the ToString conversion behind the scenes.

    • If you join some text with a number using the plus sign, the number
    gets automatically converted to text in C#. If you desire greater
    control, always write down .ToString() in connection with
    numbers.
*/