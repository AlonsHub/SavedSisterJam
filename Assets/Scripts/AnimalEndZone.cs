using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalEndZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Animal"))
        {
            AnimalInventory.Instance.AddAnimal();
            Destroy(other.gameObject);
        }
    }
}
