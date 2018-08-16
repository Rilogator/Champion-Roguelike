using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class DodgeScript : MonoBehaviour
{
	public FloatReference dashCD;
	public FloatReference dashTime;
	public FloatReference dashPower;

	//public float playerSpeed;

	private Animator anim;
	private Rigidbody2D body;

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
			anim.SetTrigger("Dodge");		
	}	

		//Needs testing
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
