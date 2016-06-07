using UnityEngine;
using System.Collections;

public class SmashTrapScript : MonoBehaviour {

    private bool isSmashing;
    private Vector3 originalPos;
    private Vector3 desiredPos;
	// Use this for initialization
	void Start () {
        isSmashing = true;
        originalPos = this.transform.position;
        desiredPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 3);

	}
	
    void Update()
    {
        if (isSmashing)
        {
            transform.position = Vector3.Lerp(originalPos, desiredPos, Time.deltaTime *5);
            if (this.transform.position == desiredPos)
            {
                isSmashing = false;
            }
        } else
        {
            transform.position = Vector3.Lerp(desiredPos, originalPos, Time.deltaTime * 4);
            if (this.transform.position == originalPos)
            {
                isSmashing = true;
            }
        }
    }
}
