using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AVOscore : MonoBehaviour
{
    public Text score;
    public void Start()
    {
        score = GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        
        score.text = AVO_Counter.avoCounter + string.Format(" AVOs");
    }
    
      
    
}

