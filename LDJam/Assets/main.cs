using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {

    public Text workerCount, intellectCount;
    public Slider progressBar;
    public int bois;
    public static int rage = 100;

	// Use this for initialization
	void Start () {
        StartCoroutine("Ticks");

	}
	
	// Update is called once per frame
	void Update () {
        workerCount.text = Worker.population + " w";
        intellectCount.text = Intellect.population + " i";
        progressBar.value = rage / 100f;
    }

    IEnumerator Ticks()
    {
        while (true)
        {

            rage--;
            Worker.Add();
            Intellect.Add();


            yield return new WaitForSeconds(1f);
        }
    }
}
