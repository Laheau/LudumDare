using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {


    public int bois;
	// Use this for initialization
	void Start () {
        StartCoroutine("WorkerTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WorkerTime()
    {
        while(true)
        {
            Worker.Add();
            Debug.Log(Worker.nb);
            yield return new WaitForSeconds(100 / Maison.workerHouse);
        }
    }

    IEnumerable Tick()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
        }
    }
}
