using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private HiddenObject hiddenObject;
    [SerializeField] private string nameOfObject;

    private void OnMouseDown()
    {
        switch (nameOfObject)
        {
            case "Balls":
                hiddenObject.Ball();
                break;
            case "Blanket":
                hiddenObject.Blanket();
                break;
            case "Blocks":
                hiddenObject.Blocks();
                break;
            case "Books":
                hiddenObject.Books();
                break;
            case "Console":
                hiddenObject.Console();
                break;
            case "Movies":
                hiddenObject.Movies();
                break;
            case "Paint":
                hiddenObject.Paint();
                break;
            case "Pencils":
                hiddenObject.Pencils();
                break;
            case "Picture":
                hiddenObject.Picture();
                break;
            case "Pillow":
                hiddenObject.Pillow();
                break;
            case "Rocket":
                hiddenObject.Rocket();
                break;
            case "Teddy":
                hiddenObject.Teddy();
                break;
            case "Truck":
                hiddenObject.Truck();
                break;
        }
    }
}
