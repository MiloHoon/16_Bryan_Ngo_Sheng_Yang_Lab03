using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Healthy")
        {
            GameManager.instance.AddScore();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Unhealthy")
        {
            GameManager.instance.MinusScore();
            Destroy(collision.gameObject);
        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
    }
}