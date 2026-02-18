using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    [SerializeField] private Slider heightSlider;
    [SerializeField] private Slider widthSlider;

    [SerializeField] private RectTransform character1;
    [SerializeField] private RectTransform character2;

    private RectTransform CurrentCharacter =>
        character1.gameObject.activeSelf ? character1 : character2;

    private void Start()
    {
        ApplyScale();
    }

    public void ApplyScale()
    {
        float w = widthSlider.value;
        float h = heightSlider.value;

        var target = CurrentCharacter;
        target.localScale = new Vector3(w, h, 1f);
    }
}