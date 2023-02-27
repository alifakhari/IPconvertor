using System.IO;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string file2Convert="D:\\project\\c#\\IPconvertor\\bin\\Debug\\net7.0\\fl.csv";
            string file0IPlist= "D:\\project\\c#\\IPconvertor\\bin\\Debug\\net7.0\\ipl.csv";

            List<string> fl = new List<string>(); 
            List<string> hostname = new List<string>(); 
            string[] fls; 
            string[] hostnames;
             
            fl = File.ReadAllLines(file2Convert).ToList();
            Console.WriteLine("IPL just read scsfully");

            hostname = File.ReadAllLines(file0IPlist).ToList();
            Console.WriteLine("hostnames just read scsfully");


            for (int i=0;i<fl.Count;i++) 
            {
                string str = fl[i];
                for(int j=0;j<hostname.Count;j++)
                {
                    int x = hostname[j].IndexOf(fl[i]);
                    if (x==-1){str += ", Not found";  continue;}
                    else {str = hostname[j];  Console.WriteLine(str); continue;}
                }   
            }
        }
    }
}