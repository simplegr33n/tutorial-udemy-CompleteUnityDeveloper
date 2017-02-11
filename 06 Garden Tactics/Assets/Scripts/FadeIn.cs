using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    private float currentAlpha = 1f;

    public float alphaRate = 0.05f;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Darken", 0.1f, 0.1f);

    }

    void Update ()
    {
        if (currentAlpha <= 0f)
        {
            CancelInvoke("Darken");
        }
    }
	

	void Darken () {

        currentAlpha -= alphaRate;

        GetComponent<CanvasRenderer>().SetAlpha(currentAlpha);
    }
}
