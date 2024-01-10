using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanTopu : MonoBehaviour
{
    public GameObject Blood;
    oyunKontrol oyunKontrolScripti;
    private void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Script").GetComponent<oyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(Blood, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrolScripti.BonusKill();
    }
}
