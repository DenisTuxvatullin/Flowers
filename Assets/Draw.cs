using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.
using UnityEngine.SceneManagement;

public class Draw : MonoBehaviour, IPointerDownHandler
{
    public Image oldImage;
    public Image newImage;
    public Image second;
    public Image third;
    public static int lvl = 0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
	// Use this for initialization
	void Start () {
        lvl = 0;
	}

    public void OnPointerDown(PointerEventData eventData)
    {

        if (newImage.sprite.name == "solo1")
        {
            oldImage.sprite = sprite1;
        }
        if (newImage.sprite.name == "solo2")
        {
            oldImage.sprite = sprite2;
        }
        if (newImage.sprite.name == "solo3")
        {
            oldImage.sprite = sprite3;
        }


        if (second.sprite.name == oldImage.sprite.name && oldImage.sprite.name == third.sprite.name)
        {
            SceneManager.LoadScene(3);
            lvl++;
            if (lvl == 2)
            {
                SceneManager.LoadScene("menu");
            }
        }
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
