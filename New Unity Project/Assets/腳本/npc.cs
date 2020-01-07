
using UnityEngine;

public class npc : MonoBehaviour
{
    private string _name = "Uni";
    private string content = "找到5面旗幟吧!!!!";
    public talk tk;
    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "player")
            tk.showdialog(_name,content);


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "player")
            tk.hidedialog(_name, content);
    }



}
