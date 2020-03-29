using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Sink : MonoBehaviour
{
    [SerializeField] private UnityEvent playedHandwashing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        playedHandwashing.Invoke();
        
        
    }
}
