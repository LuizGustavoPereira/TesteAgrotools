using System;
					
public class ProblemVagaDev
{
	public static void Main()
	{
		int arrayLength = Convert.ToInt32(Console.ReadLine());
		int[] arrayNum = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		
		sumArray(arrayNum, arrayLength);
	}
	
	public static void sumArray(int[] arrayNum, int arrayLength){
		int sum = 0;
		
		for(int i = 0; i < arrayLength; i++){
			sum += Convert.ToInt32(arrayNum[i]);
		}
		
		Console.WriteLine("{0}", sum);
	}
}