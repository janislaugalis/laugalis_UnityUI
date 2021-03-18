using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ievade : MonoBehaviour {

    public string teksts;
    public GameObject vardaIevade;
    public GameObject vardaIzvade;
    public GameObject vecumaIevade;
    public GameObject vecumaIzvade;

    public void uzglabaVardu()
    {
        teksts = vardaIevade.GetComponent<Text>().text;
        vardaIzvade.GetComponent<Text>().text = "Personāža vārds: " + teksts;
    }
    public void uzglabaVecumu()
    {
        teksts = vecumaIevade.GetComponent<Text>().text;
        vecumaIzvade.GetComponent<Text>().text = "Personāža vecums: " + teksts;
    }
}
