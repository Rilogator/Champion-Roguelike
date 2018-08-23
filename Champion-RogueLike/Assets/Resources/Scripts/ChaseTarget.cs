using UnityEngine;

public class ChaseTarget : MonoBehaviour
{
	public Transform target;

	public int moveSpeed;
	public int maxDist;
	public int minDist;
		   	 
	void Start()
	{

	}

	void Update()
	{
		if (Vector2.Distance(transform.position, target.position) >= minDist)
		{

			transform.position += (target.position - transform.position).normalized
				* moveSpeed * Time.deltaTime;
		}
	}
}