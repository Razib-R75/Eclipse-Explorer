using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleQ : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
       private Vector2 offset;
       private bool isDragging = false;
      
        public void OnBeginDrag(PointerEventData eventData)
        {
            // Calculate the offset from the mouse position to the object's position
            offset = (Vector2)transform.position - eventData.position;
            isDragging = true;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (isDragging)
            {
                // Update the object's position based on the mouse position and offset
                transform.position = eventData.position + offset;
                
                 
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            // Perform any actions when the drag ends (e.g., snapping to a grid)
            isDragging = false;
        }
   
}
