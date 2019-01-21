using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradePriceText : MonoBehaviour
{
    public Text price;

    private void Start()
    {
        price = GetComponent<Text>();
        price.text = upgradePrice.price + string.Format(" A");
    }
    private void FixedUpdate()
    {
        if (upgradePrice.currentPrice == upgradePrice.newPrice)
        {
            price.text = upgradePrice.price + string.Format(" A");
            upgradePrice.currentPrice += 1;
        }
    }
}
