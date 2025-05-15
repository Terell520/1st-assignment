using UnityEngine;
using System;
using System.Collections;
using static UnityEngine.EventSystems.EventTrigger;

public class Fire : MonoBehaviour
{
    public Transform firepoint;
    public Rigidbody2D rb;
    public float speed = 20f;
    public int damage = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire")) //Fire is the shoot button -> Space
        {
            launchProjectile();
        }
    }
    //Object in Instantiate knows GameObject, Transform)
    public GameObject FireballPrefab;
    public Transform Shootposition;
    public GameObject fireball;
    public void launchProjectile()
    {
        fireball = Instantiate(FireballPrefab, Shootposition.position , Quaternion.identity);
        Debug.Log("Fireball spawned at: " + FireballPrefab.transform.position);

        //Ensure the fireball has a Rigidbody2D and set's its Velocity
        Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = -transform.right * speed; //-transform makes object (fireball in this instance) mov
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("zombie_0"))// Fixed Syntax issue
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
