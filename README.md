Click the image below to watch a demo of the AircraftSimulation:
[![Watch the demo](Demo/demo-thumbnail.png)](Demo/demo.mp4)

# AircraftSimulation
Overview
AircraftSimulation is a Unity-based project designed to simulate the flight of an agricultural aircraft within a virtual environment. The simulation focuses on realistic physics-based flight mechanics, allowing users to experience the dynamics of flight and control the aircraft using motion controls.

This project is part of a VR flight simulation that integrates agricultural tasks with a focus on precision flight control. The simulation includes energy dynamics, utilizing both kinetic and potential energy to control various aspects of the aircraft's motion and orientation.

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
Convai package for VR interaction (optional but recommended)
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/Mohamed-Willy/AircraftSimulation.git
Open the project in Unity:

Launch Unity Hub.
Click on the Add button and navigate to the directory where the project is located.
Select the project and open it.
Import necessary packages:

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
Contributing
Contributions are welcome! Please follow these steps if you'd like to contribute:

Fork the repository.
Create a new branch for your feature or bugfix.
Submit a pull request with detailed information on your changes.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any inquiries or feedback, feel free to reach out via email.
