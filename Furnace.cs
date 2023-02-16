using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Furnace : Machine
{
    public override void updatePanel(){
        panel.transform.GetChild(1).GetComponent<Image>().sprite = img; // change img
        panel.transform.GetChild(1).GetComponent<RectTransform>().sizeDelta = new Vector2(size_x * 260, size_y * 220); // change img
        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = this.gameObject.name;
        panel.transform.GetChild(3).GetComponent<Image>().sprite = img; // change img
        panel.transform.GetChild(3).GetComponent<RectTransform>().sizeDelta = new Vector2(size_x * 260, size_y * 220); // change img
        panel.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "price: " + obj_price;
        panel.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "";
        panel.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "";     
    
        panel.transform.GetChild(8).GetComponent<Button>().onClick.AddListener(HidePanel);
    }
}
