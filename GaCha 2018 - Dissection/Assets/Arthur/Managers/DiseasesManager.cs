using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DeathType { Peste, Variole, Syphilis, Lèpre, Ergotisme, Perforation_du_poumon, Perforation_du_cœur, Perforation_du_foie, Tuberculose, Noyade, Strangulation, Pendaison, Empoisonnementn, Arme_à_feu, Arme_blanche };

public class DiseasesManager : MonoBehaviour {

    public CardsManager cardManager;

    private void Start()
    {
        
    }

    public List<Disease> DiseaseList = new List<Disease>();
}
