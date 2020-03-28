using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenObject : MonoBehaviour
{
    public bool isBallFound = false;
    public bool isBlanketFound = false;
    public bool isBlocksFound = false;
    public bool isBooksFound = false;
    public bool isConsoleFound = false;
    public bool isMoviesFound = false;
    public bool isPaintFound = false;
    public bool isPencilsFound = false;
    public bool isPictureFound = false;
    public bool isPillowFound = false;
    public bool isRocketFound = false;
    public bool isTeddyFound = false;
    public bool isTruckFound = false;

    public GameObject ball;
    public GameObject blanket;
    public GameObject blocks;
    public GameObject books;
    public GameObject console;
    public GameObject movies;
    public GameObject paint;
    public GameObject pencils;
    public GameObject picture;
    public GameObject pillow;
    public GameObject rocket;
    public GameObject teddy;
    public GameObject truck;

    public int objectsFound;


    public void Ball()
    {
        isBallFound = true;
        Destroy(ball);
        objectsFound++;

    }

    public void Blanket()
    {
        isBlanketFound = true;
        Destroy(blanket);
        objectsFound++;
    }

    public void Blocks()
    {
        isBlocksFound = true;
        Destroy(blocks);
        objectsFound++;
    }

    public void Books()
    {
        isBooksFound = true;
        Destroy(books);
        objectsFound++;
    }

    public void Console()
    {
        isConsoleFound = true;
        Destroy(console);
        objectsFound++;
    }
    public void Movies()
    {
        isMoviesFound = true;
        Destroy(movies);
        objectsFound++;
    }
    public void Paint()
    {
        isPaintFound = true;
        Destroy(paint);
        objectsFound++;
    }
    public void Pencils()
    {
        isPencilsFound = true;
        Destroy(pencils);
        objectsFound++;
    }
    public void Picture()
    {
        isPictureFound = true;
        Destroy(picture);
        objectsFound++;
    }
    public void Pillow()
    {
        isPillowFound = true;
        Destroy(pillow);
        objectsFound++;
    }
    public void Rocket()
    {
        isRocketFound = true;
        Destroy(rocket);
        objectsFound++;
    }
    public void Teddy()
    {
        isTeddyFound = true;
        Destroy(teddy);
        objectsFound++;
    }
    public void Truck()
    {
        isTruckFound = true;
        Destroy(truck);
        objectsFound++;
    }
}
