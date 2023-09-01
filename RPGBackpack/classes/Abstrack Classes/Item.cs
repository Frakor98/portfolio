namespace RPGBackpack;


public abstract class Item : IItem
{
    public int ItemId => _itemId;
    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    private int _itemId;
    private string _name = string.Empty;
    private string _description = string.Empty;


    protected void SetItemIp(int index) => _itemId = index; 
    public override string ToString() => $"{ItemId} {Name} {Description}";
}
