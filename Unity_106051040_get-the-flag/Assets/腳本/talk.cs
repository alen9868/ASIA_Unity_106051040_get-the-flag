
using UnityEngine;
using UnityEngine.UI;

public class talk : MonoBehaviour
{
    [Header("介面")]
    public Text textname;
    public Text textcontent;
    public CanvasGroup CG;
    public void showdialog(string getname, string getcontent)
      
    {
      CG.alpha = 1;
        textname.text = getname;
        textcontent.text = getcontent;
    }
    public void hidedialog(string getname, string getcontent)

    {
        CG.alpha = 0;
        
    }
}
