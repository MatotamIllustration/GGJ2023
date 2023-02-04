using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunGridManager : MonoBehaviour
{
    public GunGridTile[] grid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Shootable[] UpdateGunProperties()
    {
        List<Shootable> toReturn = new List<Shootable>();
        foreach(GunGridTile tile in grid)
        {
            //check what the tileable on that tile is and what its effects are
            if(tile.TileableOnThisTile != null)
            {
                Tileable temp = tile.TileableOnThisTile;

                if(temp.tileType == TileableType.thing)
                {
                    //it's a shootable thing, check the area around it if it has any decorations, and at it to the list
                    toReturn.Add(temp.thisShootable);
                }
                //pass it through
            }
        }

        return toReturn.ToArray();
    }
}
