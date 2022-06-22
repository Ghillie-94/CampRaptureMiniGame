using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;

	private void Update()
	{
		transform.position = playerTransform.position + offset;
	}
}
