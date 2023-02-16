using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Machine : MonoBehaviour
{
    public int facingDirection;
    public GameObject panel;
    public Sprite img;
    public int obj_price;
    public int size_x, size_y;

    void Awake(){
        panel = GameObject.Find("DescPanel");
    }

    public virtual void updatePanel(){
        panel.transform.GetChild(3).GetComponent<RectTransform>().sizeDelta = new Vector2(size_x * 260, size_y * 220); // change img
    }

    public void HidePanel(){
        panel.GetComponent<Animator>().SetTrigger("out");
    }

    private void OnMouseDown(){
        updatePanel();
        panel.GetComponent<Animator>().SetTrigger("in");
        Debug.Log(gameObject.name);
    }
}
