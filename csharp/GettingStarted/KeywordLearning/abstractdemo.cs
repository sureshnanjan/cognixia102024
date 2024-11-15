namespace bhargav;
public abstract class abstractdemo
{
    public abstract int GetArea();
}

public class Square1 : abstractdemo
{
    protected int _side;

    public Square1(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;


}