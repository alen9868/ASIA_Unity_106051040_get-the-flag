 
using UnityEngine;

public class car : MonoBehaviour
{
    [Header("CC數"), Range(100, 1000)]
    public int CC = 8000;
    [Header("汽車重量"), Range(6, 25), Tooltip("單位:公噸")]
    public float 重量 = 5.87f;
    [Header("品牌")]
    public string 品牌 = "SKT";
    [Header("煞車與否")]
    public bool break01 = false;
    // I fucked up.
    private void Start()
    {
        print("開剁AAAAAAAAAAAAAAAAAAAAA");
        print(CC);
        print(重量);
        重量 = 200;
        
    }
    private void Update()
    {
        drive(100,"左",sound:"BBBBBBB");
       
        print("目前稅金:" + tax());
    }
    public void drive(int speed ,string direction,string sound="AAAAAAAAAA")
    {
        print("目前時速"+speed+"公里/小時");
        print("目前方向:" + direction);
        print(sound);
    }
    public int tax()
    {
        return CC * 100;
    
    }
}