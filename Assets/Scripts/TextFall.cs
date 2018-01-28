using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFall : MonoBehaviour {

    public float speed;
    public GameObject letter;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -1 * speed;
    }

}
