using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTank : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveForward = 100;
    [SerializeField] float moveRotate = 100000;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * moveForward * Input.GetAxis("Vertical"));
        rb.AddTorque(transform.up * moveRotate * Input.GetAxis("Horizontal"));
    }
    void Update()
    {
        
    }
}
