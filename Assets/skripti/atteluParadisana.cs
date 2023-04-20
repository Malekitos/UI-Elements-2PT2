using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atteluParadisana : MonoBehaviour {

	public GameObject beensImg;
    public GameObject lacisImg;
    public GameObject masinaImg;
    public GameObject tanteImg;

    public void binaAttelosana(bool vertiba)
    {
        beensImg.SetActive(vertiba);
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

}
