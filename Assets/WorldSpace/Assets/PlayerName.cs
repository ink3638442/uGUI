using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{ 
	[SerializeField]
	private Transform target;

	private Vector3 screenPoint;

	void LateUpdate()
	{
		screenPoint = Camera.main.WorldToScreenPoint(target.position);

		transform.position = new Vector3(screenPoint.x, screenPoint.y, 0);
	}
}
