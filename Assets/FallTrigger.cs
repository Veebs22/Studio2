using UnityEngine;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public bool isPinFallen = false;
    public UnityEvent OnPinFall = new();
    // Update is called once per frame
    private void OnTriggerEnter(Collider triggeredObject) {
        if (triggeredObject.CompareTag("Ground") && !isPinFallen) {
            isPinFallen = true;
            OnPinFall?.Invoke();

            Debug.Log($"{gameObject.name} is fallen");
        }
   
    }
}
