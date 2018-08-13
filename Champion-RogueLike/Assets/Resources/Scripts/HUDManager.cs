using UnityEngine;
using UnityEngine.UI;
using RoboRyanTron.Unite2017.Variables;

public class HUDManager : MonoBehaviour
{

	public FloatVariable hp;
	public FloatReference maxHp;
	public Text hpText;

	public FloatVariable rp;
	public FloatReference maxRp;
	public Text rpText;

	public Slider healthMeter;
	public Slider relicMeter;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		healthMeter.value = hp.Value / maxHp.Value;
		hpText.text = hp.Value.ToString() + "/" + maxHp.Value.ToString();

		relicMeter.value = rp.Value / maxRp.Value;
		rpText.text = rp.Value.ToString() + "/" + maxRp.Value.ToString();

	}
}
