using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
	NavMeshAgent nm;
	public Transform target;
	public enum AIState { idle, chasing };
	public float distanceThreshold = 10f;
	static Animator m_anim;
	public AIState aiState = AIState.idle;

	void Start()
    {
		nm = GetComponent<NavMeshAgent>();
		StartCoroutine(Think());
		m_anim = GetComponent<Animator>();
	


    }

    
    void Update()
    {

	}
	IEnumerator Think()
	{
		while (true)
		{
			switch (aiState)
			{
				case AIState.idle:
					float dist = Vector3.Distance(target.position, transform.position);
					if(dist < distanceThreshold)
					{
						m_anim.SetBool("IsWalking", true);
						aiState = AIState.chasing;
					}
					nm.SetDestination(transform.position);
					break;
				case AIState.chasing:
					dist = Vector3.Distance(target.position, transform.position);
					if (dist > distanceThreshold)
					{
						m_anim.SetBool("IsWalking", false);
						aiState = AIState.idle;
					}
					nm.SetDestination(target.position);
					break;
				default:
					break;
			}
			
			yield return new WaitForSeconds(0.2f);
		}
	}
}
