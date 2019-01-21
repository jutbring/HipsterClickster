using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autoPriceText : MonoBehaviour {

    public Text price;

    private void Start()
    {
        price = GetComponent<Text>();
        price.text = autoPrice.price + string.Format(" A");
    }
    private void FixedUpdate()
    {
        if (autoPrice.currentPrice == autoPrice.newPrice)
        {
            price.text = autoPrice.price + string.Format(" A");
            autoPrice.currentPrice += 1;
        }
    }
}
