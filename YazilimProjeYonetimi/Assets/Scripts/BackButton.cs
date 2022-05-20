using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    //Geri butonlari icin ortak olan islemler icin gerekli tanimlama 
    [SerializeField] private Button back;

    
    void Start()
    {
        //Butona basildiginda ana menu'yu yukleyecek fonksiyonun cagrilmasi
        back.onClick.AddListener(TaskOnClick);
    }

    //Ana menuyu yukleyecek fonksiyon
    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
