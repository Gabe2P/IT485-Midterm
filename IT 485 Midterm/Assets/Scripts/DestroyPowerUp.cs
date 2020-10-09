using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : PowerUp
{
    public Material color;

    override public bool Activate(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.gameObject.transform.GetComponent<MeshRenderer>().material = color;
            player.CanKill(true);
        }

        Destroy(this.gameObject);
        return true;
    }
}
