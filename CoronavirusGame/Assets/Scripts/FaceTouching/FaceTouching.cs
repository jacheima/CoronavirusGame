using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FaceTouching : MonoBehaviour
{
    [SerializeField] private UnityEvent startFaceTouching;

    // Start is called before the first frame update
    void Start()
    {
        startFaceTouching.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
