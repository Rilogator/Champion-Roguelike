using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class AttackSwitch : MonoBehaviour
{
	public bool isOn = false;

	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		DamageDealer damage = other.gameObject.GetComponent<DamageDealer>();
		if (damage != null)
		{
			isOn = !isOn;
			anim.SetTrigger("Toggle");
		}
	}
}
