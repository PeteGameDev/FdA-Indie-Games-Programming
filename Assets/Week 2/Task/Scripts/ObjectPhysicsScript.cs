using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysicsScript : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 downForce;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        downForce = new Vector3(0, -1, 0);
        rb.AddForce(downForce, ForceMode.VelocityChange);
    }

    
    public void Update()
    {
        
        DeleteObject();
    }

    void DeleteObject()
    {
        Destroy(gameObject, 2f);
    }
}
