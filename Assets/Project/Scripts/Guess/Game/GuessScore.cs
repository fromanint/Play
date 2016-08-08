using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuessScore : MonoBehaviour {

    [SerializeField] Color achiveColor;
    [SerializeField] Image[] Stars;


    [SerializeField] Image Bar;

    [HideInInspector] public GuessControl GC;


    public void Start()
    {
        Bar.fillAmount = 0;
    }
    public void UpdateScore(float fill, int starIndex)
    {

        Bar.fillAmount = fill;
        ChangeStarColor(starIndex);
    }

    void ChangeStarColor(int index)
    {
        if (index != -1 && index <= Stars.Length)
        {
            Stars[index].color = achiveColor;
        }
    }

    public void MoveStar(float posx, int index)
    {
        Stars[index].rectTransform.anchoredPosition= new Vector2(posx, Stars[index].rectTransform.anchoredPosition.y);
    }



}
