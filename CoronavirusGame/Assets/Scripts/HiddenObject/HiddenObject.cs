using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HiddenObject : MonoBehaviour
{
    [SerializeField] private bool isBallFound = false;
    [SerializeField] private bool isBlanketFound = false;
    [SerializeField] private bool isBlocksFound = false;
    [SerializeField] private bool isBooksFound = false;
    [SerializeField] private bool isConsoleFound = false;
    [SerializeField] private bool isMoviesFound = false;
    [SerializeField] private bool isPaintFound = false;
    [SerializeField] private bool isPencilsFound = false;
    [SerializeField] private bool isPictureFound = false;
    [SerializeField] private bool isPillowFound = false;
    [SerializeField] private bool isRocketFound = false;
    [SerializeField] private bool isTeddyFound = false;
    [SerializeField] private bool isTruckFound = false;

    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject blanket;
    [SerializeField] private GameObject blocks;
    [SerializeField] private GameObject books;
    [SerializeField] private GameObject console;
    [SerializeField] private GameObject movies;
    [SerializeField] private GameObject paint;
    [SerializeField] private GameObject pencils;
    [SerializeField] private GameObject picture;
    [SerializeField] private GameObject pillow;
    [SerializeField] private GameObject rocket;
    [SerializeField] private GameObject teddy;
    [SerializeField] private GameObject truck;

    [SerializeField] private GameObject ballUI;
    [SerializeField] private GameObject blanketUI;
    [SerializeField] private GameObject blocksUI;
    [SerializeField] private GameObject booksUI;
    [SerializeField] private GameObject consoleUI;
    [SerializeField] private GameObject moviesUI;
    [SerializeField] private GameObject paintUI;
    [SerializeField] private GameObject pencilsUI;
    [SerializeField] private GameObject pictureUI;
    [SerializeField] private GameObject pillowUI;
    [SerializeField] private GameObject rocketUI;
    [SerializeField] private GameObject teddyUI;
    [SerializeField] private GameObject truckUI;

    [SerializeField] private Timer timer;

    [SerializeField] private UnityEvent startHiddenObjectGame;

    public int objectsFound;

    private void Start()
    {
        startHiddenObjectGame.Invoke();
    }

    private void Update()
    {
        if(objectsFound == 13)
        {
            Time.timeScale = 0;
            timer.percent = 0;
        }
    }
    public void Ball()
    {
        isBallFound = true;
        Destroy(ball);
        objectsFound++;
        ballUI.SetActive(false);
    }

    public void Blanket()
    {
        isBlanketFound = true;
        Destroy(blanket);
        objectsFound++;
        blanketUI.SetActive(false);
    }

    public void Blocks()
    {
        isBlocksFound = true;
        Destroy(blocks);
        objectsFound++;
        blocksUI.SetActive(false);
    }

    public void Books()
    {
        isBooksFound = true;
        Destroy(books);
        objectsFound++;
        booksUI.SetActive(false);
    }

    public void Console()
    {
        isConsoleFound = true;
        Destroy(console);
        objectsFound++;
        consoleUI.SetActive(false);
    }
    public void Movies()
    {
        isMoviesFound = true;
        Destroy(movies);
        objectsFound++;
        moviesUI.SetActive(false);
    }
    public void Paint()
    {
        isPaintFound = true;
        Destroy(paint);
        objectsFound++;
        paintUI.SetActive(false);
    }
    public void Pencils()
    {
        isPencilsFound = true;
        Destroy(pencils);
        objectsFound++;
        pencilsUI.SetActive(false);
    }
    public void Picture()
    {
        isPictureFound = true;
        Destroy(picture);
        objectsFound++;
        pictureUI.SetActive(false);
    }
    public void Pillow()
    {
        isPillowFound = true;
        Destroy(pillow);
        objectsFound++;
        pillowUI.SetActive(false);
    }
    public void Rocket()
    {
        isRocketFound = true;
        Destroy(rocket);
        objectsFound++;
        rocketUI.SetActive(false);
    }
    public void Teddy()
    {
        isTeddyFound = true;
        Destroy(teddy);
        objectsFound++;
        teddyUI.SetActive(false);
    }
    public void Truck()
    {
        isTruckFound = true;
        Destroy(truck);
        objectsFound++;
        truckUI.SetActive(false);
    }
}
