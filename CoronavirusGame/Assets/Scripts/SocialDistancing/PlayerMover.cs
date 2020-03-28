using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Vector2 startPosition;
    float speed = 1f;

    Vector3 mousePos;

    [SerializeField] private Timer timer;
    private bool canStartTimer = true;
    private float levelStartTime;
    private float waitTime = .5f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.isStarted)
        {
            if(canStartTimer)
            {
                levelStartTime = Time.time;
                canStartTimer = false;
            }
           
            if(Time.time > levelStartTime + waitTime)
            {
                transform.position += transform.up * speed * Time.deltaTime;

                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                mousePos.x = Mathf.Clamp(mousePos.x, -2.2f, 2.3f);
                this.gameObject.transform.position = new Vector3(mousePos.x, transform.position.y, 0f);
            }
            
            if(speed != 7f)
            {
                speed += 2f * Time.deltaTime;
            }
        }
    }
}
