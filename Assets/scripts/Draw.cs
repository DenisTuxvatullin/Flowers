using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

[RequireComponent(typeof(AudioSource))]
public class Draw : MonoBehaviour, IPointerDownHandler
{
    public Image oldImage;
    public Image newImage;
    public Image second;
    public Image third;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public AudioSource audioSource;
    public static int current_click = 0; 
	// Use this for initialization
	void Start () 
    {
	}


    public void OnPointerDown(PointerEventData eventData)
    {
        current_click++;
        if (newImage.sprite.name == "solo1")
        {
            oldImage.sprite = sprite1;
            audioSource.Play();
        }
        if (newImage.sprite.name == "solo2")
        {
            oldImage.sprite = sprite2;
            audioSource.Play();
        }
        if (newImage.sprite.name == "solo3")
        {
            oldImage.sprite = sprite3;
            audioSource.Play();
        }


        if (second.sprite.name == oldImage.sprite.name && oldImage.sprite.name == third.sprite.name)
        {
            StreamReader reader = File.OpenText("progress.txt");
            string A = reader.ReadLine();
            string B = reader.ReadLine();
            string C = reader.ReadLine();
            string D = reader.ReadLine();
            string E = reader.ReadLine();
            reader.Close();
            if (Application.loadedLevel == 2)
            {
                A = current_click.ToString();
            }
            if (Application.loadedLevel == 3)
            {
                B = current_click.ToString();
            }

            FileInfo f = new FileInfo("progress.txt");
            StreamWriter writer = f.CreateText();
            writer.WriteLine(A);
            writer.WriteLine(B);
            writer.WriteLine(C);
            writer.WriteLine(D);
            writer.WriteLine(E);
            writer.Close();

            current_click = 0;
            if (Application.loadedLevel == 6)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                SceneManager.LoadScene(Application.loadedLevel + 1);
            }
        }
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
