using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public GameObject[] enemy = new GameObject[3];
       
    public GameObject cloneenemy;
  

    public int generateenemy;
    public int score;
     
    public Text todisplayscore;
    public Text  todisplayfinalscore,todisplaywfinalscore, todisplaygameover,todisplaygamewin;

    public GameObject gameendpanel;
   
    public GameObject gamecompletepanel;

	// Use this for initialization
	void Start () {
        instance = this;
        Time.timeScale = 1;
        score = 0;

        
        generateenemy = 1;
        todisplayscore = GameObject.Find("Score").GetComponent<Text>();
   
        todisplayfinalscore = GameObject.Find("highscore").GetComponent<Text>();

        todisplaywfinalscore = GameObject.Find("whighscore").GetComponent<Text>();

        todisplaygameover = GameObject.Find("gameover").GetComponent<Text>();
		todisplaygamewin = GameObject.Find("gamewin").GetComponent<Text>();
       
        gameendpanel = GameObject.Find("gameoverpanel");
        gamecompletepanel = GameObject.Find("gamewinpanel");
        
        gameendpanel.SetActive(false);
        gamecompletepanel.SetActive(false);
       
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        cloneenemys();
     
        displayinfo();
        
    }
    public void cloneenemys()
    {
        if (generateenemy==30)
        {
            cloneenemy = enemy[Random.Range(0, 25)];
            Instantiate(cloneenemy, cloneenemy.transform.position, cloneenemy.transform.rotation);
            generateenemy = 1;
        }
        else
        {
            generateenemy = generateenemy + 1;
        }
    }
   
       
    public void addscore(int value)
    {
        score = score + value;
        //audiomanager.instance.playsound(3);
    }
 
  

    public void displayinfo()
    {
        todisplayscore.text = "" + score;  
    }
    public void showgameendpanel()
    {
        gameendpanel.SetActive(true);
        todisplaygameover.text = "GAME OVER";
        todisplayfinalscore.text = "" + score;
        
        //audiomanager.instance.playsound(5);
        Time.timeScale = 0;
        
    }
    public void showgamecompletepanel()
    {
        gamecompletepanel.SetActive(true);
		todisplaygamewin.text = "CONGRATULATION";
        todisplaywfinalscore.text = " " + score;
      
		
       // audiomanager.instance.playsound(1);
        Time.timeScale = 0;
       
        
    }


    public void exit()
    {
        Application.Quit();
    }

    
    

    public void replay1()
    {
        Application.LoadLevel("Level");
    }

      public void menus()
    {
        Application.LoadLevel("main");
    }


}

