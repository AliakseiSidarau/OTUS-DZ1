using PopUp;
using UnityEngine;
using UnityEngine.UI;

public class HeroXpBarView : MonoBehaviour
{
    [SerializeField] private Image _xpFill;

    public void SetSprites(XpData data)
    {
        _xpFill.sprite = data.Xp;
    }
}