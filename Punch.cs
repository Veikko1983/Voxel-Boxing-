using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
	//public GameObject bullet;
	//public float speed = 5000f;
	public Animator m_Animator;
	void Start()
	{
		//m_Animator = GameObject.Find("Player").GetComponent<Animator>();
	}

	// Remember U Need a bullet and then EmptyGameObject to use this. U put this code to emptygameobject
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			//GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
			//Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
			//instBulletRigidbody.AddForce(Vector3.forward * speed);
			m_Animator.SetTrigger("Punch");
		}
	}
}
