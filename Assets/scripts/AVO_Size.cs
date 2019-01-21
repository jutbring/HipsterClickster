using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AVO_Size : MonoBehaviour {

    public static bool clicked = false;
    public float resizey = 1f;
    public float resizex = 1f;
    public float rotateCoolDown;

    void FixedUpdate() {
        if (rotateCoolDown > 0)
        {
            rotateCoolDown -= 1;
            transform.Rotate(0, 0, -1f);
        }
        transform.localScale = new Vector2(resizex, resizey);
        if (clicked == true)
        {
            transform.Rotate(0, 0, 4);
            rotateCoolDown += 4;

            resizex += 0.17f;
            resizey += 0.17f;
            
            clicked = false;

        }
       if (resizex > 1)
        {
            resizex -= 0.028f ;
        }
       if (resizey > 1)
        {
            resizey -= 0.028f;
        }
       if (resizex > 2)
        {
            resizex = 2;
        }
        if (resizey > 2)
        {
            resizey = 2;
        }
    }
}
