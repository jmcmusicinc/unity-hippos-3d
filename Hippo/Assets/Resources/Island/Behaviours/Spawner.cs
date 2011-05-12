using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Transform))]
public class Spawner : MonoBehaviour {
	
	public int Amount;
	
	public float Delay;
	
	public Transform Original;
	
	private int _current = 0;
	
	void Start()
	{
		Spawn(Original, this.transform.position, Quaternion.identity);
	}
	
	IEnumerator Spawn(Object entity, Vector3 location, Quaternion rotation)
	{
		print("Spawn");
//		while(_current < Amount)
//		{
//			Instantiate(entity, location, rotation);
//			_current++;
		yield return new WaitForSeconds(Delay);
//		}
	}
	
}
