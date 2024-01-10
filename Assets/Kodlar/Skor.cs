using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skor : MonoBehaviour
{
    public UnityEngine.UI.Text skorText;
    oyunKontrol killScripti;
    int skor = 0;
    void Start()
    {
        skorText.text = "Skor :" +" "+skor ;
    }

    
}
