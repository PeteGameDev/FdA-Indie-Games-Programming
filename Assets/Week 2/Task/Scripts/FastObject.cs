using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastObject : ObjectPhysicsScript
{
    // Start is called before the first frame update
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        downForce = new Vector3(0, -2f, 0);
        rb.AddForce(downForce, ForceMode.VelocityChange);
    }

    
}
