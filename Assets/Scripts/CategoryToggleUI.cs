using UnityEngine;

public class CategoryToggleUI : MonoBehaviour
{
    [SerializeField] private GameObject hatsCategory;
    [SerializeField] private GameObject bootsCategory;

    [SerializeField] private bool hatsOnAtStart = true;
    [SerializeField] private bool bootsOnAtStart = true;

    private void Start()
    {
        ToggleHats(hatsOnAtStart);
        ToggleBoots(bootsOnAtStart);
    }

    public void ToggleHats(bool isOn)
    {
        if (hatsCategory != null) hatsCategory.SetActive(isOn);
    }

    public void ToggleBoots(bool isOn)
    {
        if (bootsCategory != null) bootsCategory.SetActive(isOn);
    }
}