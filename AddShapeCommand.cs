
public class AddShapeCommand : Command
{
    Shape shape;
    Face face;
    public AddShapeCommand(Shape s, Face f)
    {
        shape = s;
        face = f;
    }

    public override void Do()
    {
        face.Add(shape);
    }
    public override void Undo()
    {
        face.Remove();
    }
}