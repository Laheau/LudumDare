using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {

    public Text madness, workerCount, intellectCount;
    public int bois;
    public static int rage = 100;

	// Use this for initialization
	void Start () {
        StartCoroutine("Ticks");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Ticks()
    {
        while (true)
        {

            rage--;
            madness.text = rage + "%";
            Worker.Add();
            Intellect.Add();
            workerCount.text = Worker.population + " w";
            intellectCount.text = Intellect.population + " i";


            yield return new WaitForSeconds(1f);
        }
    }
}
