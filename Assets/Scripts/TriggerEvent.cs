using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public string activateTag = "Player";
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerStay;
    public UnityEvent onTriggerExit;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == activateTag)
        {
            onTriggerEnter.Invoke();
            Debug.Log("Event Triggered");
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == activateTag)
            onTriggerStay.Invoke();
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == activateTag)
            onTriggerExit.Invoke();
    }
}
