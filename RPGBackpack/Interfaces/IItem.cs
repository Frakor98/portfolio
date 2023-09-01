namespace RPGBackpack;


public interface IItem
{
    int ItemId { get; }

    string Name { get; set; }
    string Description { get; set; }
}
