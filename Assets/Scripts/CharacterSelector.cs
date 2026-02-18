using UnityEngine;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Dropdown characterDropdown;
    [SerializeField] private TMP_Text descriptionText;

    [Header("Characters")]
    [SerializeField] private GameObject character1;
    [SerializeField] private GameObject character2;

    [TextArea(3, 8)]
    [SerializeField] private string character1Description = "Hero 1 apraksts...";
    [TextArea(3, 8)]
    [SerializeField] private string character2Description = "Hero 2 apraksts...";

    private void Start()
    {
        OnCharacterChanged(); // lai uzreiz uzliek pareizo stāvokli
    }

    public void OnCharacterChanged()
    {
        int index = characterDropdown.value;

        character1.SetActive(index == 0);
        character2.SetActive(index == 1);

        if (descriptionText != null)
        {
            descriptionText.text = (index == 0) ? character1Description : character2Description;
        }
    }
}