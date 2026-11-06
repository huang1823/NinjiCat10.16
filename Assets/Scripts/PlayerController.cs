using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1;//讓暫停的遊戲恢復運行
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
            if(transform.position.x > 8f)
            {
                transform.position = new Vector3(8f,transform.position.y,transform.position.z);

            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
            if (transform.position.x <-8f)
            {
                transform.position = new Vector3(-8f, transform.position.y, transform.position.z);

            }
        }
    }
    public void Rbutton()
    {
        transform.Translate(1, 0, 0);
    }
    public void Lbutton()
    {
        transform.Translate(-1, 0, 0);
    }
}
