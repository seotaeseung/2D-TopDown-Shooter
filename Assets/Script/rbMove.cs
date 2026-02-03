using UnityEngine;

public class rbMove : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = 10;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Move(Vector2 direction)
    {
        if (direction.magnitude > 1)
            direction.Normalize();

        Vector2 movdir = rb.position + direction * speed * Time.fixedDeltaTime;

        rb.MovePosition(movdir);
    }

    public void SetVelocity(Vector2 direction)
    {
        rb.linearVelocity = direction.normalized * speed;
    }
}
