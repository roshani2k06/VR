using UnityEngine;

public class DoorScanner : MonoBehaviour
{
    public Animator animator;
    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen) return;

        Keycard card = other.GetComponent<Keycard>();

        if (card != null && card.isValid)
        {
            animator.SetTrigger("OpenDoor");
            isOpen = true;

            Debug.Log("Access Granted");
        }
    }
}