using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Handwashing : MonoBehaviour
{
    [SerializeField] private UnityEvent startHandwashing;

    // Start is called before the first frame update
    void Start()
    {
        startHandwashing.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
