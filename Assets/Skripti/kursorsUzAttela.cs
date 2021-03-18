using UnityEngine;
using System.Collections;

public class kursorsUzAttela : MonoBehaviour {

    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;

    public void uzbiditsUzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNoietNoAttela()
    {
        skanasAvots.Stop();
    }
}
