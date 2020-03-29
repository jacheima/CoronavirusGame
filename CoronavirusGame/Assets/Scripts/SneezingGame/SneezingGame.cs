using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SneezingGame : MonoBehaviour
{
    [SerializeField] private UnityEvent startSneezingLevel;

    // Start is called before the first frame update
    void Start()
    {
        startSneezingLevel.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
