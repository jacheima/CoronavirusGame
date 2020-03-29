using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool hasPlayedHandwashing;
    public bool hasPlayedFaceTouching;
    public bool hasPlayedSneezingGame;
    public bool hasPlayedHiddenObjectGame;
    public bool hasPlayedSocialDistancingGame;

    public GameObject sink;
    public GameObject bear;
    public GameObject door;
    public GameObject blocks;
    public GameObject toyBox;

    public Sprite SinkSprite;
    public Sprite BearSprite;
    public Sprite DoorSprite;
    public Sprite BlocksSprite;
    public Sprite ToyboxSprite;

    private void Awake()
    {
        if(instance != null & instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        hasPlayedFaceTouching = false;
        hasPlayedHandwashing = false;
        hasPlayedHiddenObjectGame = false;
        hasPlayedSneezingGame = false;
        hasPlayedSocialDistancingGame = false;
    }

    private void Update()
    {
        if (sink == null)
        {
            Debug.Log("Finding Sink");
            sink = GameObject.Find("Sink");
        }
        if (bear == null)
        {
            bear = GameObject.Find("Bear");
        }
        if (door == null)
        {
            door = GameObject.Find("Door");
        }
        if (blocks == null)
        {
            blocks = GameObject.Find("Blocks");
        }
        if (toyBox == null)
        {
            toyBox = GameObject.Find("Toybox");
        }


        if (hasPlayedHandwashing)
        {
            sink.GetComponent<SpriteRenderer>().sprite = SinkSprite;
        }
        if (hasPlayedFaceTouching)
        {
            bear.GetComponent<SpriteRenderer>().sprite = BearSprite;
        }
        if (hasPlayedHiddenObjectGame)
        {
            toyBox.GetComponent<SpriteRenderer>().sprite = ToyboxSprite;
        }
        if (hasPlayedSneezingGame)
        {
            blocks.GetComponent<SpriteRenderer>().sprite = BlocksSprite;
        }
        if (hasPlayedHandwashing)
        {
            door.GetComponent<SpriteRenderer>().sprite = DoorSprite;
        }


        

    }
    public void PlayedHandwashing()
    {
        if(!hasPlayedHandwashing)
        {
            hasPlayedHandwashing = true;
            sink.GetComponent<SpriteRenderer>().sprite = SinkSprite;
        }
        
        SceneManager.LoadScene(2);

    }

    public void PlayedFaceTouching()
    {
        if(!hasPlayedFaceTouching)
        {
            hasPlayedFaceTouching = true;
            bear.GetComponent<SpriteRenderer>().sprite = BearSprite;
        }
        
        SceneManager.LoadScene(3);
    }

    public void PlayedSneezingGame()
    {
        if(!hasPlayedSneezingGame)
        {
            hasPlayedSneezingGame = true;
            blocks.GetComponent<SpriteRenderer>().sprite = BlocksSprite;
        }
        
        SceneManager.LoadScene(6);
    }

    public void PlayedHiddedObjectGame()
    {
        if(!hasPlayedHiddenObjectGame)
        {
            hasPlayedHiddenObjectGame = true;
            toyBox.GetComponent<SpriteRenderer>().sprite = ToyboxSprite;
        }
        
        SceneManager.LoadScene(5);
    }

    public void PlayedSocialDistancing()
    {
        if(!hasPlayedSocialDistancingGame)
        {
            hasPlayedSocialDistancingGame = true;
            door.GetComponent<SpriteRenderer>().sprite = DoorSprite;
        }
        
        SceneManager.LoadScene(4);
    }
}
