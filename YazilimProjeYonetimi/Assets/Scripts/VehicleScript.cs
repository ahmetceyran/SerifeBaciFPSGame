using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleScript : MonoBehaviour
{
    //Karakter hareketleri icin kullanilacak controller tanimlamasi
    [SerializeField] private CharacterController controller;

    private float speed = 6f;


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//controller'in konumunun alinmasi
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput).normalized;
        
        if(direction.magnitude >= 0.1f)//controller rotasyonun gerceklenmesi
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(-90f, 90f, targetAngle);

            
            controller.Move(direction.normalized * speed * Time.deltaTime);
        }

    }


}
