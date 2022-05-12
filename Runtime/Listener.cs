using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CustomEvents
{
    public class Listener : MonoBehaviour
    {
        [Tooltip("El evento al que debe escuchar este listener.")]
        public Event target;

        [Tooltip("La respuesta producida al ocurrir el evento.")]
        public UnityEvent execution;

        private void OnEnable()
        {
            target.AddListenerSubscription(this);
        }

        private void OnDisable()
        {
            target.RemoveListenerSubscription(this);
        }

        public void OnTrigger()
        {
            execution.Invoke();
        }
    }
}