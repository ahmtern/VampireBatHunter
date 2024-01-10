using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public GameObject GameOverCoin;
    oyunKontrol oyunKontrolScripti;
    private void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Script").GetComponent<oyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(GameOverCoin, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrolScripti.GameOver();
        SceneManager.LoadScene("GameOver");
    }
}