using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        bool alreadyTrigger = false;
        private void OnTriggerEnter(Collider other)
        {
            if (!alreadyTrigger && other.gameObject.tag == "Player")
            {
                alreadyTrigger = true;
                GetComponent<PlayableDirector>().Play();
            }
        }
    }

}