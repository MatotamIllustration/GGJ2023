using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletShootable : Shootable
{
    GameObject prefab;
    //GameObject body;

    public BullletShootable()
    {
        prefab = Resources.Load("Bullet") as GameObject;
    }

    public void MakeBullet(Vector2 initPos, Vector2 direction)
    {
        body = Object.Instantiate(prefab, initPos, new Quaternion(0, 0, 0, 0));
        body.GetComponent<Bullet>().SetDirection(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
