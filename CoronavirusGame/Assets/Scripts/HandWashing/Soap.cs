using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soap : MoveableObject
{
    protected override void Update()
    {

        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (isBeingHeld && gameObject.tag == "Soap" || isBeingHeld && gameObject.tag == "Bubble")
        {
            this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0f);
        }
        else
        {
            this.gameObject.transform.position = new Vector2(startPosX, startPosY);
        }
    }
}
