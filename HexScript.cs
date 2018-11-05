using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexScript : MonoBehaviour {

    private bool shouldHover;
    private Vector3 startPos;
    private Vector3 endPos;
    private float offset;
    private float speed;
    private float timer;
    private float hoverTime;

    // Use this for initialization
	void Start () {
        startPos = gameObject.transform.position;
        offset = 1.0f;
        endPos = startPos;
        endPos.y += offset;
        shouldHover = false;
        speed = 0.1f;
        timer = 0.0f;
        hoverTime = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (shouldHover)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPos, speed);
            if(timer > hoverTime)
            {
                shouldHover = false;
            }
        }
        else
        {
            //if not startpos
            //goto startpos
            //else
            //shoulhover false
            if (transform.position != startPos) 
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, startPos, speed);
            }
        }
	}
    public void StartHover()
    {
        timer = 0.0f;
        shouldHover = true;
    }
    public void SetColor(Color aColor)
    {
        GetComponent<Renderer>().material.color = aColor;
    }
}
