using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfirmPanel : MonoBehaviour {

	public Text txtConfirm;

	[HideInInspector]public string objectName;
	[HideInInspector]public int objectPrice;
	// Use this for initialization

	[SerializeField] public GameObject buyPanel;
	[SerializeField] public GameObject noBuyPanel;  

	string confirm;

	void Start()
	{
		gameObject.SetActive (false);
	}
	void OnDisable()
	{
		objectName = "";
		objectPrice = 0;
		txtConfirm.text = confirm;
		buyPanel.SetActive (false);
		noBuyPanel.SetActive (false);
	}

	void OnEnable()
	{
		if (PlayerPrefs.GetInt ("Score", 0) >= objectPrice) {
			confirm = txtConfirm.text;	
			txtConfirm.text = txtConfirm.text.Replace ("(name)", objectName);
			txtConfirm.text = txtConfirm.text.Replace ("(price)", objectPrice.ToString ());
			int newScore = PlayerPrefs.GetInt ("Score") - objectPrice;
			PlayerPrefs.SetInt ("Score", newScore);
			buyPanel.SetActive (true);
		} else {
			noBuyPanel.SetActive (true);
		}

	}

	public void ConfirmBuy(){
		string buyObject = objectName.Replace (" ", "");
		PlayerPrefs.SetInt(buyObject , 1 );
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
