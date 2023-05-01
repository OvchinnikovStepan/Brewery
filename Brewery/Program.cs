namespace Brewery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input2.txt");
            string text=reader.ReadToEnd();
            reader.Close();
            string[] lines=text.Split(new char[] { '\n' });
            string[] spells=new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string action = lines[i].Split(" ")[0]; //Console.WriteLine(action);
                string stuff0 = lines[i].Split(" ", 2)[1]; //Console.WriteLine(stuff0);
                string[]  stuff = stuff0.Split(new char[] { '\n','\r',' ' });
                
               // Console.WriteLine(stuff[0]); Console.WriteLine(stuff[1]);
                string prespell="";
                for (int t=0;t<stuff.Length;t++)
                {
                    try
                    {
                        prespell += spells[Convert.ToInt32(stuff[t])-1];
                    }
                    catch 
                    {
                        //Console.WriteLine(prespell); Console.WriteLine(stuff[t]);
                        //Console.WriteLine(prespell+stuff[t]);
                        prespell = string.Concat(prespell,stuff[t]);
                        
                    }
                }
            //    Console.WriteLine(prespell);
                if (action == "DUST") { prespell = "DT" + prespell + "TD"; }
                else if (action == "DUST") { prespell = "DT" + prespell + "TD"; }
                else if (action == "FIRE") { prespell = "FR" + prespell + "RF"; }
                else if (action == "WATER") { prespell = "WT" + prespell + "TW"; }
                else if (action == "MIX") { prespell = "MX" + prespell + "XM"; }
                spells[i] = prespell;
            //    Console.WriteLine(spells[i]);
            }
           
            Console.WriteLine(spells[spells.Length-1]);
            
         //   Console.WriteLine(spells[spells.Length-1]);
        }
    }
}