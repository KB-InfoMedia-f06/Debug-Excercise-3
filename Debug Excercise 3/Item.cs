class Item {
    public string Name { get; set; }
    private int Quantity { get; set; }

    public Item(string name, int quantity) {
        Name = name;
        Quantity = quantity;
    }

}