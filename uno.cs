using System;

public class uno
{  
    /* so in main.cs the uno.cs will be imported with (uno uno = new uno();). Also uno.card(); will call this*/
    public void card()
    {
        Console.Write("What Card?");
        string card = Console.ReadLine();
        Console.WriteLine("Showed {0}", card);
    }
}
