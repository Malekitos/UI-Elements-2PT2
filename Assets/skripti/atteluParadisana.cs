using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluParadisana : MonoBehaviour {

	public GameObject beensImg;
    public GameObject lacisImg;
    public GameObject masinaImg;
    public GameObject tanteImg;
    public GameObject kreisais;
    public GameObject labais;

    public void binaAttelosana(bool vertiba)
    {
        beensImg.SetActive(vertiba);
        kreisais.GetComponent<Toggle>().interactable = vertiba;
        labais.GetComponent<Toggle>().interactable = vertiba;
    }
    public void lasisAttelosana(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }
    public void masinaAttelsana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }
    public void tanteAttelosana(bool vertiba)
    {
        tanteImg.SetActive(vertiba);
    }

    public void paLabi(bool vertiba)
    {
        beensImg.transform.localScale = new Vector2(-1, 1);
    }

    public void paKreisi(bool vertiba)
    {
        beensImg.transform.localScale = new Vector2(1, 1);
    }

}
