//LSP

//Bad
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
}

public class Square:Rectangle
{
    //codes specific to
    //square will be added
}

//Example
Rectangle o = new Rectangle();
o.Width = 5;
o.Height = 6;

Rectangle o = new Square();
o.Width = 5;
o.Height = 6;

// New 

public class Square : Rectangle
{
    public override int Width
    {
        get{return base.Width;}
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    public override int Height
    {
        get{return base.Height;}
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}


public abstract class Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
}


//Example
Shape o = new Rectangle();
o.Width = 5;
o.Height = 6;

Shape o = new Square();
o.Width = 5; //both height and width become 5
o.Height = 6; //both height and width become 6