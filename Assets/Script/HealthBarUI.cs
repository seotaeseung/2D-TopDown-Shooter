using UnityEngine;
using UnityEngine.UI;
public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Hp targetHp;
    void OnEnable()
    {
        targetHp.OnHpChanged += UpdateHpUI;
    }

    private void OnDisable()
    {
        targetHp.OnHpChanged -= UpdateHpUI;
    }
    private void UpdateHpUI(int currentHp, int maxHp)
    {
        hpSlider.value = (float)currentHp / maxHp;
    }

}
