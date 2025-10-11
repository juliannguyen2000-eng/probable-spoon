using System;

public class Panda
{
    // defining properties, set when the panda is created.
    public string Name { get; }
    public Panda Mate { get; private set; }

    // this is the constructor, which means that it creates a panda and sets its name.
    public Panda(string name)
    {
        Name = name;
    }

    // declares that the two pandas are partners.
    public void Marry(Panda partner)
    {
        Mate = partner;
        partner.Mate = this;
    }
}

class Program
{
    static void Main() // this part is used to assign the panda variables with names, used later for what is printed in the output.
    {
        Panda hon = new Panda("Hong"); // we assign the variable hon with "Hong"
        Panda xi = new Panda("Xi"); // same as previous line

        hon.Marry(xi); // this declares that they are mates.

        Console.WriteLine($"{hon.Name}'s mate is {hon.Mate.Name}"); // these two codes print their names, the output of the file.
        Console.WriteLine($"{xi.Name}'s mate is {xi.Mate.Name}");
    }
}
