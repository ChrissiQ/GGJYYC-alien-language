using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGuard : MonoBehaviour {

    public Transform target;
    public float speed;

    void Update()
    {
        GuardPass move = GetComponent<GuardPass>();
        if (move.guardGo==true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
