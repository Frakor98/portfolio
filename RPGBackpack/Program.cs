namespace RPGBackpack;


public static class Program
{
    public static void Main()
    {
        IBackpack backpack= new RPGBackpack();
        Console.WriteLine(backpack.ToString()); 

        IItem sword = new Sword();
        Console.WriteLine(sword.ToString());

        backpack.Items.Add(sword);
    }
}