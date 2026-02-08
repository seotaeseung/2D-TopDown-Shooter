using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject GameClear;
    void Awake()
    {
        Gameover.SetActive(false);
        GameClear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
