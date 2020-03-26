using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float totalTime;
    private float percent;
    private float sceneStartTime;

    private bool isStarted;

    private int totalGerms = 78;
    private int destroyedGerms;
    private float germPercent;

    [SerializeField] private Image timerFill;

    [SerializeField] private GameObject startingUI;
    [SerializeField] private GameObject startingText;
    [SerializeField] private GameObject endingUI;
    [SerializeField] private GameObject tutorial;

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject endButton;

    [SerializeField] private Text statText;
    

    // Start is called before the first frame update
    void Start()
    {
        percent = 1f;
        endingUI.SetActive(false);
        startingUI.SetActive(false);
        endButton.SetActive(false);
        isStarted = false;
        sceneStartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStarted)
        {
            if (percent > 0)
            {
                percent -= .05f * Time.deltaTime;
                timerFill.fillAmount = percent;
            }
            
            if(percent <= 0f)
            {
               
                tutorial.SetActive(true);
                startingUI.SetActive(true);
                startingText.SetActive(false);
                endingUI.SetActive(true);
                startButton.SetActive(false);
                endButton.SetActive(true);

                GetGermPercent();

                statText.text = "You have " + (int)germPercent + "% of the germs still on your hands!";

            }
        }
        else
        {
            if (Time.time >= sceneStartTime + 2f)
            {
                startingUI.SetActive(true);
                startingText.SetActive(true);
            }
        }
    }

    private void GetGermPercent()
    {
        germPercent = ((destroyedGerms / totalGerms));
    }

    public void StartGame()
    {
        tutorial.SetActive(false);
        endingUI.SetActive(false);
        endButton.SetActive(false);
        isStarted = true;
    }

    public void EndGame()
    {
        sceneStartTime = 0;
        percent = 1;
        isStarted = false;
        tutorial.SetActive(true);
        startingText.SetActive(true);
        startButton.SetActive(true);
        endButton.SetActive(false);
        endingUI.SetActive(false);
        startingUI.SetActive(false);

        SceneManager.LoadScene(1);

    }


    public void CountGerms()
    {
        destroyedGerms++;
        Debug.Log(destroyedGerms);
    }
}
