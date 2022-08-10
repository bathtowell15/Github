using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
	
	void Start()
	{
		
	}

	void Update()
	{
		//“G‚ÌˆÚ“®
		transform.position -= new Vector3(5*Time.deltaTime, 0, 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
	
		Destroy(gameObject);
		Destroy(collision.gameObject);

		SceneManager.LoadScene("GameOver");
	}

}
