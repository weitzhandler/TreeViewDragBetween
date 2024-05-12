namespace TreeViewDragBetween;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();


    }

    public Node Root =>
        new Node(1, [
            new Node(2, [
                new Node(3),
                new Node(4),
                new Node(5),
                new Node(6),
                ]),
            new Node(7, [
                new Node(8),
                new Node(9),
                new Node(10),
                new Node(11),
                ])
            ]);

}

public record Node(int Number, IList<Node> Children)
{
    public Node(int Number) : this(Number, [])
    {
    }
}
