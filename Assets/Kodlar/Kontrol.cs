using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public GameObject Patlama;
    oyunKontrol oyunKontrolScripti;
    private void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Script").GetComponent<oyunKontrol>();
    }
    void OnMouseDown()
    {
        GameObject go =Instantiate(Patlama,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrolScripti.KillAdd();
    }
}
