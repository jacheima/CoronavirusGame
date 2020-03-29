using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSortingLayer : MonoBehaviour
{
    ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle.GetComponent<ParticleSystem>();
        particle.GetComponent<Renderer>().sortingOrder = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
