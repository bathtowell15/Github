using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

	void Update()
	{
		transform.Translate(-0.07f, 0, 0);
		if (transform.position.x < -15)
		{
			transform.position = new Vector3(15, 0, 0);
		}
	}
}

