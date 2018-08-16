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

	//We might need a container variable to hold the player's pre-dodge speed.
	//Further testing needed.

		//Don't do this.
	public void DodgeSpeed()
	{
		body.velocity *= 1.20f;
	}

	public void ReturnNormalSpeed()
	{
		//Subtract dashPower from PlayerSpeed.
	}
}
