using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    protected float startPosX;
    protected float startPosY;
    protected bool isBeingHeld = false;
    protected Vector3 mousePos;

    protected virtual void Start()
    {
        startPosX = transform.position.x;
        startPosY = transform.position.y;
    }
    protected virtual void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (isBeingHeld && gameObject.tag == "Arm")
        {
            if (GetComponent<LeftArm>())
            {
                mousePos.x = Mathf.Clamp(mousePos.x, -3.7f, -.5f);
            }

            if (GetComponent<RightArm>())
            {
                mousePos.x = Mathf.Clamp(mousePos.x, 0.3f, 3.5f);
            }

            this.gameObject.transform.position = new Vector3(mousePos.x, startPosY, 0f);
        }
        else
        {
            this.gameObject.transform.position = this.gameObject.transform.position;
        }
    }

    protected virtual void OnMouseDown()
    {
        isBeingHeld = true;
    }

    protected virtual void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
