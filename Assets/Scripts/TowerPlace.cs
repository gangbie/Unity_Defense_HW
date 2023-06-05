using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Color normal;
    [SerializeField] Color onMouse;

    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left button clicked");
        }
        else if(eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right button clicked");
        }
        else
        {
            Debug.Log("Middle Button clicked");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        render.material.color = normal;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        render.material.color = onMouse;
    }
}
