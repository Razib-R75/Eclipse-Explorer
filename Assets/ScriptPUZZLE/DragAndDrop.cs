using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Vector2 initialPosition;
    private GameObject dropTarget;

    public string expectedTag; // Specify the expected tag for the drop target.

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        initialPosition = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rectTransform.SetAsLastSibling(); // Bring the dragged object to the front.
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / transform.lossyScale.x;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (dropTarget != null && dropTarget.CompareTag(expectedTag))
        {
            // Snap to the drop target's position.
            rectTransform.anchoredPosition = dropTarget.GetComponent<RectTransform>().anchoredPosition;
        }
        else
        {
            // Return to the initial position if not dropped on the correct target.
            rectTransform.anchoredPosition = initialPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(expectedTag))
        {
            dropTarget = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == dropTarget)
        {
            dropTarget = null;
        }
    }
}
