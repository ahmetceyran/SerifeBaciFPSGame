using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardnessPick : MonoBehaviour
{
    //Zorluk secim ekranindaki butonlarin tanimlanmasi
    [SerializeField] private Button back, easy, normal, hard;

    void Start()
    {
        //Secilen butona gore fonksiyonlarin cagrilmasi
        back.onClick.AddListener(TaskOnClick);
        easy.onClick.AddListener(TaskOnClick1);
        normal.onClick.AddListener(TaskOnClick2);
        hard.onClick.AddListener(TaskOnClick3);

    }

    //Secilen butona gore ekranlari getiren fonksiyonlar
    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("EasyMode");
    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene("NormalMode");
    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene("HardMode");
    }
}
