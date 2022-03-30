using System;
using System.Threading;

public class uno
{  
    /* so in main.cs the uno.cs will be imported with (uno uno = new uno();). Also uno.card(); will call this*/
    public void card()
    {
        Console.Write("What Card?");
        string card = Console.ReadLine();
        Console.WriteLine("Showed {0}", card);
    }
    public void start()
    {
       Console.WriteLine("UNO, START?");
       string key = Console.ReadKey();
       string key1 = "y";
       string key2 = "n";
       if(key == key1.ToUpper())
       {
           card();
       }
       else if(key == key1)
       {
           card();
       }
       else if(key == key2.ToUpper())
       {
           Console.WriteLine("u serious?");
           Thread.Sleep(500);
           card();
       }
       else if(key == key2)
       {
           Console.WriteLine("u s3r10us?");
           Thread.Sleep(500);
           card();
       }
       else
       {
           Console.WriteLine("WRONG!");
       }
           
}
