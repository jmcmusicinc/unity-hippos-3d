using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public int Amount;
	
	public float Delay;
	
	public Transform Prefab;
	
	private int _current;
	
	void Start()
	{
		StartCoroutine("Spawn");
	}
	
	IEnumerator Spawn()
	{
		while(_current < Amount)
		{
			var o = Instantiate(Prefab, this.transform.position, Random.rotation);
			_current++;
			
			var ball = o as GameObject;
			if(ball != null && ball.rigidbody != null)
				ball.rigidbody.AddForce(ball.transform.position * 500, ForceMode.Impulse);
			
			yield return new WaitForSeconds(Delay);
		}
	}
}
