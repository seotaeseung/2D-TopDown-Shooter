using UnityEngine;

public class Player : MonoBehaviour
{
    public rbMove rbmove;
    void Start()
    {
        
        rbmove = GetComponent<rbMove>();
    }

    
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rbmove.Move(new Vector2(x, y));
    }
    
}
