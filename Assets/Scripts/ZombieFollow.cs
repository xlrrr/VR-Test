using UnityEngine;
using System.Collections;

public class ZombieFollow : MonoBehaviour {
    public GameObject target;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
