using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Shootable
{

    public Vector2 direction;
    public float speed;

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = (new Vector2(transform.position.x, transform.position.y) + direction * speed * Time.deltaTime) - new Vector2(transform.position.x, transform.position.y);

        transform.position = new Vector2(transform.position.x, transform.position.y) + direction * speed * Time.deltaTime;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.tag == "Enemy")
        {
            //attack that shit
            collision.gameObject.GetComponent<Enemy>().ChangeHealth(damage);
        }
        Destroy(this.gameObject);
    }

    public void SetDirection(Vector2 _newDir)
    {
        direction = _newDir;
    }
}
