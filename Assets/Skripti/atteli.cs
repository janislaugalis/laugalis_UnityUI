using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class atteli : MonoBehaviour {
    public GameObject barda;
    public GameObject brilles;
    public GameObject kepons;
    public GameObject kepons2;
    public GameObject bardaToggle;
    public GameObject brillesToggle;
    public GameObject keponsToggle;
    public GameObject kepons2Toggle;
    public GameObject virietis;
    public GameObject sieviete;
    public GameObject GarumsSlider;
    public GameObject PlatumsSlider;

    public void uzliktBardu(bool vertiba)
    {
        barda.SetActive(vertiba);
    }
    public void uzliktBrilles(bool vertiba)
    {
        brilles.SetActive(vertiba);
    }
    public void uzliktKeponu(bool vertiba)
    {
        kepons.SetActive(vertiba);
    }
    public void uzliktKeponu2(bool vertiba)
    {
        kepons2.SetActive(vertiba);
    }
    public void chars(int skaitlis)
    {
        if (skaitlis == 0)
        {
            kepons2.SetActive(false);
            kepons2Toggle.SetActive(false);
            kepons2Toggle.GetComponent<Toggle>().isOn = false;
            sieviete.SetActive(false);
            virietis.SetActive(true);
            bardaToggle.SetActive(true);
            keponsToggle.SetActive(true);
            brillesToggle.SetActive(true);
            brillesToggle.GetComponent<Toggle>().isOn = true;
            mainitLielumu();
        } else if (skaitlis == 1)
        {
            barda.SetActive(false);
            bardaToggle.GetComponent<Toggle>().isOn = false;
            kepons.SetActive(false);
            keponsToggle.GetComponent<Toggle>().isOn = false;
            virietis.SetActive(false);
            bardaToggle.SetActive(false);
            keponsToggle.SetActive(false);
            brillesToggle.SetActive(true);
            brillesToggle.GetComponent<Toggle>().isOn = true;
            sieviete.SetActive(true);
            kepons2Toggle.SetActive(true);
            mainitLielumu();
        }
    }

    public void mainitLielumu()
    {
        float pasreizejaVertiba = GarumsSlider.GetComponent<Slider>().value;
        float pasreizejaVertiba2 = PlatumsSlider.GetComponent<Slider>().value;
        if (virietis.activeSelf) {
            virietis.transform.localScale = new Vector3(1f * pasreizejaVertiba2, 1f * pasreizejaVertiba, 1);
            virietis.transform.localScale = new Vector3(1f * pasreizejaVertiba2, 1f * pasreizejaVertiba, 1);

        } else if (sieviete.activeSelf)
        {
            sieviete.transform.localScale = new Vector3(1f * pasreizejaVertiba2, 1f * pasreizejaVertiba, 1);
            sieviete.transform.localScale = new Vector3(1f * pasreizejaVertiba2, 1f * pasreizejaVertiba, 1);
        }
    }
}
