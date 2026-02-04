using UnityEngine;
using System.Collections;
using Unity.Mathematics;
public class Hp : MonoBehaviour
{
    public int myHp = 100;
    private GameObject my;
    public bool isHurt = false;

    public float hurttime;

    private SpriteRenderer sr;
    Color halfA = new Color(1, 1, 1, 0);
    Color fullA = new Color(1, 1, 1, 1);
    void Start()
    {
        my = GetComponent<GameObject>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage)
    {
        if (!isHurt){
            isHurt = true;
            myHp -= damage;
            StartCoroutine(HurtRootine());
            StartCoroutine(blink());
            if (myHp < 0)
            {
                Debug.Log("»ç¸Á");
            }
        }
        
    }
    public IEnumerator HurtRootine()
    {
        yield return new WaitForSeconds(hurttime);
        isHurt=false;
    }
    public IEnumerator blink()
    {
        while (isHurt)
        {
            yield return new WaitForSeconds(0.1f);
            sr.color = halfA;
            yield return new WaitForSeconds(0.1f);
            sr.color = fullA;
        }
        sr.color = fullA;
    }
}
