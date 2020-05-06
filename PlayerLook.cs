using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{//Add this to Camera

	[SerializeField] private string mouseXInputName, mouseYInputName;
	[SerializeField] private float m_sensib;

	[SerializeField] private Transform m_pBody;

	private float xAxisClamp;


	private void Awake()
    {
		xAxisClamp = 0.0f;
    }

    
    void Update()
    {
		CameraRotation();
    }

	private void CameraRotation()
	{
		float mouseX = Input.GetAxis(mouseXInputName) * m_sensib * Time.deltaTime;
		float mouseY = Input.GetAxis(mouseYInputName) * m_sensib * Time.deltaTime;

		xAxisClamp += mouseY;
		
			if(xAxisClamp > 90.0f)
		{
			xAxisClamp = 90.0f;
				mouseY = 0.0f;
			ClampAxisRotationToValue(270.0f);
		}

		else if (xAxisClamp < -90.0f)
		{
			xAxisClamp = -90.0f;
			mouseY = 0.0f;
			ClampAxisRotationToValue(90.0f);
		}




		transform.Rotate(Vector3.left * mouseY);
		m_pBody.Rotate(Vector3.up * mouseX);
	}
	private void ClampAxisRotationToValue(float value)
	{
		Vector3 eulerRotation = transform.eulerAngles;
		eulerRotation.x = value;
		transform.eulerAngles = eulerRotation;
	}
}
