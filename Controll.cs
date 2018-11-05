using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // (Input.GetMouseButtonDown(0))
        //{
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                GameObject objectHit = hit.collider.gameObject;
                objectHit.GetComponent<HexScript>().StartHover();
                if (Input.GetMouseButtonDown(0))
                {
                    objectHit.GetComponent<HexScript>().SetColor(Random.ColorHSV());
                }
            }
        //}
    }

    void onHover()
    {

    }

    void onClick()
    {

    }

    void onScroll()
    {

    }
}
