using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{//U need CharacterController to this Script
	[SerializeField] private string horizontalInputName;
	[SerializeField] private string verticalInputName;
	[SerializeField] private float MovementSpeed;

	private CharacterController m_cCont;

	private void Awake()
	{
		m_cCont = GetComponent<CharacterController>();
	}



	void Start()
    {
        
    }

   
   private void Update()
    {
		PlayerMovement();
    }
	private void PlayerMovement()
	{
		float horizInput = Input.GetAxis(horizontalInputName) * MovementSpeed;
		float vertInput = Input.GetAxis(verticalInputName) * MovementSpeed;

		Vector3 forwardMovement = transform.forward * vertInput;
		Vector3 rightMovement = transform.right * horizInput;

		m_cCont.SimpleMove(forwardMovement + rightMovement);
	}
}
