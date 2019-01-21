using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallAVO_appear : MonoBehaviour
{
    public GameObject smallAVO;

    private void Start()
    {

    }
    public void AVO_click()
    {
       
        Instantiate(smallAVO, new Vector2(Random.Range(1f, -1f), Random.Range(1f, -1f)), Quaternion.identity);

    }
}
