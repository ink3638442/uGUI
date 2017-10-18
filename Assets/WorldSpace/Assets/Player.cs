using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float duration = 0.4f;

	public void MoveX (float distance)
	{
		StartCoroutine(MoveXCoroutine(distance));
	}

	IEnumerator MoveXCoroutine(float distance)
	{
		float currentX = transform.position.x;
		float targetX = currentX + distance;
		float startTime = Time.time;
		float t = 0;

		while (t < 1.0f)
		{
			t = (Time.time - startTime) / duration;
			transform.position = new Vector3(Mathf.SmoothStep(currentX, targetX, t), 0, 0);
			yield return 0;
		}
	}
}
