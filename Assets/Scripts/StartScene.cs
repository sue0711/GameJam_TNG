using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScene : MonoBehaviour {

    public GameObject creditImg;
   
	// Use this for initialization
	void Start () 
    {
        creditImg = GameObject.Find("Canvas/CreditImg");
        creditImg.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToStart()
    {
        Application.LoadLevel("Game_Scene");
    }

    public void ShowCredit()
    {
        creditImg.SetActive(true);
    }

    public void ShowOffCredit()
    {
        creditImg.SetActive(false);
    }

}
