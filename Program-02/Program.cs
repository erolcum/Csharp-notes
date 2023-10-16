static void Main()
{
	double total = CheckOut(3.99, 5, 4.50, 7.25, 5.50, 6.45);
	total.Dump(); 
	//instead of Console.WriteLine(), Dump() is used in Linqpad
	//It is a very small and free program that you can try C# programs
}

static double CheckOut(params double[] prices)
{
	double total = 0;
	foreach (double price in prices)
	{
		total += price;
	}
	return total;
}