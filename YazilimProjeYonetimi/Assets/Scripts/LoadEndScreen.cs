using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScreen : MonoBehaviour
{

    //Finish trigger'ina carpinca oyun sonu ekranin acilmasi
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cart")
        {
            SceneManager.LoadScene("End");
        }
        
    }
}
