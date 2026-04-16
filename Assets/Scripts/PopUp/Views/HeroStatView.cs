using TMPro;
using UnityEngine;

public class HeroStatView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moveSpeedValue;
    [SerializeField] private TextMeshProUGUI _staminaValue;
    [SerializeField] private TextMeshProUGUI _dexterityValue;
    [SerializeField] private TextMeshProUGUI _intelligenceValue;
    [SerializeField] private TextMeshProUGUI _damageValue;
    [SerializeField] private TextMeshProUGUI _regenerationValue;

    public void SetData(
        string moveSpeedValue,
        string staminaValue,
        string dexterityValue,
        string intelligenceValue,
        string damageValue,
        string regenerationValue
        )
    {
        _moveSpeedValue.text = moveSpeedValue;
        _staminaValue.text = staminaValue;
        _dexterityValue.text = dexterityValue;
        _intelligenceValue.text = intelligenceValue;
        _damageValue.text = damageValue;
        _regenerationValue.text = regenerationValue;

    }
}