using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Image timeBar;
	public float maxTime = 5f;
	float timeLeft;
	//public GameObject timesUpText;
	public GameObject gametendpanel;

	// Use this for initialization
	void Start () {
		//timesUpText.SetActive (false);
		timeBar = GetComponent<Image> ();
		timeLeft = maxTime;
	
		gametendpanel.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0)
		{
			timeLeft -= Time.deltaTime;
			timeBar.fillAmount = timeLeft / maxTime;

		}
		else
		{
			//timesUpText.SetActive (true);
			Time.timeScale = 0;
				gametendpanel.SetActive(true);
		
		}
		
	}

}
