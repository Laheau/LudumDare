using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {

    public Text workerCount, intellectCount, tbois, tmetal;
    public Slider progressBar;
    public static int bois, metal;
    public static float rage = 100;
    int time = 0;

	// Use this for initialization
	void Start () {
        StartCoroutine("Ticks");

	}
	
	// Update is called once per frame
	void Update () {
        workerCount.text = "Sacrifie Worker (" + Worker.population + ")";
        intellectCount.text = "Sacrifie Intellect (" + Intellect.population + ")";
        tbois.text = bois + " bois";
        tmetal.text = metal + " metals";
        progressBar.value = rage / 100f;
    }

    IEnumerator Ticks()
    {
        while (true)
        {
            time++;
            TakeDamages(time);
            Worker.Tick();
            Intellect.Tick();
        

            yield return new WaitForSeconds(1f);
        }
    }

    void TakeDamages(int time)
    {
        if(time < 40)
        {
            rage = rage - 0.5f;
        }
        else if(time >= 40)
        {
            rage = rage - 1;
        }
    }
}
