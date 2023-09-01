namespace RPGBackpack;


public interface IBackpack
{
    List<IItem> Items { get; }


    public IItem GetItem(int index);
}
