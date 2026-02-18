using UnityEngine;
using UnityEngine.EventSystems;

public class UIDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    private Vector2 startPos;
    private Transform startParent;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>(); // pievienots
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = rectTransform.anchoredPosition;
        startParent = transform.parent;

        // Ļauj "izšaut cauri" raycast uz DropArea
        if (canvasGroup != null) canvasGroup.blocksRaycasts = false;

        // lai vilkšanas laikā objekts būtu virs pārējiem UI
        transform.SetParent(canvas.transform, true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (canvasGroup != null) canvasGroup.blocksRaycasts = true;

        // ja netika nomests Drop zonā, atgriežam atpakaļ
        if (transform.parent == canvas.transform)
        {
            transform.SetParent(startParent, true);
            rectTransform.anchoredPosition = startPos;
        }
    }
}