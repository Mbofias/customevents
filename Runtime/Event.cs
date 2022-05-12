using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomEvents
{
    [CreateAssetMenu(menuName = "Event")]
    public class Event : ScriptableObject
    {
        /// <summary>
        /// Una lista con todos los Listeners a los que se les tiene que notificar de la ejecuci�n de este evento.
        /// </summary>
        protected readonly List<Listener> listeners = new List<Listener>();

        /// <summary>
        /// Esta funci�n se encarga de avisar a todos los Listeners suscritos cuando ocurre este evento.
        /// </summary>
        public void TriggerEvent()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnTrigger();
        }

        /// <summary>
        /// Con esta funci�n un listener puede suscribirse a este evento, para recibir una notificaci�n si este se activa.
        /// </summary>
        /// <param name="listener">El listener que quiere suscribirse al evento</param>
        public void AddListenerSubscription(Listener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        /// <summary>
        /// Con esta funci�n un listener puede anular su suscripci�n a este evento, para dejar de recibir sus notificaciones.
        /// </summary>
        /// <param name="listener">El listener que quiere anular su suscripci�n al evento</param>
        public void RemoveListenerSubscription(Listener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }
    }
}