using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IPoolable
{
    public GameObject body;

    public int baseHealth;
    public int health;
    public bool active { get; set; }

    public bool alive;

    public void OnEnableObject()
    {
        alive = true;
        health = baseHealth;
    }
    public void OnDisableObject()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        health = baseHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void ChangeHealth(int _change)
    {
        health -= _change;
    }

    void Die()
    {
        alive = false;
    }
}
