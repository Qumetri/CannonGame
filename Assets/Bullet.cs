using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float bulletForce = 50;
    [SerializeField] GameObject target;
    public Text countText;
    int score;
    void Start()
    {
        rb = GetComponent <Rigidbody>() ;
        rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        target.transform.position = position;
        score++;
        countText.text = score.ToString();
    }
    // Update is called once per frame

}
