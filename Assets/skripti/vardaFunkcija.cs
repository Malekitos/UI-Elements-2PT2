﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vardaFunkcija : MonoBehaviour {

	public string teksts;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	private string[] fragmenti = {"Sveiks","Jauku dienu","Negribu tevi redzet!","Katisj ot sjuda"};
	int indekss;
	public void UzglabaTekstu() {
		indekss = Random.Range(0,fragmenti.Length);
		teksts = ievadesLauks.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss]+" "+teksts.ToUpper()+"!";
	}


	}

