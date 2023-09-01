namespace RPGBackpack;

public class RPGBackpack : Backpack
{
    string Name {get => _name;}
    string Description {get => _description;}
    private readonly string _name = "My favourite Backpack";
    private readonly string _description = "This is my favourite Backpack";


    public override string ToString() => $"{Name} {Description}";
}
