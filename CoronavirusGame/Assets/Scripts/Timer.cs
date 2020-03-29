using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private float totalTime;
    public float percent;
    private float sceneStartTime;

    public bool isStarted;

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

    private bool handwashingActive = false;
    private bool faceTouchingActive = false;
    private bool socialDistancingActive = false;
    private bool hiddenobjectActive = false;
    private bool sneezingGameAvtive = false;

    public GameObject water1;
    public GameObject water2;
    public GameObject water3;
    public GameObject water4;
    public GameObject water5;


    // Start is called before the first frame update
    void Start()
    {
        percent = 1f;
        endingUI.SetActive(false);
        startingUI.SetActive(false);
        endButton.SetActive(false);
        isStarted = false;
        sceneStartTime = Time.time;

        water1.SetActive(false);
        water2.SetActive(false);
        water3.SetActive(false);
        water4.SetActive(false);
        water5.SetActive(false);

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

                if(handwashingActive && percent <= .9f)
                {
                    water1.SetActive(true);
                }

                if(handwashingActive && percent < .9f && percent > .75f)
                {
                    water2.SetActive(true);
                }

                if(handwashingActive && percent < .7f && percent > .55f)
                {
                    water3.SetActive(true);
                }

                if(handwashingActive && percent < .5f && percent > .35f)
                {
                    water4.SetActive(true);
                }

                if (handwashingActive && percent < .3f && percent > .15f) ;
                {
                    water5.SetActive(true);
                }
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

                if(handwashingActive)
                {
                    statText.text = "You have " + (int)germPercent + "% of the germs still on your hands!";
                }

                if(faceTouchingActive)
                {
                    statText.text = "";
                }

                if(socialDistancingActive)
                {
                    statText.text = "";
                }

                if(hiddenobjectActive)
                {
                    statText.text = "";
                }

                if(sneezingGameAvtive)
                {
                    statText.text = "";
                }
            }
        }
        else
        {
            if (Time.time >= sceneStartTime + 2f)
            {
                startingUI.SetActive(true);

                if(handwashingActive)
                {
                    startingText.GetComponent<Text>().text = "Hi there! \n\n Let's learn to wash our hands to get all the " +
                        "germs off. You can be a here by: \n\n*Using water to rinse your hands \n*Using soap to scrub " +
                        "away all the germ \n*Rinse your hands to get all the soap off \n";
                }

                if(faceTouchingActive)
                {
                    startingText.GetComponent<Text>().text = "When we touch things around the house, like a door " +
                        "knob or our phones, germs stick to our hands. Then when we touch our face, they travel " +
                        "from our hands into our bodies. \n \nLet's help Mr. Cuddles to not touch his face so he can stay" +
                        "healthy! \n\nClick his hands when you see them to stop him from touching his face. Good luck!";
                }

                if(socialDistancingActive)
                {
                    startingText.GetComponent<Text>().text = "";
                }

                if(sneezingGameAvtive)
                {
                    startingText.GetComponent<Text>().text = "";
                }
                if(hiddenobjectActive)
                {
                    startingText.GetComponent<Text>().text = "";
                }
                
                startingText.SetActive(true);
            }
        }
    }

    public void StartHandwashingGame()
    {
        handwashingActive = true;
        faceTouchingActive = false;
        socialDistancingActive = false;
        hiddenobjectActive = false;
        sneezingGameAvtive = false;
    }

    public void StartFaceTouchingGame()
    {
        handwashingActive = false;
        faceTouchingActive = true;
        hiddenobjectActive = false;
        socialDistancingActive = false;
        sneezingGameAvtive = false;
    }

    public void StartSocialDistancingGame()
    {
        handwashingActive = false;
        faceTouchingActive = false;
        hiddenobjectActive = false;
        socialDistancingActive = true;
        sneezingGameAvtive = false;
        
    }

    public void StartHiddenObjectGame()
    {
        handwashingActive = false;
        faceTouchingActive = false;
        socialDistancingActive = false;
        hiddenobjectActive = true;
        sneezingGameAvtive = false;
    }

    public void StartSneezingGame()
    {
        handwashingActive = false;
        faceTouchingActive = false;
        socialDistancingActive = false;
        hiddenobjectActive = false;
        sneezingGameAvtive = true;
    }

    private void GetGermPercent()
    {
        germPercent = ((destroyedGerms / totalGerms));
    }

    public void StartGame()
    {
        endingUI.SetActive(false);
        endButton.SetActive(false);
        tutorial.SetActive(false);
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
