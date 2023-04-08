using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunUp : MonoBehaviour
{
    [SerializeField] float speedUp = 10;
    [SerializeField] float maxAngle = 80, minAngle = 10;
    void Update()
    {
        float angleX = transform.localRotation.eulerAngles.x;
        //   print(angleX);
        angleX += Input.GetAxis("Mouse Y") * speedUp;
        angleX = Mathf.Clamp(angleX, minAngle, maxAngle);

        transform.localRotation = Quaternion.Euler(angleX, 0, 0);
    }
}
