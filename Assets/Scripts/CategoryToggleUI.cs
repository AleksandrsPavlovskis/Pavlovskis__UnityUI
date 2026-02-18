using UnityEngine;
using UnityEngine.UI;

public class CategoryToggleUI : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] private Toggle hatsToggle;
    [SerializeField] private Toggle bootsToggle;

    [Header("Categories")]
    [SerializeField] private GameObject hatsCategory;
    [SerializeField] private GameObject bootsCategory;

    private void Start()
    {
        ApplyAll(); 
    }

    public void ApplyAll()
    {
        if (hatsCategory != null && hatsToggle != null)
            hatsCategory.SetActive(hatsToggle.isOn);

        if (bootsCategory != null && bootsToggle != null)
            bootsCategory.SetActive(bootsToggle.isOn);
    }

    public void OnHatsChanged(bool _) => ApplyAll();
    public void OnBootsChanged(bool _) => ApplyAll();
}