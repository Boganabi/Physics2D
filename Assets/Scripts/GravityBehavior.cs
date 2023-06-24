using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBehavior : MonoBehaviour
{
    // private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<BoxCollider2D>().attachedRigidbody;
    }

    // public ConstantForce gravity;
    // Update is called once per frame
    void Update()
    {
        /*
        gravity = gameObject.AddComponent<ConstantForce>();
        gravity.force = new Vector3(0.0f, -9.81f, 0.0f);
        */

        // rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y + Physics.gravity.y);
    }
}
