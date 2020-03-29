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

    public void PlayedHandwashing()
    {
        hasPlayedHandwashing = true;
        SceneManager.LoadScene(2);

    }

    public void PlayedFaceTouching()
    {
        hasPlayedFaceTouching = true;
    }

    public void PlayedSneezingGame()
    {
        hasPlayedSneezingGame = true;
    }

    public void PlayedHiddedObjectGame()
    {
        hasPlayedHiddenObjectGame = true;
    }

    public void PlayedSocialDistancing()
    {
        hasPlayedSocialDistancingGame = true;
    }
}
