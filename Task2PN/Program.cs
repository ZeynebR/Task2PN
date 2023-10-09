int[] Numbers = { -5,-4,-3,-2,-1,0, 1, 2, 3, 4, 5};
int PositiveCount = 0;
int NegativeCount = 0;

for (int i = 0; i < Numbers.Length; i++)
{
	if (Numbers[i]>0)
	{
		PositiveCount++;
	}
	if (Numbers[i]<0) 
	{ 
		NegativeCount++; 
	}
	//if (numbers[i]== 0)
	//{
      //  console.writeline(	"0 is neither positive nor negative");
    //}
}
Console.WriteLine( PositiveCount + " positive numbers");
Console.WriteLine(NegativeCount + " negative numbers");

