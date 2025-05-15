using UnityEngine;

public class CollisionAndDamage : MonoBehaviour
{
    public GameObject zombie_0;
    public string damagingTag = "Enemy";

    //When fireball collides with the enemy gets damaged
    void OnCollisionEnter2D(Collision2D other)
    {
        //if the object : fireball collides with the Object zombie_0, it takes damaged.
        if (other.gameObject.CompareTag(damagingTag))
        {
           other.gameObject.GetComponent<Enemy>().TakeDamage(2);
        }
        
        // "" in the () is the 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if using a trigger collider for damage
        if (other.CompareTag(damagingTag))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(2);
        }
    }

}
