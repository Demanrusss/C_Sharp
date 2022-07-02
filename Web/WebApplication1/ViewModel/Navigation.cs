namespace WebApplication1.ViewModel
{
	public class Navigation
	{
		public int FoundItems { get; set; }
		public int CurrentPage { get; set; }
		public string PageName { get; set; }
		public int Pages { get { return FoundItems / 10; } }
	}
}
