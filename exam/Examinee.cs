
/**
 * 
 *Examinne.cs 
 * 
 * 
 */using System;
namespace _exam
{
	public class Examinee
	{
        public string Name { get; set; }
		public int Age { get; set; }
		public int Score { get; set; }
		public string Grade { get; set; }

		public void showinfo()
		{
			System.Console.WriteLine("---受験者情報---");
			System.Console.WriteLine("受験者名は" + Name + "です。");
			System.Console.WriteLine("年齢は"　+ Age + "です。");
			System.Console.WriteLine("筆記試験の結果は" + Score + "で、実技試験の結果は" + Grade + "になります。");
		}
 	}
}

