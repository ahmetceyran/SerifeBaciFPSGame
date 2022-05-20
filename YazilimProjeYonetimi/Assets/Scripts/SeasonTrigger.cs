using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonTrigger : MonoBehaviour
{
    //Hava durumu efekti icin kullanilacak objelerin tanimlanmasi
    [SerializeField] private GameObject clouds;
    [SerializeField] private GameObject CartSnow;
    [SerializeField] private GameObject CartSnowDrop;
    [SerializeField] private GameObject FirstPersonSnow;
    [SerializeField] private GameObject FirstPersonDrop;
    


    private void OnTriggerEnter(Collider other)
    {
        //Trigger'in tag'i winter ise efektlerin aktive edilmesi
        if(other.gameObject.tag == "Cart" && this.gameObject.tag == "Winter")
        {
            clouds.SetActive(true);
            CartSnow.SetActive(true); 
            CartSnowDrop.SetActive(true); 
            FirstPersonSnow.SetActive(true); 
            FirstPersonDrop.SetActive(true);
        }
        //Trigger'in tag'i summer ise efektlerin disable edilmesi
        if (other.gameObject.tag == "Cart" && this.gameObject.tag == "Summer")
        {
            clouds.SetActive(false);
            CartSnow.SetActive(false);
            CartSnowDrop.SetActive(false);
            FirstPersonSnow.SetActive(false);
            FirstPersonDrop.SetActive(false);
        }
    }

    


}
