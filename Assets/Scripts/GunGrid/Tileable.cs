using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TileableType
{
    thing,
    decoration
}

public enum ShootableType
{
    bullet,
    grenade,
    laser,
    fire,
    ice
}

public class Tileable : MonoBehaviour
{
    public TileableType tileType;
    public ShootableType shootType;

    public Shootable thisShootable;

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
