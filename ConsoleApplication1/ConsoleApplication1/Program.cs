using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            Console.WriteLine("Downloading file....");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://dl.google.com/googletalk/googletalk-setup.exe", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            double megabits = fileInfo.Length * 8 * 0.000001;
            double speed = megabits / (sw.Elapsed.TotalMilliseconds / 1000);

            Console.WriteLine("Download duration: {0}", sw.Elapsed);
            Console.WriteLine("File size: {0}", fileInfo.Length.ToString("N0"));
            Console.WriteLine("Speed: {0} bps ", speed );

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            test();
        }
        public static void test() {
            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

            Console.WriteLine("Downloading file....");

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://dl.google.com/googletalk/googletalk-setup.exe", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            double megabits = fileInfo.Length * 8 * 0.000001;
            double speed = megabits / (sw.Elapsed.TotalMilliseconds / 1000);

            Console.WriteLine("Download duration: {0}", sw.Elapsed);
            Console.WriteLine("File size: {0}", fileInfo.Length.ToString("N0"));
            Console.WriteLine("Speed: {0} bps ", speed);

            Console.WriteLine("Press any key to continue...");
            test();
        }
    }
}
