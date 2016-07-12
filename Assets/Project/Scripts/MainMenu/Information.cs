using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Information : MonoBehaviour {


    [SerializeField] InfoItem[] infoItem;

    [SerializeField] Text txt;
    [SerializeField] Image img;

    int index = 0;

    void OnEnable()
    {
        index = 0;
        ShowInfo();
    }

    void ShowInfo()
    {
        txt.text = infoItem[index].txt;
        img.sprite = infoItem[index].img;
    }
    public void Next() {
        index++;
        if (index >= infoItem.Length)
        {
            index = 0;
        }
        ShowInfo();
    }

    public void Previous() {
        index--;
        if (index < 0)
        {
            index = infoItem.Length-1;
        }
        ShowInfo();
    }
}
