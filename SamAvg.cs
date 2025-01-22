using System;
class SamAvg{
	static void Main(string[] args){
		string name = "Sam";
		int maths = 94;		//marks in mathematics
		int physics = 95;	//marks in physics
		int chem = 96;		//marks in chemistry
		int avg = (maths + physics + chem)/3;	//average calculation
		Console.WriteLine("{0}'s average marks in PCM is {1}",name,avg);		
	}
}