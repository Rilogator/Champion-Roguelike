using UnityEngine;
using UnityEngine.UI;
using RoboRyanTron.Unite2017.Variables;

public class HUDManager : MonoBehaviour
{

	public FloatVariable hp;
	public FloatVariable maxHp;

	public Slider healthMeter;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		healthMeter.value = hp.Value / maxHp.Value;
	}
}
