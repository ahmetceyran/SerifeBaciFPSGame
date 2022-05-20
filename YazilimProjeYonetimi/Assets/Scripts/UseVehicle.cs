using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseVehicle : MonoBehaviour
{
    //Arac kontrolleri ve fps karakterin disable edilmesi icin gerekli tanimlamalar
    [SerializeField] private GameObject Vehicle;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CarCamera;
    private bool inVehicle;

    // Start is called before the first frame update
    void Start()
    {
        Vehicle.GetComponent<VehicleScript>().enabled = false;
        inVehicle = false;
    }

    void OnTriggerStay(Collider other)//Karakter triggerla temas ettiginde araca binmesi ve fps karakterin disable edilmesi
    {
        if(other.gameObject.tag == "Player" && inVehicle == false && Input.GetKey(KeyCode.E))
        {
            Player.SetActive(false);
            Player.transform.parent = Vehicle.transform;
            Vehicle.GetComponent<VehicleScript>().enabled = true;
            CarCamera.SetActive(true);
            inVehicle = true;
        }
    }

    // Update is called once per frame
    void Update()//Karakter aractaysa f ile inmesi ve fps karakterin tekrar ektif edilmesi
    {
        if(inVehicle == true && Input.GetKey(KeyCode.F))
        {
            Vehicle.GetComponent<VehicleScript>().enabled = false;
            Player.SetActive(true);
            CarCamera.SetActive(false);
            Player.transform.parent = null;
            inVehicle = false;
        }
    }
}
