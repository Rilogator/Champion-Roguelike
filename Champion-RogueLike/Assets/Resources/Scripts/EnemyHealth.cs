using UnityEngine;
using UnityEngine.Events;
using RoboRyanTron.Unite2017.Variables;


public class EnemyHealth : MonoBehaviour {

	private float HP;

	public bool ResetHP;
	public FloatReference StartingHP;
	public UnityEvent DamageEvent;
	public UnityEvent DeathEvent;

	private void Start()
	{
		if (ResetHP)
			HP = StartingHP;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		DamageDealer damage = other.gameObject.GetComponent<DamageDealer>();
		if (damage != null)
		{
			HP = Mathf.Max(0, HP - damage.DamageAmount);
			DamageEvent.Invoke();
		}

		if (HP <= 0.0f)
		{
			DeathEvent.Invoke();
		}
	}
}

