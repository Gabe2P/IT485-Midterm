using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerUp : PowerUp
{
    public Material color;

    override public bool Activate(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = false;
            rb.gameObject.transform.GetComponent<MeshRenderer>().material = color;
        }

        Destroy(this.gameObject);
        return true;
    }
}
