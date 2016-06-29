using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour {

    [SerializeField]string objective = "";
    
    public void OpenScene() {
        SceneManager.LoadScene(objective);
    }

    public void OpenUrl() {
        Application.OpenURL(objective);
    }

    public void ShareFB() {
    }

    public void OpenAd() {
    }
}
