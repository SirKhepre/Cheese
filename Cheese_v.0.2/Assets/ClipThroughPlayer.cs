﻿using UnityEngine;
using System.Collections;

public class ClipThroughPlayer : MonoBehaviour {
	void Update () {
		Physics.IgnoreCollision (this.GetComponent<Collider> (), GameObject.FindGameObjectWithTag ("Player").GetComponent<Collider> ());
	}
}
