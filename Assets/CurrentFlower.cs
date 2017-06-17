using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CurrentFlower : MonoBehaviour, IPointerDownHandler
{
    public Image old;
    public Sprite sprite;
	// Use this for initialization
	void Start () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        old.sprite = sprite;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
