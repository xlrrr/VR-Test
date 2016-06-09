using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class FPSCameraController : MonoBehaviour
{
    public GameObject head;
    public GameObject deathScreen;
    public GameObject credits;
    public GameObject creditsParticle;
    public AudioClip deadSound;
    public AudioSource mainMusic;

    private bool IsDead;
    // Use this for initialization
    void Start()
    {
        IsDead = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Contains("Trap"))
        {
            Debug.Log("DEAD");
            this.mainMusic.volume = 0.4f;
            Invoke("PlayDeadSound", 1);
            this.deathScreen.gameObject.SetActive(true);
            this.TurnMovementOff();
            switch (col.gameObject.tag)
            {
                case "SmashTrap":
                    this.GetComponent<Animation>().Play("smashTrapDeath");
                    break;
                case "DoorTrap":
                    this.GetComponent<Animation>().Play("doorTrapDeath");
                    break;
                case "PitTrap":
                    this.GetComponent<Animation>().Play("pitTrapDeath");
                    break;
            }
        }
        if (col.gameObject.tag == "EndGame")
        {
            this.TurnMovementOff();
            this.credits.SetActive(true);
            this.creditsParticle.SetActive(true);
        }
    }
   void TurnMovementOff()
    {
        this.GetComponent<FirstPersonController>().enabled = false;
        this.GetComponent<Cardboard>().enabled = false;
        this.head.GetComponent<CardboardHead>().enabled = false;
    }

    void PlayDeadSound()
    {
        if (!IsDead)
        {
            IsDead = true;
            AudioSource.PlayClipAtPoint(deadSound, this.transform.position);
        }
    }
}


