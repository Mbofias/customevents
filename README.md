To use this you can create Scriptable Object assets of Events.

Then you just need to add the event listener script to any gameobject that needs to do something when an event gets triggered. Adding a layer of abstraction and making it way easier to debug and update functionalities.

To make an easy example we will take account when the player HP changes.

  -We have an UI that reflects current player HP. </br>
  -We also have multiple AIs that change it's behaviour according to player's current HP. </br>
  -We create a scriptable object asset that it's an event called "UpdatePlayerHP". </br>
  -We add all of those objects an EventListener, that subscribes itself to the recently created "UpdatePlayerHP" scriptable object.(All of that can be done from      inspector) </br>
  -Now the player needs a reference to that event and trigger it whenever it's HP gets an update. </br>
  -Everyone that needs to check player HP will recieve a notification and execute it's own functionality. </br>

-This works pretty well with this referenced variables package: https://github.com/Mbofias/refvariables .

PS. This is my own approach to an idea I found on a youtube video about unity game architecture and abstraction using Scriptable Objects.
