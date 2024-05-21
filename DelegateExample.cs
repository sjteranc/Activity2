using System;

namespace Activity2
{
    public class DelegateExample{
            
    //define an delegate
    public delegate int MathOperation (int a, int b);

    public int Add(int a, int b) {
        return a + b;
    }
    public int Subtract(int a, int b) {
        return a - b;
    }
    
    }

}