using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class MeterRunUI : MonoBehaviour {

    GameControl GC;
    PlayerControl player;
    [SerializeField] float points;

    void Start() {
        GC = GameObject.FindObjectOfType<GameControl>();
        if (!GC)
        {
            Debug.Log("No Game control found");
            enabled = false;
        }
        GC.run = 0;
        player = FindObjectOfType<PlayerControl>();
    }

    void FixedUpdate() {
        if(player.speed!=0)
        { 
          GC.run += points * Time.deltaTime;
        }

        GetComponent<Text>().text = Mathf.Round(GC.run).ToString();
    }

}
