using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Oculus;

namespace YourNamespace
{
    public class ResetButtton : MonoBehaviour
    {
        private OVRInput.Controller leftController;
        private OVRInput.Controller rightController;

        private void Start()
        {
            // Przypisz kontrolery Oculus Quest 2
            leftController = OVRInput.Controller.LTouch;
            rightController = OVRInput.Controller.RTouch;
        }

        private void Update()
        {
            // Sprawd�, czy u�ytkownik nacisn�� przycisk "X" na kontrolerze Oculus Quest 2 (lewy lub prawy)
            if (OVRInput.GetDown(OVRInput.Button.One, leftController) || OVRInput.GetDown(OVRInput.Button.One, rightController))
            {
                // Resetuj scen�
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            // Sprawd�, czy u�ytkownik nacisn�� klawisz "R" na klawiaturze
            if (Keyboard.current.rKey.wasPressedThisFrame)
            {
                // Resetuj scen�
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
