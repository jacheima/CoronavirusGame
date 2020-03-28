using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ArmSelector : MonoBehaviour
{
    [SerializeField] private ArmMovers[] armsList;
    [SerializeField] private float waitTime;
    [SerializeField] private Timer timer;
    public bool selectArmStarted = false;
    public int numberSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.isStarted)
        {
            for (int i = 0; i < armsList.Length; i++)
            {
                if (armsList[i].isSelected == true)
                {
                    numberSelected++;

                }
            }

            if (numberSelected <= 2)
            {
                SelectArm();
            }
        }
    }
    
    void SelectArm()
    {
        int index = Random.Range(0, armsList.Length);
        armsList[index].isSelected = true;

    }
}
