using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : IPoolable
{
    public GameObject body;
    public bool active { get; set; }

    public void OnEnableObject()
    {
        body.SetActive(true);
    }
    public void OnDisableObject()
    {
        body.SetActive(false);
    }

}
