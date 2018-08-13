using UnityEngine;
using UnityEngine.Events;
using RoboRyanTron.Unite2017.Variables;
using RoboRyanTron.Unite2017.Events;

public class InputHandler : MonoBehaviour
{
	public UnityEvent AttackInputEvent;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
			AttackInputEvent.Invoke();
	}
}
