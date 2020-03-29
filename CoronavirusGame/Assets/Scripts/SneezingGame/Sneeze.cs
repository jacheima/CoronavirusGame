using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneeze : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private SneezeTimer sneezeTimer;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void FinishSneeze()
    {
        anim.SetBool("didSneeze", false);
        ClearSnot();
    }

    public void ClearSnot()
    {
        sneezeTimer.isSneezing = false;
    }
}
