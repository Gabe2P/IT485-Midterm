using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanosPowerUp : PowerUp
{
    public Material color;

    override public bool Activate(Collider other)
    {
        Orb[] list = FindObjectsOfType<Orb>();

        foreach (Orb blob in list)
        {
            blob.TakeDamage();
        }

        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.gameObject.transform.GetComponent<MeshRenderer>().material = color;
        }

        Destroy(this.gameObject);
        return true;
    }
}
