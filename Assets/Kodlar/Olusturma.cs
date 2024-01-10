using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olusturma : MonoBehaviour
{
    public GameObject bat;
    public GameObject blood;
    public GameObject coin;
    float batOlusturmaSuresi=1f;
    float bloodOlusturmaSuresi = 15f;
    float coinOlusturmaSuresi = 20f;
    float zamanSayaci = 0f;
    float zamanSayaci2 = 15f;
    float zamanSayaci3= 20f;
    oyunKontrol okScripti;
    // Start is called before the first frame update
    void Start()
    {
        okScripti=this.gameObject.GetComponent<oyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        zamanSayaci2 -= Time.deltaTime;
        zamanSayaci3 -= Time.deltaTime;
        int katsayi = (int)(okScripti.gameTime / 10) - 6;
        katsayi *= -1;
        if (zamanSayaci < 0 && okScripti.gameTime > 0)
        {
            GameObject go = Instantiate(bat, new Vector3(Random.Range(-1.8f, 1.8f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(40f * katsayi, 80f * katsayi), 0));

            zamanSayaci = batOlusturmaSuresi;

        }
        if (zamanSayaci2 < 0 && okScripti.gameTime > 0)
        {
            GameObject gob = Instantiate(blood, new Vector3(Random.Range(-2.3f, 2.3f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            gob.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(200f, 300f), 0));
            zamanSayaci2=bloodOlusturmaSuresi;
        }
        if (zamanSayaci3 < 0 && okScripti.gameTime > 0)
        {
            GameObject goc = Instantiate(coin, new Vector3(Random.Range(-2f, 2f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            goc.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f, 200f), 0));
            zamanSayaci3 = coinOlusturmaSuresi;
        }
        
    }
}
