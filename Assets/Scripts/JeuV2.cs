using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;

    public int pointsJeu = 0;
    private int pointsParSeconde = 0;

    void Start()
    {
        pointsJeu = 0;
        InvokeRepeating("QuantiteAugmente", 4f, 5f);
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu+= 1+pointsParSeconde;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }
    void QuantiteAugmente()
    {
        pointsParSeconde +=1;
    }
}
    