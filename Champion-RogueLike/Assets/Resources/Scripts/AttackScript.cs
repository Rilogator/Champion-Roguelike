using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class AttackScript : MonoBehaviour
{
	private Animator anim;
	private Rigidbody2D myBody;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
		//myBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			anim.SetTrigger("Attack");
		}
	}

	//public void StopMove()
	//{
	//	myBody.velocity = Vector2.zero;
	//}
}
