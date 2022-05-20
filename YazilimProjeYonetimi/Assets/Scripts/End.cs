using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    //Oyun sonu ekranindaki butonlarin kontrolu icin gerekli tanimlamalar
    [SerializeField] private Button quit, restart;

    void Start()
    {
        //Butona gore fonksiyonun cagrilmasi
        quit.onClick.AddListener(TaskOnClick);
        restart.onClick.AddListener(TaskOnClick1);
    }

    //butona gore yuklenecek ekrani cagiracak fonksiyonlar
    void TaskOnClick()
    {
        Application.Quit();
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("Menu");
    }

}
