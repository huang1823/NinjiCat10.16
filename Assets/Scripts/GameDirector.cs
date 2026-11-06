using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hp;
    public TextMeshProUGUI show;
    float counttime = 0;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("menu");
        }
        counttime += Time.deltaTime;
        show.text = ( 15-counttime).ToString("f0");
        if(counttime> 15)
        {
            Time.timeScale = 0;//暫停遊戲
            if(hp.GetComponent<Image>().fillAmount >=0.6)
            {
                //過關成功載入下一關
                Time.timeScale=1f;
                SceneManager.LoadScene("ch6_GameScene");


            }
            else
            {
                //過關失敗重新載入
                Time.timeScale = 1f;
                SceneManager.LoadScene("ch5");
            }
        }
    }
    // Update is called once per frame
    public void DecreaseHp()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseHp()
    {
        hp.GetComponent<Image>().fillAmount += 0.1f;
    }
}
