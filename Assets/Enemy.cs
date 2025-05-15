
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5; //zombie_0 intial health

    public GameObject deathEffect;
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Animator animator;
    private Transform currentPoint;
    public float speed = 5;
    private Vector2 screenBounds;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(speed, 0);
    }

    public void TakeDamage(int damage)
    {
        //health logic
        health -= damage;
        Debug.Log(gameObject.name + "took" + damage + "damage.Health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //death logic
        Debug.Log(gameObject.name + "has been destroyed.");
        Destroy(gameObject); //Destroy the gameObject when the health reaches zero 
    }

}
