using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform center;

    public Transform spawnpos;
    public float cooldown = 0.1f;

    void Update()
    {
        Lookmouse();
        shootbulet();
    }
    void shootbulet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, spawnpos.position, center.rotation);
        }
    }
    void Lookmouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint
            ((Vector2)Input.mousePosition);
        Vector2 dirVec = (mousePos - (Vector2)center.transform.position).normalized;

        center.transform.up = dirVec;
    }
}
