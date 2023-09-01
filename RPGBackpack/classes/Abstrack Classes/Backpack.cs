
namespace RPGBackpack;

public abstract class Backpack : IBackpack
{
    public List<IItem> Items => _items;
    private List<IItem> _items;


    public Backpack() => _items = new List<IItem>();
    

    public IItem GetItem(int index)
    {
        var returnItem = Items.FirstOrDefault(x => x.ItemId == index) ??
            throw new Exception("Item with that ID doesn't exists");


        return returnItem; 
    }
}
