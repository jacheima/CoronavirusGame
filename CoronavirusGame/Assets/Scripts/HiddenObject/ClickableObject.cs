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
                
                hiddenObject.
                break;
            case "Blanket":
                
                break;
            case "Blocks":
                hiddenObject.isBlocksFound = true;
                break;
            case "Books":
                hiddenObject.isBooksFound = true;
                break;
            case "Console":
                hiddenObject.isConsoleFound = true;
                break;
            case "Movies":
                hiddenObject.isMoviesFound = true;
                break;
            case "Paint":
                hiddenObject.isPaintFound = true;
                break;
            case "Pencils":
                hiddenObject.isPencilsFound = true;
                break;
            case "Picture":
                hiddenObject.isPictureFound = true;
                break;
            case "Pillow":
                hiddenObject.isPictureFound = true;
                break;
            case "Rocket":
                hiddenObject.isRocketFound = true;
                break;
            case "Teddy":
                hiddenObject.isTeddyFound = true;
                break;
            case "Truck":
                hiddenObject.isTruckFound = true;
                break;
        }
    }
}
