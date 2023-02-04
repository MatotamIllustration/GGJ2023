using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tileable : MonoBehaviour
{
    public GameObject body;
    Collider2D thisCol;
    // Start is called before the first frame update
    void Awake()
    {
        thisCol = GetComponent<Collider2D>();
        body = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGrab()
    {
        thisCol.enabled = false;
    }

    public void OnRelease()
    {
        thisCol.enabled = true;
    }
}
