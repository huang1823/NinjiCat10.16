using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = cat.transform.position;
        Vector2 dir = p1 - p2;
        float d= dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1f;
        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();
            Destroy(gameObject);
        }
    }
}
