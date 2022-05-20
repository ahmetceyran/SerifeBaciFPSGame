using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Hava durumu degisimini kontrol etmek, oyuncu ve cocuk cani icin gerekli tanimlamalar
    [SerializeField] private Text playerHealthText;
    [SerializeField] private Text childsHealthText;
    [SerializeField] private GameObject clouds;
    [SerializeField] private GameObject FpsChild;
    private int PlayerHealth = 100;
    private int ChildsHealth = 100;
    private float time;//Can azalmasini ve artmasini yavaslatmak icin kullanilacak degiskenler
    private float timeDelay;

    void Start()
    {
        time = 0f;
        timeDelay = 1f;
    }

    

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;//Can azalmasi ve artmasini gercek zamanla saniyede bir yapmak icin kullanilan yontem
        if(time >= timeDelay)
        {
            time = 0f;
            if (clouds.activeInHierarchy == true)//Hava durumu efektleri aktif ise cani azaltmak
            {
                if(FpsChild.activeInHierarchy == true)
                {
                    IncreaseHealth(ref PlayerHealth);
                }
                if(FpsChild.activeInHierarchy == false)
                {
                    DecreaseHealth(ref PlayerHealth);
                }
            }
            if (clouds.activeInHierarchy == false)//Hava durumu efektleri inaktif ise cani arttirmak
            {
                IncreaseHealth(ref PlayerHealth);
            }
            if (PlayerHealth > 100)
            {
                PlayerHealth = 100;
            }
        }
        playerHealthText.text = "Player Health : " + PlayerHealth;//Karakter ve cocugun canini ekranda guncelleme
        childsHealthText.text = "Childs Health : " + ChildsHealth;

    }

    private void DecreaseHealth(ref int PlayerHealth)//Can azaltma fonksiyonu
    {
        if (PlayerHealth > 0 && ChildsHealth > 0)
        {
            PlayerHealth = PlayerHealth - 1;
            ChildsHealth = ChildsHealth - 2;
            if(PlayerHealth <= 0 || ChildsHealth <= 0)//Eger karakterlerden birinin cani 0 veya eksi olursa oyunun bitmesi
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    private void IncreaseHealth(ref int PlayerHealth)//Can arttirma fonksiyonu
    {
        if (ChildsHealth < 100)
        {
            PlayerHealth = PlayerHealth + 1;
            ChildsHealth = ChildsHealth + 1;
        }
    }

}
