# AircraftSimulation
Overview
AircraftSimulation is a Unity-based project designed to simulate the flight of an agricultural aircraft within a virtual environment. The simulation focuses on realistic physics-based flight mechanics, allowing users to experience the dynamics of flight and control the aircraft using motion controls.

This project is part of a VR flight simulation that integrates agricultural tasks with a focus on precision flight control. The simulation includes energy dynamics, utilizing both kinetic and potential energy to control various aspects of the aircraft's motion and orientation.

You can see a demo here: https://youtube.com/shorts/qVUUSc7cQdY?feature=share

Features
Realistic Flight Physics: Simulates true-to-life aircraft flight dynamics, incorporating forces like lift, drag, and gravity.
Energy-Based Controls:
Kinetic Energy for Motion: The aircraft’s speed and direction are controlled by the amount of kinetic energy generated.
Potential Energy for Orientation: The aircraft’s pitch (up/down orientation) is controlled by potential energy, which is influenced by the user’s head movement.
VR Interaction: Fully supports virtual reality interaction using XR (Extended Reality) devices and sliders for precise control.
Agricultural Tasks: The aircraft is designed to handle agricultural spraying tasks, adding an additional layer of challenge to the flight simulation.
Customizable Settings: Modify parameters like flight speed, altitude, and energy dynamics to tailor the experience to your needs.
Getting Started
Prerequisites
Unity version: 2022.3.47f1-x86_64 (or later)
VR headset compatible with Unity XR (e.g., Oculus, HTC Vive)
Installation

Ensure you have the required XR and physics packages installed. Unity will prompt you if any dependencies are missing.
Controls
Kinetic Energy (Motion): Adjust the aircraft’s speed and direction by interacting with the XR sliders designed for flight control.
Potential Energy (Pitch Control): Rotate the aircraft by adjusting the head orientation to simulate changes in altitude.
Agricultural Tasks: Control the aircraft while performing spraying tasks, requiring precise control and coordination.
How It Works
The aircraft's movement and orientation are governed by physics-based energy calculations:

Kinetic Energy: Dictates the forward motion and speed of the aircraft, simulating real-world flight dynamics.
Potential Energy: Simulates altitude adjustments by controlling the aircraft’s vertical orientation, allowing users to mimic pitch changes using head tracking.
The XR sliders allow for intuitive control over these energies, giving users precise input for navigation.

Project Structure
bash
Copy code
|-- AircraftSimulation/
    |-- Assets/         # Unity project assets
    |-- ProjectSettings/ # Unity project settings
    |-- XRControls/      # Scripts related to XR and slider-based controls
    |-- FlightPhysics/   # Scripts governing kinetic and potential energy dynamics
    |-- AgriculturalTasks/ # Scripts handling agricultural task simulation
Future Plans
Integrate more complex agricultural tasks, such as crop dusting and field surveying.
Improve visual feedback and aircraft handling physics.
Enhance compatibility with additional VR headsets and controllers.
