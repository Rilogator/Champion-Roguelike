using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class AttackScript : MonoBehaviour
{
	private Animator anim;
	//private Rigidbody2D myBody;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			anim.SetTrigger("Attack");
		}
	}

	#region Animator Events

	public void ResetTrigger(string trigger)
	{
		anim.ResetTrigger(trigger);
	}

	public void SetCombo(bool state)
	{
		anim.SetBool("canCombo", state);
	}

	#endregion
}
