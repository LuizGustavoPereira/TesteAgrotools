using System;
using System.Collections.Generic;
					
public class ProblemVagaDev2
{
	public static void Main()
	{				
		long[] arrayNum = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
		Array.Sort(arrayNum);				
		long sumMax = sumExclude(arrayNum, 0);
		long sumMin = sumExclude(arrayNum, arrayNum.Length-1);
		Console.WriteLine("{0} {1}", sumMin, sumMax);
		
	}
	
	public static long sumExclude(long[] arrayNum, int index){
		long sum = 0;
		List<long> listNum = new List<long>(arrayNum);	
		listNum.RemoveAt(index);
		
		foreach(long num in listNum){
			sum += num;
		}
		
		return sum;
	}
}