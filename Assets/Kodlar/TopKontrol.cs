using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int toplanilacakObjeSayisi;
    public Text sayacText;
    public Text oyunbittiText;

	void Start () 
    {
        fizik = GetComponent<Rigidbody>();
		
	}
	
	
	void FixedUpdate () 
    
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);
		
	}
    void OnTriggerEnter(Collider a)
    {
        //Stay ve Exit var bide Enter Dışında
        if(a.gameObject.tag=="engel")
        {
            a.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "Sayac = " + sayac;
            if(sayac==toplanilacakObjeSayisi)
            {
                oyunbittiText.text = "Oyun BİTTİ";
            }
        }

    }
}
