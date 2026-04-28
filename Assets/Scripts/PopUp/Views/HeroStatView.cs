using System.Data;
using System.Globalization;
using PopUp;
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

    public void SetData(StatsData data)
    {
        _moveSpeedValue.text = data.MoveSpeed.ToString();
        _staminaValue.text = data.Stamina.ToString();
        _dexterityValue.text = data.Dexterity.ToString();
        _intelligenceValue.text = data.Intelligence.ToString();
        _damageValue.text = data.Damage.ToString();
        _regenerationValue.text = data.Regeneration.ToString();

    }
}