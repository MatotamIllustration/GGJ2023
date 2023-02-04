using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : IPoolable
{
    public GameObject body;
    public bool active { get; set; }

    public int damage;
    public float speed;

    public void SetStats(int _damage, float _speed)
    {
        damage = _damage;
        speed = _speed;
    }

    public virtual void OnEnableObject()
    {
        if (body != null)
            body.SetActive(true);
    }
    public virtual void OnDisableObject()
    {
        if (body != null)
            body.SetActive(false);
    }

}
