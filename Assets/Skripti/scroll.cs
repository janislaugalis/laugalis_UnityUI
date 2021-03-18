using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {
    public GameObject virietis;
    public GameObject sieviete;
    public GameObject scrollV;
    public GameObject scrollS;

    public void scrolls()
    {
        if (virietis.activeSelf)
        {
            scrollS.SetActive(false);
            scrollV.SetActive(true);
        } else if (sieviete.activeSelf)
        {
            scrollV.SetActive(false);
            scrollS.SetActive(true);
        }
    }
}
