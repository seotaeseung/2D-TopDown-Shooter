using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void inGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void inTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
