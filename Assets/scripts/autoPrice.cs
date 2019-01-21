using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoPrice : MonoBehaviour {

    public static int price = 100;
    public static float currentPrice = 1;
    public static float newPrice = 1;
    public bool active = false;
    public float timer = 50;
    public float timerReduce = 1;
    public float timerFull = 50;
    public int amount = 1;

    public void autoClick()
    {
        if (price <= AVO_Counter.avoCounter)
        {
            AVO_Counter.avoCounter -= price;
            active = true;
            price = price * 3;
            newPrice += 1;
            if (timerReduce > 16)
            {
                amount = amount * 2;
            }
            
            
                timerReduce = timerReduce * 2; 

        }
    }
    private void FixedUpdate()
    {
        
        if (active == true)
        {
            timer -= timerReduce;
            if (timer <= 0)
            {
                AVO_Counter.avoCounter += amount;
                timer = timerFull;
            }
        }
      
    }
}
