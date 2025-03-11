using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class NewMonoBehaviourScript : MonoBehaviour
{
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
        Debug.Log("YEA");
        onTriggerEnter?.Invoke();
        Triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("NO");
        onTriggerExit?.Invoke();
        Triggered = false;
    }
}
