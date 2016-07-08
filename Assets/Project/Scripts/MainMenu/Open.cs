using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour {

    [SerializeField]string objective = "";
    
    public void OpenScene() {
        if (objective == "")
        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
        else { 
        SceneManager.LoadScene(objective);
        }
    }

    public void OpenUrl() {
        Application.OpenURL(objective);
    }

    public void ShareFB() {
    }

    public void OpenAd() {
    }
}
