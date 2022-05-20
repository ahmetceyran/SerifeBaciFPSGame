using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    //Menu butonlarinin tanimlanmasi
    [SerializeField] private Button Hardness, Controlls, Story, Credits;

    
    void Start()
    {
        //Butona gore gerekli fonksiyonlarin cagrilmasi
        Hardness.onClick.AddListener(TaskOnClick);
        Controlls.onClick.AddListener(TaskOnClick1);
        Story.onClick.AddListener(TaskOnClick2);
        Credits.onClick.AddListener(TaskOnClick3);

    }

    //Butona gore ekranlarin acilmasi
    void TaskOnClick()
    {
        SceneManager.LoadScene("Hardness");
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("Controlls");
    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene("Story");
    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene("Credits");
    }
}
