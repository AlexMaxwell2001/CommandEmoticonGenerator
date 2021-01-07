public class RightEyeDecorator : ShapeDecorator
{
    private string Style="fill.black";
    public RightEyeDecorator(Shape shape) : base(shape)
    {
    }
    public override string MakeString()
    {
        string [] ar = shape.MakeString().Split("(");
        string shapeorig= ar[0];
        return shapeorig +RightEye();
    }
    private string RightEye()
    {
        return "(class: " + "right-eye" +", cx: " + 156 + ", cy: " + 104 + ", r: " + 12+ ", style: " + Style +")";
    }
    public override void setStyle(string style){
        this.Style=style;
    }
}