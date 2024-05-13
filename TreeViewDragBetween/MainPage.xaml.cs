namespace TreeViewDragBetween;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();        
    }

    public IList<Node> Items => [
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
            ]),
        new Node(12, [
            new Node(13, [
                new Node(14),
                new Node(15),
                new Node(16),
                ]),
            new Node(17, [
                new Node(18),
                new Node(19),
                new Node(20),
                new Node(21),
                ])
            ])

        ];

    private void TreeView_DragOver(object sender, DragEventArgs e)
    {
    }
}

public class Node(int number, IList<Node> children)
{
    private Node() : this(default)
    {            
    }

    public Node(int number) : this(number, [])
    {            
    }

    public int Number => number;
    public IList<Node> Children => children;
}
