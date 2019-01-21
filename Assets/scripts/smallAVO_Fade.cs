using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallAVO_Fade : MonoBehaviour
{

    public SpriteRenderer rend;
    public float rotate;
    public float fader;
    public float riseSpeed = 0.8f;

    private void Start()
    {
        transform.localScale = new Vector2(Random.Range(8f, 11f), Random.Range(8f, 11f));
        rotate = Random.Range(-10, 11);
        //   rotate = 0;
        fader = 1.5f;
        rend = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        rend.color = new Color(1, 1, 1, fader);
        fader -= 0.01f;

        if (fader < 0)
        {
            Destroy(gameObject);
        }

        transform.Translate(transform.position.x * Time.deltaTime + riseSpeed * Time.deltaTime, transform.position.y * Time.deltaTime + riseSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, rotate * Time.deltaTime);

    }
}
