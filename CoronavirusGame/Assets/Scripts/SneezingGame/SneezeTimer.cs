using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SneezeTimer : MonoBehaviour
{

    private float sneezeWait;
    [SerializeField] private GameObject arm;
    [SerializeField] private GameObject warningUI;

    [SerializeField] private UnityEvent sneeze;

    [SerializeField] private Animator sneezeAnim;

    private float sneezeStartTime;

    private bool isReadyToSneeze;
    public bool isSneezing;

    private Animator anim;

    private int score;

    private bool clicked;

    private void Start()
    {
        warningUI.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
        anim = GetComponent<Animator>();
        sneezeStartTime = Time.time;
        sneezeWait = 1;
        isReadyToSneeze = false;
        isSneezing = false;
    }

    private void Update()
    {
        if (Time.time > sneezeStartTime + sneezeWait && !isReadyToSneeze)
        {
            isReadyToSneeze = true;
            sneezeWait = Random.Range(5, 15);

        }

        if(isSneezing)
        {
            isReadyToSneeze = false;
            sneezeAnim.SetBool("didSneeze", true);
        }

        if (isReadyToSneeze)
        {
            anim.SetBool("startWarning", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            arm.GetComponent<Animator>().SetBool("sneeze", true);
            clicked = true;
        }
    }

    public void SneezeSetup()
    {
        sneezeStartTime = Time.time;
        anim.SetBool("playWarning", true);
        anim.SetBool("startWarning", false);
    }

    public void Sneeze()
    {
        anim.SetBool("playWarning", false);
        anim.SetBool("exitAnim", true);
        sneezeAnim.SetBool("didSneeze", true);
        isReadyToSneeze = false;
        isSneezing = true;

        if(clicked)
        {
            score++;
            clicked = false;
        }
        else
        {
            score--;
        }
    }
}
