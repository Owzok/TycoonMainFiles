using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Drill : Machine
{
    public float spawn_time;
    public GameObject prefab;
    private Vector3 spawnPos;
    public int value;

    void Start(){
        InvokeRepeating("Generate", 0f, spawn_time);
        switch(facingDirection){
            case 0:

            break;
            case 1:
                spawnPos = new Vector3(transform.position.x + 0.333f, transform.position.y - 0.03f, transform.position.z);
            break;
            case 2:

            break;
            case 3:

            break;
        }
    }

    public override void updatePanel(){
        panel.transform.GetChild(1).GetComponent<Image>().sprite = img; // change img
        panel.transform.GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2(size_x * 260, size_y * 220); // change img
        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = this.gameObject.name;
        panel.transform.GetChild(3).GetComponent<Image>().sprite = img; // change img
        panel.transform.GetChild(3).GetComponent<RectTransform>().sizeDelta = new Vector2(size_x * 260, size_y * 220); // change img
        panel.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "value: " + value;
        panel.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "timer: " + spawn_time;
        panel.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "price: " + obj_price;
        
        panel.transform.GetChild(8).GetComponent<Button>().onClick.AddListener(HidePanel);
    }

    private void Generate(){
        Instantiate(prefab, spawnPos, transform.rotation);
    }
}
