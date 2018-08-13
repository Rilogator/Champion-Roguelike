using UnityEngine;
using UnityEngine.Events;
using RoboRyanTron.Unite2017.Variables;
using RoboRyanTron.Unite2017.Events;

public class AttackScript : GameEventListener
{
	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Attack()
	{
		anim.SetTrigger("Attack");

	}
}
