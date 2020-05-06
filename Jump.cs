using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	[SerializeField] public float m_speed; 

	void Start()
	{

	}

	
	void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
				GetComponent<Rigidbody>().AddForce(Vector3.up * m_speed);
			}
		}
	}

