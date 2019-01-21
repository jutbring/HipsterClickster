using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AVO_Counter : MonoBehaviour {

    public static double avoCounter;
    public static double amount = 1;

 public void AVO_Click()
    {
        avoCounter += amount;
        AVO_Size.clicked = true;
    }
}
