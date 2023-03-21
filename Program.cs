using System.Diagnostics;

namespace BatchFileTest{
    public class Program{
        public static void Main(){
            string batFileDir = String.Format(@"C:\C# Projects\ASP.NET-MVC\WebArchiver\ExternalPrograms\ArchiverMVC.bat");
			Process.Start(batFileDir);
        }
    }
}