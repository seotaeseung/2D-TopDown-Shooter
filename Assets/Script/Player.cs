using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public rbMove rbmove;
    public Shoot shoot;

    
    void Start()
    {
        rbmove = GetComponent<rbMove>();
        shoot = GetComponentInChildren<Shoot>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !shoot.isCooldown) 
        {
            StartCoroutine(shoot.shootbullet());
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rbmove.Move(new Vector2(x, y));
    }
    
}
