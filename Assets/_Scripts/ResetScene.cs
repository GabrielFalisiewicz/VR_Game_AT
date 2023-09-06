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
            // SprawdŸ, czy u¿ytkownik nacisn¹³ przycisk "X" na kontrolerze Oculus Quest 2 (lewy lub prawy)
            if (OVRInput.GetDown(OVRInput.Button.One, leftController) || OVRInput.GetDown(OVRInput.Button.One, rightController))
            {
                // Resetuj scenê
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            // SprawdŸ, czy u¿ytkownik nacisn¹³ klawisz "R" na klawiaturze
            if (Keyboard.current.rKey.wasPressedThisFrame)
            {
                // Resetuj scenê
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
