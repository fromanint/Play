using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;   


[RequireComponent(typeof(SoundControl))]
public class MainMenuControl : MonoBehaviour {

    

    [SerializeField] Text txtScore;
    [SerializeField] Text txtDistanceScore;

    //Sound options
    [SerializeField] Image imgSound;
    [SerializeField] Sprite soundOn, soundOff;
    int sound;

    void Start()
    {
        txtScore.text = PlayerPrefs.GetInt("Score",0).ToString();
        txtDistanceScore.text = Mathf.Round(PlayerPrefs.GetFloat("Distance", 0)).ToString() + " m";
        SetAudio();
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }

    void SetAudio()
    {
        sound = PlayerPrefs.GetInt("Sound", 1);
        if (sound == 1)
        {
            imgSound.sprite = soundOn;
            GetComponent<SoundControl>().PlayAudio();
        }
        else
        {
            imgSound.sprite = soundOff;
            GetComponent<SoundControl>().StopAudio();
        }
    }

    public void ChangeSound()
    {
        sound = PlayerPrefs.GetInt("Sound", 1);
        if (sound == 0)
        {
            
            PlayerPrefs.SetInt("Sound", 1);
            Debug.Log("Audio On");
        }
        else
        {

            PlayerPrefs.SetInt("Sound", 0);
            Debug.Log("Audio Off");
        }
        SetAudio();
    }



}
