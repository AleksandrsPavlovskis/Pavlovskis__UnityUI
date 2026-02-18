using TMPro;
using UnityEngine;

public class CharacterInfoUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField birthYearInput;
    [SerializeField] private TMP_Text resultText;

    public void Apply()
    {
        string characterName = nameInput.text.Trim();

        if (string.IsNullOrEmpty(characterName))
        {
            resultText.text = "Lūdzu ievadi tēla vārdu!";
            return;
        }

        if (!int.TryParse(birthYearInput.text, out int birthYear))
        {
            resultText.text = "Lūdzu ievadi dzimšanas gadu (tikai skaitļus)!";
            return;
        }

        int currentYear = System.DateTime.Now.Year;
        int age = currentYear - birthYear;

        if (birthYear < 1900 || birthYear > currentYear)
        {
            resultText.text = "Dzimšanas gads nav korekts!";
            return;
        }

        resultText.text = $"Supervaronis {characterName} ir {age} gadus vecs!";
    }
}
