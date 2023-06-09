using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TexthighlightController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] GameObject highlight;
    [SerializeField] GameObject inventario;
    [SerializeField] GameObject habilidade;
    [SerializeField] Color HightlightColor;
    [SerializeField] Color DefaultColor;

    Text text;
    RectTransform highlightRect;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        highlightRect = highlight.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        text = GetComponent<Text>();
        text.color = DefaultColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        highlightRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        highlight.SetActive(true);
        text.color = HightlightColor;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        highlight.SetActive(false);
        text.color = DefaultColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "inventario")
        {
            inventario.SetActive(true);
            habilidade.SetActive(false);
        }
        else if (gameObject.name == "habilidade")
        {
            habilidade.SetActive(true);
            inventario.SetActive(false);
        }
    }
}
