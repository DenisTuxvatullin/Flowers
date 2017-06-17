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

public class For1to3 : MonoBehaviour, IPointerDownHandler
{
    public Image first;
    public Image second;
    public Image third;
    public Image imageFor;
    public Image ForDeleting;
    public Image current;
    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Lvl3.current_click++;
        audioSource.Play();
        ForDeleting.sprite = current.sprite;
        if (ForDeleting && imageFor)
        {
            if ((imageFor.sprite.name == "1" && ForDeleting.sprite.name == "solo1") ||
                (imageFor.sprite.name == "12" && ForDeleting.sprite.name == "solo2") ||
                (imageFor.sprite.name == "11" && ForDeleting.sprite.name == "solo3"))
            {
                Destroy(ForDeleting);
            }

        }

        if (first.sprite.name == second.sprite.name && first.sprite.name == third.sprite.name)
        {
            StreamReader reader = File.OpenText("progress.txt");
            string A = reader.ReadLine();
            string B = reader.ReadLine();
            string C = reader.ReadLine();
            string D = reader.ReadLine();
            string E = reader.ReadLine();
            reader.Close();
            if (Application.loadedLevel == 4)
            {
                C = Lvl3.current_click.ToString();
            }
            if (Application.loadedLevel == 5)
            {
                D = Lvl3.current_click.ToString();
            }
            if (Application.loadedLevel == 6)
            {
                E = Lvl3.current_click.ToString();
            }

            FileInfo f = new FileInfo("progress.txt");
            StreamWriter writer = f.CreateText();
            writer.WriteLine(A);
            writer.WriteLine(B);
            writer.WriteLine(C);
            writer.WriteLine(D);
            writer.WriteLine(E);
            writer.Close();

            Lvl3.current_click = 0;
            if (Application.loadedLevel < 6)
            {
                SceneManager.LoadScene(Application.loadedLevel + 1);
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
