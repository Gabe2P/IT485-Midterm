using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour, Damagable
{
    public void TakeDamage()
    {
        Destroy(this.gameObject);
    }
}
