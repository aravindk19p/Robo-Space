using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;

	// Use this for initialization

	void Start()
	{
		pauseMenuUI.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		
		{
			if (GameIsPaused)
			{
				Resume();

			}else
			{
				Pause();
			}
		}
		//audiomanager.instance.playsound(1);
	}
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;

	}
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		
		Time.timeScale = 0f;
		GameIsPaused = true;
		//audiomanager.instance.playsound(6);
	}
	  public void restart()
    {
        Application.LoadLevel("Level");
    }
	  public void exit()
    {
        Application.Quit();
    }
	   public void menus()
    {
        Application.LoadLevel("main");
    }
	 public void help()
    {
        Application.LoadLevel("help");
    }

}
