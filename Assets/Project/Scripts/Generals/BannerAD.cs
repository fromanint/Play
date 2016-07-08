using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class BannerAD : MonoBehaviour {


    BannerView bannerView;

    void OnEnable() {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1197928120102604~4370423972";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

      

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.

        AdRequest request = new AdRequest.Builder()
  .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
  .AddTestDevice("5C947A115970BEABA775D481B218E4A7")  // My test device.
  .Build();
        
        //AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
        Debug.Log("Show Ad");
    }

    void OnDisable() {
        bannerView.Destroy();
    }
}
