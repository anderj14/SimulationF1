# 🏎️ F1 Race Simulation in C#  

A console-based Formula 1 race simulation built in C#. This project simulates a single-lap race on a 4-kilometer track with real-time telemetry, overtakes, vehicle wear, and dynamic position tracking.

---

## 🚀 Features  

- **10 Drivers & Vehicles**:  
  Each driver has a unique car with specific performance attributes (speed, acceleration, and wear).  

- **Real-Time Updates**:  
  - Distance covered by each driver is updated in real time.  
  - Overtakes are logged dynamically as they happen.  
  - Telemetry data, including fastest lap information, is displayed live.  

- **Race Logic**:  
  - Drivers compete on a 4-kilometer track for a single lap.  
  - Vehicle performance decreases over time due to wear.  
  - Once a driver completes 4 km, they finish the race and their position is locked.  

- **Point System**:  
  The race awards points based on the finishing position:  
  - 1st place: 10 points  
  - 2nd place: 8 points  
  - 3rd place: 6 points  
  - 4th–10th place: 1 point each  

---

## 🛠️ Getting Started  

### Prerequisites  
- **.NET SDK 9.0 or later**  
- A text editor or IDE (e.g., Visual Studio, Visual Studio Code).  

### Installation  
1. Clone the repository:  
   ```bash
   git clone https://github.com/anderj14/SimulationF1
   cd f1-race-simulation
