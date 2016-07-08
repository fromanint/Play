using UnityEngine;
using System.Collections;
using Facebook.Unity;

public class ActionButtons: MonoBehaviour {

	private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
	private const string TWEET_LANGUAGE = "en"; 

	private const string FACEBOOK_APP_ID = "1713030028924368";
	private const string FACEBOOK_URL = "http://www.facebook.com/dialog/feed";

/*	string linkweb = "http://nostrum.eu/nostrumexperienceAR/";
	string linkimg = "nostrum.eu/wp-content/uploads/2015/05/Wok2.png";
	string linktiny = "http://bit.ly/1h4CVJf";

	public static string msj;
	public static string min;
	public static string punt;

	public string porctitle;
	public string veggietitle;
	public string squidtitle;
	public string defaultitle = "";


	string replacetitle = "(nom_del_joc)"; //Texto a reemplazar por el titulo del minijuego
	string replacescore = "(puntuacion)"; //Texto a reemplazar por la puntuacion del jugador


	string text;
	bool FBBut;
*/
	void Start()
	{	
		if (!FB.IsInitialized) {
			// Initialize the Facebook SDK
			FB.Init(InitCallback, OnHideUnity);
		} else {
			// Already initialized, signal an app activation App Event
			FB.ActivateApp();
		}
	}


	private void InitCallback ()
	{
		if (FB.IsInitialized) {
			// Signal an app activation App Event
			FB.ActivateApp();
			// Continue with Facebook SDK
			// ...
		} else {
			Debug.Log("Failed to Initialize the Facebook SDK");
		}
	}

	private void OnHideUnity (bool isGameShown)
	{
		if (!isGameShown) {
			// Pause the game - we will need to hide
			Time.timeScale = 0;
		} else {
			// Resume the game - we're getting focus again
			Time.timeScale = 1;
		}
	}

	private void AuthCallback(ILoginResult result)
	{
		if (FB.IsLoggedIn)
		{
			// AccessToken class will have session details
			var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
			// Print current access token's User ID
			Debug.Log(aToken.UserId);
			// Print current access token's granted permissions
			foreach (string perm in aToken.Permissions)
			{
				Debug.Log(perm);
			}
		}
		else
		{
			Debug.Log("User cancelled login");
		}
	}


	public void FBShare()
	{
		FB.FeedShare(
  link: new System.Uri("https://example.com/myapp/?storyID=thelarch"),
  linkName: "The Larch",
  linkCaption: "I thought up a witty tagline about larches",
  linkDescription: "There are a lot of larch trees around here, aren't there?",
  picture: new System.Uri("https://example.com/myapp/assets/1/larch.jpg"),
  callback: null
);
	}




//Comienza Tweeter
	public void TweetButton()
	{
		/*text = ObtenerMsj();
		Application.OpenURL(TWITTER_ADDRESS +
			                           "?text=" + WWW.EscapeURL(text + linktiny) + 
			                           "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));*/

		//Var_globales.isGameOver = false;
		//Time.timeScale=1;
	}





}
