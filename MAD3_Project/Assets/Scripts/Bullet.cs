using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 50;          // The speed of the bullet
    public Vector3 targetVector;    // the direction it travels
    public float lifetime = 10f;     // how long it lives before destroying
    public float damage = 10;       // how much damage this projectile causes

    void Start()
    {
        // find our RigidBody
        Rigidbody2D rb = gameObject.GetComponentInChildren<Rigidbody2D>();
        // add force 
        rb.AddForce(targetVector.normalized * speed);
        AudioManager.instance.PlaySound("laser"); //audio for shooting
    }


    // Update is called once per frame
    void Update()
    {
        // decrease our life timer
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            // we have ran out of life
            Destroy(gameObject);    // kill me
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IEntityHealth itd = collision.GetComponent<IEntityHealth>();
        if (itd != null)
        {
            itd.ITakeDamage(damage);
            lifetime = 0f;
        }

    }
}
