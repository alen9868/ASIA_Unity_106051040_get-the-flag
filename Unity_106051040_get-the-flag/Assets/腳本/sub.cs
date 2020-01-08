using UnityEngine;

public class sub : MonoBehaviour
{
    public int A = 20, B = 2,C=8,D=10;
    public float HP = 100;
    public bool key=false;
    public int enemy;
    public int atk = 10;

    private void Start()
    {
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        C = 100 * 5;
        print("C的運算值(++擺前面)" + ++C);

        print("C的運算值(++擺後面)" + C++);

        print(B > D);
        print(B < D);
        print(B >= D);
        print(B <= D);
        print(B==D);
        print(B != D);

        print("下面是一錯全錯");
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print("下面是一對全對");
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);
    }
    public int combo = 0;
    private void Update()
    {
        print("死" + (HP <= 0));
        print("過關判定" + key);

        if (combo >= 50)
        {
            atk *= 2;
            print("atk2倍中!!!!");
        }
        if (combo >= 100)
        {
            atk *= 4;
            print("atk4倍中!!!!!!"); }
    }
   
}
