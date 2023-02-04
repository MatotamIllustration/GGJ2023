using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunGridTile : MonoBehaviour
{
    public Tileable TileableOnThisTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SnapTo(Transform _toSnap)
    {
        _toSnap.position = transform.position;
    }

    public void GetTileableInfo(Tileable _tile)
    {
        TileableOnThisTile = _tile;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tileable")
        {
            if (Vector2.Distance(transform.position, collision.transform.position) < 0.5f)
            {
                SnapTo(collision.transform);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Tileable>() == null)
        {
            return;
        }

        TileableOnThisTile = null;
    }
}
