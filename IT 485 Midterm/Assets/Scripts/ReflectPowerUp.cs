using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectPowerUp : PowerUp
{
    public Material color;

    override public bool Activate(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.gameObject.transform.GetComponent<MeshRenderer>().material = color;
            player.CanKill(false);
        }

        Destroy(this.gameObject);
        return true;
    }
}
