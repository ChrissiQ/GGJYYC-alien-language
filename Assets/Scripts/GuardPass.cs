using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardPass : MonoBehaviour {

    public bool guardGo;
    public GameObject dust;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuardMoves(other);
        }
    }

    void GuardMoves(Collider Player)
    {
        Inventory coffee = Player.GetComponent<Inventory>();
        if (coffee.gear == true && coffee.lever == true && coffee.key == true)
        {
            //Debug.Log("Unlocked the gate!");
            guardGo = true;
            Instantiate(dust, transform.position, transform.rotation);
            return;
        }
        else
        {
            Debug.Log("You need keys");
        }
    }
}
