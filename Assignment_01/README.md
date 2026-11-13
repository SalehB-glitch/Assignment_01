# 2D Coin Collector Game

A 2D Unity game developed to demonstrate core game engine mechanics, physics-based movement, and dynamic object instantiation. The player navigates a 2D space to collect randomized coin batches while avoiding a continuously tracking enemy.

## 🎮 Gameplay Mechanics
* **Physics-Based Movement:** Both the player and enemy utilize `Rigidbody2D` and `FixedUpdate` for smooth, framerate-independent physics calculations.
* **Vector Tracking:** The enemy utilizes vector normalization to calculate real-time directional pathing toward the player's position.
* **Dynamic Instantiation:** A custom spawner randomly generates batches of coins from customized prefabs within a defined coordinate range.
* **Trigger Collision:** Utilizes Unity's `OnTriggerEnter2D` and Tag system to manage interactions (coin collection, score updates, and enemy collision) without physical pushback.

## 🛠️ Technical Implementation
* **Language:** C#
* **Engine:** Unity (2D Universal Render Pipeline)
* **Core Concepts:** Object-Oriented Programming, Physics Vectors, Prefabs, Collision Matrices, Game State Management.

## 📋 Features
| Component | Behavior |
| :--- | :--- |
| **Player (White Capsule)** | Controlled via WASD/Arrow keys. Must reach the target score (1000 points) to win. |
| **Enemy (Red Capsule)** | Constantly calculates the shortest vector to the player. Triggers a "Game Over" state upon collision. |
| **Coin Spawner** | Generates batches of 5 coins at random `(x, y)` coordinates. Spawns a new batch only when the current batch is cleared. |
| **Coin Types** | Orange (50 pts), Green (20 pts), Blue (10 pts). Chosen dynamically at runtime. |

## 👨‍💻 Authors
**Saleh Bakri** 
* Computer Science Undergraduate Student
* [LinkedIn](https://www.linkedin.com/in/saleh-bakri-97b136320/)

**תאופיק חליל (Tawfik Khalil)** 
* ID: 214081523
