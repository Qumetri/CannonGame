using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotate : MonoBehaviour
{
    [SerializeField] float speedX = 10, speedY = 10;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;
    void Start()
    {

    }

    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, moveX * speedX, Space.World);

        float moveY = -Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.right, moveY * speedY, Space.Self);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
