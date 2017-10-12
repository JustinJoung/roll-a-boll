﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame, Late Update is guranteed to run even after all items have been processed
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
