using UnityEngine;
using Cinemachine;
using RPG.Control;

namespace RPG.Core
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] GameObject freeLookCamera;
        CinemachineFreeLook freeLookComponent;
        PlayerController playerControllerScript;

        private void Awake()
        {
            freeLookComponent = freeLookCamera.GetComponent<CinemachineFreeLook>();
            playerControllerScript = GetComponent<PlayerController>();
        }

        private void Update(){
            
        }

    }
}