using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNavigation : MonoBehaviour
{
    public void GoToHandwashing()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToFaceTouching()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToSocialDistancing()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToHiddenObjectGame()
    {
        SceneManager.LoadScene(5);
    }
}
