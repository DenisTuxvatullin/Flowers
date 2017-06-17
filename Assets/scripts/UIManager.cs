using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class UIManager : MonoBehaviour{
    public static int lvl = 0;
	// Use this for initialization
	void Start () {
        
        if (lvl == 0)
        {
            FileInfo f = new FileInfo("progress.txt");
            StreamWriter writer = f.CreateText();
            for (int i = 0; i < 5; i++)
            {
                writer.WriteLine("0");
            }
          writer.Close();
          Debug.Log(lvl);
        }
        lvl++;
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

    public void FourthLevel()
    {
        SceneManager.LoadScene(5);
    }

    public void FiveLevel()
    {
        SceneManager.LoadScene(6);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
