using UnityEngine;

public class Enemy : MonoBehaviour
{
    public rbMove rbmove;
    public Shoot shoot;

    private Vector2 targetpos;
    private Vector2 nextdir;

    private float attackrange = 3f;
    void Awake()
    {
        rbmove = GetComponent<rbMove>();
        shoot = GetComponentInChildren<Shoot>();
    }

    // Update is called once per frame
    void Update()
    {
        targetpos = GameObject.FindWithTag("Player").transform.position;
        nextdir = targetpos - (Vector2)transform.position;

        float angle = Mathf.Atan2(nextdir.y, nextdir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

        float range = Vector2.Distance(transform.position, targetpos);

        if(attackrange > range)
        {
            if(!shoot.isCooldown)
            {
                StartCoroutine(shoot.shootbullet());
            }
            rbmove.Move(Vector2.zero);
        }
        else
        {
            rbmove.Move(nextdir);
        }
        
    }
}
