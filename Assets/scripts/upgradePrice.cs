using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradePrice : MonoBehaviour {

    public static int price = 50;
    public static double currentPrice = 1;
    public static double newPrice = 1;

    public void upgradeClick()
    {
        if (price <= AVO_Counter.avoCounter)
        {
            AVO_Counter.avoCounter -= price;
            AVO_Counter.amount = AVO_Counter.amount * 2 ;
            price = price * 4;
            newPrice += 1;
           // AVO_Counter.avoCounter = 9999999999;
        }
    }
}
