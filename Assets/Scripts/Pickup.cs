using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject pickUpEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickups(other);
        }
    }

    void Pickups(Collider Player)
    {
        if (CompareTag("Apple") || CompareTag("BlackFlower") || CompareTag("Disk") || CompareTag("Water"))
        {
            Debug.Log("Item picked up!");
            // Spawn a cool effect when picked up
            GameObject test = (GameObject)Instantiate(pickUpEffect, transform.position, transform.rotation);
            //Destroy(test, 3.0f);	// Do not need this as there's a Stop Action property on the particle effect
            // Remove the power up object
            Destroy(gameObject);
            // Set the apple to true
            Inventory pikedUp = Player.GetComponent<Inventory>();
            pikedUp.apple = true;
        }
    }

}
