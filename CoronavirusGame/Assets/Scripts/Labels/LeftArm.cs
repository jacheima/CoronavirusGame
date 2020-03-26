using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    public ParticleSystem system;
    // Start is called before the first frame update
    void Start()
    {
        system = GameObject.Find("LeftHandSystem").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Soap")
        {
            Debug.Log("Bubbles");
            system.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Soap")
        {
            system.Stop();
        }
    }
}
