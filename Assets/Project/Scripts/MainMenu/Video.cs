using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Video : MonoBehaviour {

    void Start()
    {
        Advertisement.Initialize("1092117", true);

      
    }

    // Update is called once per frame
    public void ShowVideo() {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
