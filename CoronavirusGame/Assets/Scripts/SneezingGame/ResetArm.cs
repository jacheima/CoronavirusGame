using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetArm : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveArm()
    {
        transform.position = new Vector2(17.91f, 0f);
        anim.SetBool("sneeze", false);
    }
}
