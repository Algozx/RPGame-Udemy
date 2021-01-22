using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;
using UnityEngine.Playables;
using UnityEngine.AI;
using RPG.Core;
using RPG.Control;

namespace RPG.Cinematics
{
    public class CinematiControlRemover : MonoBehaviour
    {
        GameObject player;
        private void Start()
        {
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;
            player = GameObject.FindWithTag("Player");
        }

        void DisableControl(PlayableDirector pd)
        {
            print("DisableControl");
            player.GetComponent<ActionScheduler>().CancelCurrentAction();
            player.GetComponent<PlayerController>().enabled = false;

        }

        void EnableControl(PlayableDirector pd)
        {
            print("EnableControl");
            player.GetComponent<PlayerController>().enabled = true;
        }
    }
}
