using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomEvents
{
    [CreateAssetMenu(menuName = "Event")]
    public class Event : ScriptableObject
    {
        /// <summary>
        /// Una lista con todos los Listeners a los que se les tiene que notificar de la ejecución de este evento.
        /// </summary>
        protected readonly List<Listener> listeners = new List<Listener>();

        /// <summary>
        /// Esta función se encarga de avisar a todos los Listeners suscritos cuando ocurre este evento.
        /// </summary>
        public void TriggerEvent()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnTrigger();
        }

        /// <summary>
        /// Con esta función un listener puede suscribirse a este evento, para recibir una notificación si este se activa.
        /// </summary>
        /// <param name="listener">El listener que quiere suscribirse al evento</param>
        public void AddListenerSubscription(Listener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        /// <summary>
        /// Con esta función un listener puede anular su suscripción a este evento, para dejar de recibir sus notificaciones.
        /// </summary>
        /// <param name="listener">El listener que quiere anular su suscripción al evento</param>
        public void RemoveListenerSubscription(Listener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }
    }
}