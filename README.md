# OpenIGTLink-Client-Unity-XR

## Installation

### From Unity

This project has been tested with the Unity Editor LTS version 2022.3.20f1.

1. Install the corresponding editor version, ensuring the Android Build Support module with OpenJDK, and the Android SDK & NDK Tools are selected.
2. From the Editor, switch the platform to Android and build the app. Use your preferred method to install the APK on the headset.
3. Alternatively, you can follow the guide [here](https://developer.oculus.com/documentation/unity/unity-env-device-setup/#headset-setup) from the Oculus Developer documentation to "build and run" directly on the headset or install the APK via ADB.

### From the APK

The APK app is available for direct download in the repository's [releases](https://github.com/yanis-dubois/PFE_UnityPrototype/releases) section.

With the APK, you can follow the "Install APK via ADB" section of [this](https://developer.oculus.com/documentation/unity/unity-env-device-setup/#headset-setup) guide or use the Meta Quest Developer Hub app to install it.

## Usage

The OpenIGTLink connection operates as a client. Enter the server's IP address and port, if different from the default, in the menu to establish the connection.

### Object Manipulation

#### Opening the Menu

To access the menu, tilt your hand towards yourself to trigger its opening.

#### Controller Controls

- **Inner Triggers** : Use these triggers to grasp and move objects within reach.
- **Back Triggers** : Use these triggers to select items on the user interface or manipulate objects with rays.
- **'X' button** : Press 'X' to remove the grabbed item. 

#### Hand Controls

- **Ray Mode** :
  - Transition into ray mode by clawing your thumb and index.
  - Pinch gestures with the rays enable object grabbing or UI selection.
- **Direct Object Interaction**:
  - Directly pinching an object enables you to grab it for manipulation.
