﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SocialDistancing : MonoBehaviour
{
    [SerializeField] private UnityEvent startSocialDistancting;
    // Start is called before the first frame update
    void Start()
    {
        startSocialDistancting.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
