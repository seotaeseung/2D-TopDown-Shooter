using UnityEngine;
using System.Collections;
public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform center;

    public Transform spawnpos;

    public bool isCooldown = false;
    public float coolTime = 1.0f;

    public IEnumerator shootbullet()
    {
        isCooldown = true;
        Instantiate(bullet, spawnpos.position, center.rotation);
        yield return new WaitForSeconds(coolTime);
        isCooldown = false;
    }
    
}
