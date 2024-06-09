using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestImage : MonoBehaviour
{
    public Image image;  
    public float revealSpeed = 10f;  
    private RectTransform rectTransform;
    private float currentWidth;
    private float targetWidth;
    private bool isRevealing = false;

    void Start()
    {
        rectTransform = image.GetComponent<RectTransform>();
        targetWidth = rectTransform.rect.width; 
        currentWidth = 0;
        rectTransform.sizeDelta = new Vector2(currentWidth, rectTransform.sizeDelta.y);
    }

    void Update()
    {
        if (isRevealing)
        {
            currentWidth += revealSpeed * Time.deltaTime;
            //Debug.Log(currentWidth);
            if (currentWidth > targetWidth)
                currentWidth = targetWidth;
            rectTransform.sizeDelta = new Vector2(currentWidth, rectTransform.sizeDelta.y);
        }
        if(isRevealing == false)
        {
            currentWidth = 0;
            rectTransform.sizeDelta = new Vector2(currentWidth, rectTransform.sizeDelta.y);
            //rectTransform.sizeDelta = new Vector2(0,0);
        }
    }

    public void StartReveal()
    {
        isRevealing = true;
    }

    public void EndReveal()
    {
        isRevealing = false;
        Debug.Log("isReavling = false");
    }
}
