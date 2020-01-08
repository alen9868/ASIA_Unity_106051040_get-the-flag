using UnityEngine;

public class sfuk: MonoBehaviour
{
    public int A = 20, B = 2,C=8;
    private void Start()
    {
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        C = 100 * 5;
        print("C的運算值" + C);

        print(A++);
        print(++A);
    }
}
