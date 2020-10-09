using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject orb;

    public void Spawn()
    {
        this.transform.position = new Vector3(0, 5, 0);
        Instantiate(orb);
    }
}
