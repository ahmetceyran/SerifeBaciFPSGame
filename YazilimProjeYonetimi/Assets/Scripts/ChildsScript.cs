using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildsScript : MonoBehaviour
{
    //Cocugu kucaga alma ve araca birakma icin kullanilacak tanimlamalar
    //iki tane cocugumuz var bunlardan biri fps karakterde baslangicta disable digeri acarta
    [SerializeField] private GameObject cartChild;
    [SerializeField] private GameObject FpsChild;

    

    void OnTriggerStay(Collider other)//Triggerla temasta iken yapilacak islemler
    {
        //C'ye basildiginda aractaki cocugun disable edilip fps'deki cocugun aktif edilmesi
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.C))
        {
            cartChild.SetActive(false);
            FpsChild.SetActive(true);
        }
        //V'ye basildiginda aractaki cocugun aktif edilip fps'deki cocugun disable edilmesi 
        if (Input.GetKey(KeyCode.V))
        {
            cartChild.SetActive(true);
            FpsChild.SetActive(false);
        }
    }

}
