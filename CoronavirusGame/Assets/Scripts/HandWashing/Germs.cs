using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Germs : MonoBehaviour
{
    public SpriteRenderer sprite;
    public float opacityValue = 1f;
    public int enteredNumber = 0;

    public UnityEvent germDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        opacityValue = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (opacityValue <= 0f)
        {
            germDestroyed.Invoke();
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bubble")
        {
            Debug.Log("Soap");
            enteredNumber++;
            opacityValue -= .1f;
            sprite.color = new Color(1f, 1f, 1f, opacityValue);

        }
    }
}
