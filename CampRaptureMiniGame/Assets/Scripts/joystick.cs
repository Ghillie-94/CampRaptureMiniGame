using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    private Image backGrdBox;
    private Image joystickIcon;
   

    public Vector2 InputDirection { set; get; }

    private void Start()
    {
        backGrdBox = GetComponent<Image>();
        joystickIcon = transform.GetChild(0).GetComponent<Image>();
        InputDirection = Vector2.zero;
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos = Vector2.zero;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle
            (backGrdBox.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / backGrdBox.rectTransform.sizeDelta.x);
            pos.y = (pos.y / backGrdBox.rectTransform.sizeDelta.y);

            float x = (backGrdBox.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (backGrdBox.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            InputDirection = new Vector2(x, y);

            // if vector is > 1 : normalise
            InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;

            //move joystick icon relative to input direction
            joystickIcon.rectTransform.anchoredPosition = new Vector2(InputDirection.x * (backGrdBox.rectTransform.sizeDelta.x / 3),
                InputDirection.y * (backGrdBox.rectTransform.sizeDelta.y / 3));

            
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        //call onDrag function, onPointer down event, passing in pointer event data
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        //snap joystick icon back into place
        //make input 0
        InputDirection = Vector2.zero;
        //reset image to original position
        joystickIcon.rectTransform.anchoredPosition = Vector2.zero;
    }

    
}
