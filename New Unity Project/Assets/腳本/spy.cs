
using UnityEngine;

public class spy : MonoBehaviour
{
    [Header("玩家狀態")]
    public string run = "run";
    public string jump = "jump";
    public string hurt = "hurt";
    public string attack = "attack";
    [Header("血量")]
    public float heath = 1000;
    [Header("需求道具")]
    public int need = 0;
    [Header("目前道具")]
    public int have = 0;
    [Header("死亡與否")]
    public bool death_status = false;
    

    private void Update()
    {
        jp();
        movement();
        atk();
    }




    #region 狀態欄位
    public Animator Ani;
    private void movement()

    {
      

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       
        Ani.SetBool("run", h != 0 || v != 0);
        
    }
    private void jp()
    {

        if (
         Input.GetKeyDown(KeyCode.Space)
         )
            Ani.SetBool("jump", true);
        else
        {
            Ani.SetBool("jump",false);
        }
    }
    private void tkdmg(float hurt)
    {
    }
    private void atk() 
    {
        if (
         Input.GetKeyDown(KeyCode.Mouse0)
         )
            Ani.SetTrigger("attack");
    }
    private void death(bool death_status)
    {
    }
    private void life(float heath)
    {
    }
    private void prop()
    {
    }
    private void complete() 
    {
    }



    #endregion
   
}
