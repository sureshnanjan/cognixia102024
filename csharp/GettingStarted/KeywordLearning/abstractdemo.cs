<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace bhargav;
=======
﻿namespace ganesh1;
>>>>>>> 3b5525c (week4)
=======
﻿namespace bhargav;
>>>>>>> e24dbe0 (week4)
=======
namespace bhargav;

>>>>>>> 3d526ed (latest commit)
=======
namespace bhargav;

=======
﻿namespace bhargav;
>>>>>>> e24dbe0 (week4)
>>>>>>> 45bcf59 (Assignment)
=======
﻿namespace ganesh1;
>>>>>>> 3bbef8c (resolve)
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
// Output: Area of the square = 144