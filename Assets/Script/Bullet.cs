using UnityEngine;

public class Bullet : MonoBehaviour
{
    private rbMove rbmove;
    public string targetTag;
    public int Damage = 10;
    void Start()
    {
        rbmove = GetComponent<rbMove>();
        rbmove.SetVelocity(transform.up);
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            collision.GetComponent<Hp>().TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
