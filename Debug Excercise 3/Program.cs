//Inventory System

class Program {
    public static void Main(string[] args) {
        inventory = new Inventory();

        inventory.AddItem(new Item("Vial of Water", 2));
        inventory.AddItem(new Item("Guam Herb", 2));
        inventory.AddItem(new Item("Eye of Newt", 2));
        inventory.AddItem(new Item("Guam Herb", 2));

        inventory.DisplayItems();
    }
}