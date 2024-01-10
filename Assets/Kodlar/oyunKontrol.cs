using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text timeText, killText;
    public GameObject patlama;
    public float gameTime = 60f;
    public int kill=0;
    // Start is called before the first frame update
    void Start()
    {
        killText.text = "Kill : " + " " + kill;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            timeText.text = "Time :" + " " + (int)gameTime;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag ("bat");
            for (int i = 0; i < go.Length; i++) 
            {
                Instantiate(patlama,go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
    }
    public void KillAdd() 
    {
        kill += 1;
        killText.text = "Kill : " + " " + kill;
    }

    public void BonusKill() 
    {
        kill -= 5;
        killText.text = "Kill : " + " " + kill;
        if (kill < 0) 
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    
    public void GameOver() 
    {
        gameTime = 0;
    }
}
