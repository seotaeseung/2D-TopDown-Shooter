using UnityEngine;

public class LookMouse : MonoBehaviour
{
    public Transform center;

    // Update is called once per frame
    void Update()
    {
        Lookmouse();
    }
    void Lookmouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint
            ((Vector2)Input.mousePosition);
        Vector2 dirVec = (mousePos - (Vector2)center.transform.position).normalized;

        center.transform.up = dirVec;
    }
}
