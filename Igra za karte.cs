using System;
					
public class Program
{
	public static void Main()
	{
		int karte, bodovi = 0;
		while(bodovi < 31)
		{
			Console.WriteLine("Upiši vrijednost karte od 1-13: ");
			try
			{
			karte= Convert.ToInt32(Console.ReadLine());
		
			if(karte > 13 || karte < 1)
			{
			Console.WriteLine("Pogrešan unos!");
			continue;
			}
			else
			{
				bodovi+=karte;
			}
			}
			
			catch (Exception ex){
				Console.WriteLine(ex.Message);
		}
		}
		if(bodovi == 31)
		{
			Console.WriteLine("Bodovi: " + bodovi);
			Console.WriteLine("Izgubili ste!");
		}
		else
		{
			Console.WriteLine("Bodovi: " + bodovi);
			Console.WriteLine("Pobjedili ste!");
	}
  }

}