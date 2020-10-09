using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PowerUp : MonoBehaviour, Interactable
{
    private Collider col;

    public void Start()
    {
        col = GetComponent<Collider>();
    }

    public void OnTriggerEnter(Collider other)
    {
        this.Activate(other);
    }

    virtual public bool Activate(Collider other)
    {
        return true;
    }
}
