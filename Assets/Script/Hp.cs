using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class Hp : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;
    public bool isHurt = false;

    public float hurttime;

    public event Action<int, int> OnHpChanged;

    private SpriteRenderer sr;
    Color halfA = new Color(1, 1, 1, 0.5f);
    Color fullA = new Color(1, 1, 1, 1);

    public GameManagerUI Gameovermanager;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentHp = maxHp;
        
    }

    public void TakeDamage(int damage)
    {
        if (!isHurt){
            currentHp -= damage;
            OnHpChanged?.Invoke(currentHp, maxHp);
            isHurt = true;
            if (currentHp <= 0)
            {
                Die();
                return;
            }
            StartCoroutine(HurtRootine());
            StartCoroutine(blink());
            
        }
    }
    public void Die()
    {
        StopAllCoroutines();
        sr.color = fullA;

        if (GetComponent<Collider2D>() != null) GetComponent<Collider2D>().enabled = false;

        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("플레이어 사망: 게임 오버 UI 출력");
            // 게임을 일시정지 시킵니다.
            Time.timeScale = 0;

            Gameovermanager = FindAnyObjectByType<GameManagerUI>();
            Gameovermanager.Gameover.SetActive(true); 
        }
        else
        {
            Debug.Log("적 사망: 오브젝트 비활성화");
            gameObject.SetActive(false);
            Gameovermanager = FindAnyObjectByType<GameManagerUI>();
            Gameovermanager.GameClear.SetActive(true);
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
