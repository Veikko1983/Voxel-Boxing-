using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTriggerEnemy : MonoBehaviour
{

	public bool isDamaging;
	public float damage = 10;

	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Enemy")
			col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
	}

	void Start()
	{

	}


	void Update()
	{

	}
}