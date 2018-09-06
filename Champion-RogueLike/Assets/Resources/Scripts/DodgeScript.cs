using UnityEngine;
using System.Collections;

using RoboRyanTron.Unite2017.Variables;

public class DodgeScript : MonoBehaviour
{
	public FloatReference dashCD;
	public FloatReference dashTime;
	public FloatReference dashPower;
	
	private Animator anim;
	private Rigidbody2D body;

	//This variable is the exact duration of the roll animation
	private float rollTime = 0.417f;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
		body = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			anim.SetTrigger("Dodge");
			//StartCoroutine(dodgeInvulnerability());
		}
	}

	//invincibility frames
	IEnumerator dodgeInvulnerability()
	{
		gameObject.GetComponent<CircleCollider2D>().enabled = false;
		yield return new WaitForSeconds(rollTime);
		gameObject.GetComponent<CircleCollider2D>().enabled = true;
	}

	//Dodge Methods for Animator
	public void DodgeUp()
	{
		body.AddForce(transform.up * dashPower);
	}

	public void DodgeRight()
	{
		body.AddForce(transform.right * dashPower);
	}

	public void DodgeDown()
	{
		body.AddForce(-transform.up * dashPower);
	}

	public void DodgeLeft()
	{
		body.AddForce(-transform.right * dashPower);
	}
}
