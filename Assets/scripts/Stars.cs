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

public class Stars : MonoBehaviour {

    public Image s1;
    public Image s2;
    public Image s3;
    public Image s4;
    public Image s5;
    public Sprite star1;
    public Sprite star2;
    public Sprite star3;
	// Use this for initialization
	void Start () {
        SetStars();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SetStars()
    {
        var reader = new StreamReader("progress.txt");
        string A = reader.ReadLine();
        string B = reader.ReadLine();
        string C = reader.ReadLine();
        string D = reader.ReadLine();
        string E = reader.ReadLine();
        /////////////////////////////////1
        if (A == "1")
        {
            s1.sprite = star3;
        }
        if (A == "2")
        {
            s1.sprite = star2;
        }
        if (A == "3")
        {
            s1.sprite = star1;
        }
        ////////////////////////////////2
        if (B == "4")
        {
            s2.sprite = star1;
        }
        if (B == "2")
        {
            s2.sprite = star3;
        }
        if (B == "3")
        {
            s2.sprite = star2;
        }
        /////////////////////////////3
        if (C == "2")
        {
            s3.sprite = star3;
        }
        if (C == "3")
        {
            s3.sprite = star2;
        }
        if (C == "4")
        {
            s3.sprite = star1;
        }
        ////////////////////////////////4
        if (D == "1")
        {
            s4.sprite = star3;
        }
        if (D == "2")
        {
            s4.sprite = star2;
        }
        if (D == "3")
        {
            s4.sprite = star1;
        }
        ////////////////////////////////5
        if (E == "1")
        {
            s5.sprite = star3;
        }
        if (E == "2")
        {
            s5.sprite = star2;
        }
        if (E == "3")
        {
            s5.sprite = star1;
        }
        reader.Close();
    }
}
