
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loot : MonoBehaviour
{
    [Header("擁有旗幟數量")]
    public Text textownloot;
    [Header("勝利提示畫面")]
    public GameObject wintip;
    public int ownloot;
    public int totalloot=5;

    public bool win;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="target")
        {
            Destroy(collision.gameObject);
            ownloot++;
            textownloot.text = "旗幟數量" + ownloot + "/5";
        }
        if (ownloot == totalloot)
        {
            wintip.SetActive(true);
            win = true;
        }
    }



    private void Update()
    {
        gameover();
    }
    private void gameover()
    {
        if (win)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Application.LoadLevel("沙漠");//r\舊版
                SceneManager.LoadScene("沙漠");
            }
        }
    }
}
