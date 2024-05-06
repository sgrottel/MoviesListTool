namespace MoviesList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Model.ListFile list = Model.ListFile.Load(args[0]);
				list.Save(args[0]);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.WriteLine($"EXCEPTION: {ex}");
				Console.ResetColor();
			}
		}
	}
}
