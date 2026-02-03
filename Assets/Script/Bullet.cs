using UnityEngine;

public class Bullet : MonoBehaviour
{
    private rbMove rbmove;
    void Start()
    {
        rbmove = GetComponent<rbMove>();
        rbmove.SetVelocity(transform.up);
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
