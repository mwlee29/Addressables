# Addressables
 
## Summary:

The Unity addressable system is a very powerful tool that can help with network delivery, flexible asset management, and memory optimization.

## Memory

Whenever a scene is loaded in Unity any prefabs that are attached to scripts or gameobjects in the Scene are loaded into memory, even if there is a chance that they won't be used. By using addressables, assets can be loaded and unloaded dynamically as the game progresses. This can be useful for optimizing performance on mobile devices. For games that contain multiple levels, assets can be pre loaded before the players enter a new level and unloaded as they exit the previous level.

## Network Delivery

By delivering content remotely, studios can focus on delivering content without the need for an excessive amount of client builds. Because of the way that Unity's addressable system works on references, designers can focus solely on improving assets without a need to edit the underlying code. Furthermore, network delivery can lead to smaller installations sizes and faster times. One thing I noticed is the flexibility in the delivery system. I have yet to test it, but I believe the profile system allows the developer to customize how content should be content should be delivered based on different platforms. For example, two different builds could be created for mobile and desktop devices. Since mobile devices are usually much less performant than desktops content could be delivered remotely, whereas the desktop build could store more data on the local machine.

## TODO:

This demo isn't fully complete yet, as I would still like to implement some features:
* Implement Remove Objects button
* Ensure Scene Data SO populates on initial load
* Ensure scenes are tied to the proper labels
* Clean up unused assets
