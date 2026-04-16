using UnityEngine;
using UnityEngine.UI;

public class HeroXpBarView : MonoBehaviour
{
    [SerializeField] private Image _xpFill;

    public void SetSprites(Sprite fillSprite)
    {
        if (fillSprite != null)
            _xpFill.sprite = fillSprite;
    }
}