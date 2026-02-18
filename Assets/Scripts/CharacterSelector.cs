using UnityEngine;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown characterDropdown;

    [SerializeField] private GameObject character1;
    [SerializeField] private GameObject character2;

    public void OnCharacterChanged()
    {
        int index = characterDropdown.value;

        character1.SetActive(index == 0);
        character2.SetActive(index == 1);
    }
}