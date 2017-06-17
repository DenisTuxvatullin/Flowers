using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void BackMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void OneLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void TwoLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void ThirdLevel()
    {
        SceneManager.LoadScene(4);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
