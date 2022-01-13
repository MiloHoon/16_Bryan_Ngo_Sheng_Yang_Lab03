using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Healthy")
        {
            GameManager.instance.AddScore();
            Destroy(other.gameObject);
            audioSource.Play();
        }

        if (other.gameObject.tag == "Unhealthy")
        {
            GameManager.instance.MinusScore();
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
    }
}