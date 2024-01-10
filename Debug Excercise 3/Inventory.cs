
class Inventory {
    public List<Item> Items { get; }

    public Inventory() {
        Items = new List<Item>();
    }

    public void AddItem(Item item) {
        //check if item already exists
        //if yes add them to entry 
        for (int i = 0; i < Items.Count; i++) {
            if(Items[i].Name == item.Name) {
                Items[i].Quantity = item.Quantity;
                break;
            }
        }
        //else create new entry
        Items.Add(item);
    }

    //display all items
    public void DisplayItems() {
        for (int i = 0; i <= Items.Count; i++) {
            Console.WriteLine($"{i + 1}. {Items[i]}");
        }
    }
}


