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

    void Pickups(Collider player)
    {
        if (CompareTag("Apple"))
        {
            Debug.Log("Apple picked up!");
            // Spawn a cool effect when picked up
            GameObject test = (GameObject)Instantiate(pickUpEffect, transform.position, transform.rotation);
			//Destroy(test, 3.0f);	// Do not need this as there's a Stop Action property on the particle effect
            // Remove the power up object
            Destroy(gameObject);
            // Set the apple to true
            Inventory pikedUp = player.GetComponent<Inventory>();
            pikedUp.apple = true;
        }
        else if (CompareTag("BlackFlower"))
        {
            Debug.Log("Black Flower picked up!");
            // Spawn a cool effect when picked up
            GameObject test = (GameObject)Instantiate(pickUpEffect, transform.position, transform.rotation);
			//Destroy(test, 3.0f);	// Do not need this as there's a Stop Action property on the particle effect
            // Remove the power up object
            Destroy(gameObject);
            // Set the apple to true
            Inventory pikedUp = player.GetComponent<Inventory>();
            pikedUp.blackFlower = true;
        }
        else if (CompareTag("Disk"))
        {
            Debug.Log("Disk picked up!");
            // Spawn a cool effect when picked up
            GameObject test = (GameObject)Instantiate(pickUpEffect, transform.position, transform.rotation);
			//Destroy(test, 3.0f);	// Do not need this as there's a Stop Action property on the particle effect
            // Remove the power up object
            Destroy(gameObject);
            // Set the apple to true
            Inventory pikedUp = player.GetComponent<Inventory>();
            pikedUp.disk = true;
        }
        else if (CompareTag("Water"))
        {
            Debug.Log("Water picked up!");
            // Spawn a cool effect when picked up
            GameObject test = (GameObject)Instantiate(pickUpEffect, transform.position, transform.rotation);
			//Destroy(test, 3.0f);	// Do not need this as there's a Stop Action property on the particle effect
            // Remove the power up object
            Destroy(gameObject);
            // Set the apple to true
            Inventory pikedUp = player.GetComponent<Inventory>();
            pikedUp.water = true;
        }
    }

}
