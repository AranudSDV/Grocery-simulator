using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestImage : MonoBehaviour
{

    public Image image;
    public float vitesseRevelation = 1f;  
    private RectTransform rectTransform;
    private float largeurActuelle;
    private float largeurCible;

    void Start()
    {
        rectTransform = image.GetComponent<RectTransform>();
        largeurCible = rectTransform.rect.width;
        largeurActuelle = 0;
        
        // Assurez-vous que le pivot est à gauche
        rectTransform.pivot = new Vector2(0, 0.5f);

        // Initialisez la taille de l'image à 0 de largeur
        rectTransform.sizeDelta = new Vector2(largeurActuelle, rectTransform.sizeDelta.y);
    }

    void Update()
    {
        if (largeurActuelle < largeurCible)
        {
            largeurActuelle += vitesseRevelation * Time.deltaTime;
            largeurActuelle = Mathf.Min(largeurActuelle, largeurCible);
            rectTransform.sizeDelta = new Vector2(largeurActuelle, rectTransform.sizeDelta.y);
        }
        Debug.Log(largeurActuelle);
    }

}
