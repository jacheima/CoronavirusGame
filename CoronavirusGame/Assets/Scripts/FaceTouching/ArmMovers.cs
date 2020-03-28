using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovers : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private ArmSelector armSelector;

    public bool isSelected = false;
    public bool isClicked = false;

    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isSelected", false);
        anim.SetBool("isClicked", false);
        anim.SetBool("extendAnimationFinsihed", false);
        anim.SetBool("retractIsFinished", false);
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        if (isSelected)
        {
            anim.SetBool("isSelected", true);
        }

        if (isClicked)
        {
            isSelected = false;
            armSelector.numberSelected--;
            anim.SetBool("isSelected", false);
        }
    }

    private void OnMouseDown()
    {
        isClicked = true;
        anim.SetBool("isClicked", isClicked);
        armSelector.selectArmStarted = false;
    }

    public void FinishExtendAnimation()
    {
        Debug.Log("Finished Extending");
        anim.SetBool("extendAnimationFinsihed", true);
        anim.SetBool("isSelected", false);
        anim.SetBool("isClicked", false);
        isSelected = false;
        isClicked = false;


    }

    public void FinishRetractAnimation()
    {
        Debug.Log("Finished Retracting");
        anim.SetBool("retractIsFinished", true);
        anim.SetBool("isClicked", false);
        isClicked = false;
        armSelector.numberSelected--;
    }
}
