using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursorsUzAttela : MonoBehaviour {

	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanet;

	public void uzbiditsUzAttela() {
		skanasAvots.PlayOneShot(skanaKoAtskanet);
	}

	public void kursorsNost() {
		skanasAvots.Stop();
	}
}
