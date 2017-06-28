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

public class GameProcess : MonoBehaviour, IPointerDownHandler
{
    public Image current_flower;
    public Image current_color;
    public Image f1;
    public Image f2;
    public Image f3;
    public Image f4;
    public Image f5;
    public Image f6;
    public Image f7;
    public Image f8;
    public Image f9;
    public Image f10;
    public Image f11;
    public Image f12;
    public Image f13;
    public Image f14;
    public Image f15;
    public Image f16;
    public static int current_click = 0;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        if (current_color.sprite.name != current_flower.sprite.name)
        {
            current_click++;
            audioSource.Play();
            UpdateField();
        }
    }

    private void UpdateField()
    {
        if (!f16)
        {
            switch (current_flower.name)
            {
                case "F1":
                    SetColor(ref current_flower, ref f2, ref f3);
                    break;
                case "F2":
                    SetColor(ref current_flower, ref f1, ref f3);
                    break;
                case "F3":
                    SetColor(ref current_flower, ref f1, ref f2);
                    break;
                case "F5":
                    SetColor(ref current_flower, ref f4, ref f6);
                    break;
                case "F6":
                    SetColor(ref current_flower, ref f4, ref f5);
                    break;
                case "F4":
                    SetColor(ref current_flower, ref f5, ref f6);
                    break;
                case "F7":
                    SetColor(ref current_flower, ref f8, ref f9);
                    break;
                case "F8":
                    SetColor(ref current_flower, ref f7, ref f9);
                    break;
                case "F9":
                    SetColor(ref current_flower, ref f7, ref f8);
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (current_flower.name)
            {
                case "F1":
                    SetColor(ref current_flower, ref f2, ref f3, ref f4);
                    break;
                case "F2":
                    SetColor(ref current_flower, ref f1, ref f3, ref f4);
                    break;
                case "F3":
                    SetColor(ref current_flower, ref f1, ref f2, ref f4);
                    break;
                case "F4":
                    SetColor(ref current_flower, ref f1, ref f2, ref f3);
                    break;

                case "F5":
                    SetColor(ref current_flower, ref f7, ref f6, ref f8);
                    break;
                case "F6":
                    SetColor(ref current_flower, ref f7, ref f5, ref f8);
                    break;
                case "F7":
                    SetColor(ref current_flower, ref f5, ref f6, ref f8);
                    break;
                case "F8":
                    SetColor(ref current_flower, ref f7, ref f6, ref f5);
                    break;

                case "F9":
                    SetColor(ref current_flower, ref f10, ref f11, ref f12);
                    break;
                case "F10":
                    SetColor(ref current_flower, ref f9, ref f11, ref f12);
                    break;
                case "F11":
                    SetColor(ref current_flower, ref f10, ref f9, ref f12);
                    break;
                case "F12":
                    SetColor(ref current_flower, ref f10, ref f11, ref f9);
                    break;

                case "F13":
                    SetColor(ref current_flower, ref f14, ref f15, ref f16);
                    break;
                case "F14":
                    SetColor(ref current_flower, ref f13, ref f15, ref f16);
                    break;
                case "F15":
                    SetColor(ref current_flower, ref f14, ref f13, ref f16);
                    break;
                case "F16":
                    SetColor(ref current_flower, ref f14, ref f15, ref f13);
                    break;
                default:
                    break;
            }
        }
    }
	
    private void SetColor(ref Image cur, ref Image first, ref Image second)
    {
        if (first.sprite == second.sprite && cur.sprite == second.sprite)// && cur.sprite == first.sprite)
        {
            cur.sprite = current_color.sprite;
            first.sprite = cur.sprite;
            second.sprite = cur.sprite;
        }
        else
        {
            cur.sprite = current_color.sprite;
        }
        LevelUp();
        
    }

    private void SetColor(ref Image cur, ref Image first, ref Image second, ref Image third)
    {
        if (first.sprite == second.sprite && cur.sprite == second.sprite && cur.sprite == third.sprite)// && cur.sprite == first.sprite)
        {
            cur.sprite = current_color.sprite;
            first.sprite = cur.sprite;
            second.sprite = cur.sprite;
            third.sprite = cur.sprite;
        }
        else
        {
            cur.sprite = current_color.sprite;
        }
        LevelUp4();
    }
    private void LevelUp4()
    {
        if (
               f1.sprite == f2.sprite && f1.sprite == f3.sprite
               && f1.sprite == f4.sprite && f1.sprite == f5.sprite
               && f1.sprite == f6.sprite && f1.sprite == f7.sprite
               && f1.sprite == f8.sprite && f1.sprite == f9.sprite
               && f1.sprite == f10.sprite && f1.sprite == f11.sprite
               && f1.sprite == f12.sprite && f1.sprite == f13.sprite
               && f1.sprite == f14.sprite && f1.sprite == f15.sprite
               && f1.sprite == f16.sprite
           )
        {
            Stars();
        }
    }

    private void Stars()
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
            if (Application.loadedLevel == 4)
            {
                C = current_click.ToString();
            }
            if (Application.loadedLevel == 5)
            {
                D = current_click.ToString();
            }
            if (Application.loadedLevel == 6)
            {
                E = current_click.ToString();
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

            
            SceneManager.LoadScene(1);
    }
    private void LevelUp()
    {
        if  (
                   f1.sprite == f2.sprite && f1.sprite == f3.sprite
                && f1.sprite == f4.sprite && f1.sprite == f5.sprite
                && f1.sprite == f6.sprite && f1.sprite == f7.sprite
                && f1.sprite == f8.sprite && f1.sprite == f9.sprite
            )
        {
            Stars();
        }

    }
	// Update is called once per frame
}
