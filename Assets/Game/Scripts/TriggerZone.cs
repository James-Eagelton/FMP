using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Trigger Tag")]
    public string triggerTag = "Player";
    
    [Header("Trigger Enter / Exit")]
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;

    private bool Triggered = false;

    private void OnDrawGizmos() 
    {
        if (Triggered)
        {
            Gizmos.color = Color.green;
        }
        else 
        {
            Gizmos.color = Color.red;  
        }
        Gizmos.DrawWireCube(this.gameObject.transform.position, this.gameObject.transform.localScale);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerTag != "")
        {
            if (other.tag == triggerTag)
            {
                Debug.Log("YEA");
                onTriggerEnter?.Invoke();
                Triggered = true;
            }
        }
        else 
        {
            Debug.Log("YEA");
            onTriggerEnter?.Invoke();
            Triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == triggerTag)
        {
            if (other.tag == triggerTag)
            {
                Debug.Log("NO");
                onTriggerExit?.Invoke();
                Triggered = false;
            }
        }
        else
        {
            Debug.Log("NO");
            onTriggerExit?.Invoke();
            Triggered = false;
        }
    }
}
