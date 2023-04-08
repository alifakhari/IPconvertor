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
             
            // fl = File.ReadAllLines(file2Convert).ToList();
            fls = File.ReadAllLines(file2Convert);
            Console.WriteLine("IPL just read scsfully");

            // hostname = File.ReadAllLines(file0IPlist).ToList();
            hostnames = File.ReadAllLines(file0IPlist);
            Console.WriteLine("hostnames just read scsfully");


            // for (int i=0;i<fl.Count;i++) 
            for (int i=0;i<fls.Length;i++) 
            {
                string str = fls[i];
                
                bool found = false;
                for(int j=0;j<hostnames.Length;j++)
                {
                    // int x = hostnames[j].IndexOf(fls[i]);
                    // if (x==-1)
                    //     continue;
                    string[] comparestr = hostnames[j].Split(',');
                    if(comparestr[0] != fls[i])
                        continue;
                    else {
                        str = hostnames[j]; found = true; break;}
                }   


                if(found)
                    fls[i] = str;
                else
                    fls[i]+=", N/A";
                    
                Console.WriteLine(str);
            }

            try{
                File.WriteAllLines("final.csv",fls);
                Console.WriteLine("file written done");
            }
            catch(Exception e)
            {Console.WriteLine(e.Message);}
        }
    }
}