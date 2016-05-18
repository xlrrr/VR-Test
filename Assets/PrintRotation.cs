using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class PrintRotation : MonoBehaviour
    {
        public GameObject text;
        public GameObject text1;
        public GameObject head;
        
        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update ()
        {
            this.text.GetComponent<Text>().text = transform.rotation.eulerAngles.y.ToString();
            this.text1.GetComponent<Text>().text = head.transform.rotation.eulerAngles.y.ToString();
        }
    }
}
