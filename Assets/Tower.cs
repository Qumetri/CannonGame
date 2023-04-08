using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speedRotate = 10;
   
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * speedRotate;
        transform.Rotate(0, moveX, 0);
    }
}
