using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 3f;
    [SerializeField]private float jumpSpeed = 3f;

    private bool canKill = false;


    private Vector3 moveInput = Vector3.zero;

    private Collider col;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    public void CanKill(bool state)
    {
        canKill = state;
    }

    // Update is called once per frame
    void Update()
    {

        float speed = moveSpeed;
        moveInput = Vector3.zero;

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");

        moveInput = moveInput.normalized * speed;

        if (Input.GetButtonDown("Jump"))
        {
            moveInput.y = jumpSpeed;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Spawner s = FindObjectOfType<Spawner>();
            s.Spawn();
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (canKill)
        {
            Damagable enemy = other.GetComponent<Damagable>();
            if (enemy != null)
            {
                enemy.TakeDamage();
            }
        }
    }

    private void FixedUpdate()
    {
        PerformJump();
        PerformMovement();
    }

    private void PerformJump()
    {
        Vector3 jumpForce = new Vector3(0, moveInput.y, 0);
        rb.AddForce(jumpForce, ForceMode.Impulse);
    }
    private void PerformMovement()
    {
        rb.MovePosition(rb.position + moveInput * Time.fixedDeltaTime);
    }


}
