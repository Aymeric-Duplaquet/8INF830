﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    public GameObject parent;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider entity)
    {      
        //entity.gameObject.GetComponent<AsteroidsDesintegration>().health -= 5;
        Debug.Log(entity.gameObject.name);
        //Debug.Log(entity.gameObject.GetComponent<AsteroidsDesintegration>().health);
        //Destroy(gameObject)
        Entity temp = entity.GetComponentInParent<Entity>();
        if(temp != null)
        {
            temp.takeDammage(10);
            parent.GetComponent<OnHitColorChange>().OnHit();
        }
        
        Destroy(gameObject);
    }


    public void SetParent(GameObject _parent)
    {
        parent = _parent;
    }

}
