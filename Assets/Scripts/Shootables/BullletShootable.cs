using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletShootable : Shootable
{
    GameObject prefab;
    //GameObject body;
    public bool hit;

    Bullet childBullet;

    public BullletShootable()
    {
        prefab = Resources.Load("Bullet") as GameObject;
    }

    public void MakeBullet(Vector2 initPos, Vector2 direction)
    {
        if (body == null)
        {
            body = Object.Instantiate(prefab, initPos, new Quaternion(0, 0, 0, 0));
            childBullet = body.GetComponent<Bullet>();
        }

        else
        {
            body.transform.position = initPos;
        }
        childBullet.SetStats(damage, speed);
        childBullet.SetDirection(direction);
    }

    public override void OnEnableObject()
    {
        base.OnEnableObject();
        if (childBullet != null)
            childBullet.hit = false;
    }



    // Update is called once per frame
    public void LogicUpdate()
    {
        hit = childBullet.hit;
    }
}
