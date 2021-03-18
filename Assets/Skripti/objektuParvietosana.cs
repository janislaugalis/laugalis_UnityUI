using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class objektuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
    private RectTransform transformacijuLogs;
    public Canvas kanva;
    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums)
    {
    }
    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnBeginDrag(PointerEventData notikums)
    {
    }
    public void OnEndDrag(PointerEventData notikums)
    {
    }
}
