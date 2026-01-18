# 🚀 RPG Combat Simulator (root-c-)

This is my first C# learning project, aimed at implementing a complete combat numerical settlement system.

## 📢 Changelog

### [Ver 0.2.1] - 2026-01-18
***Robust Input Validation & Cinematic Performance***

* **ASCII Startup Logo**: Added a custom ASCII Art identity to the startup screen to establish a professional project brand.
* **Input Sanitization**: Implemented `int.TryParse` to filter non-numeric inputs and eliminate program crashes caused by invalid characters.
* **Persistent Menu**: Integrated a `while(true)` validation loop to ensure a valid weapon choice is made before proceeding.
* **Weapon Arsenal Update**: 
    * **Great Katana**: High base damage (2000) with a balanced 20% Critical Rate.
    * **Giant Cannon**: Moderate damage (1000) with a strategic 50% Critical Rate.
    * **Chicken Bone**: Low base damage (30) but features a unique 99% double-check Critical determination logic.
* **Cinematic Pacing**: Applied `Thread.Sleep()` to simulate weapon analysis and create a better narrative rhythm during transitions.
* **Code Refactoring**: Successfully resolved variable scope issues to securely pass the `choice` data into `finalchoice` outside the loop.

***

### [Ver 0.2] - 2026-01-18
***Added 【Critical Hit】 and 【Normal Attack】 determination***
* **New Weapons**: Added three distinct weapon types.
* **New Enemy**: Added the enemy 【Black Dragon】.
* **Distribution**: The entire source file is attached as a ZIP archive.

***

### [Ver 0.1.2] - 2026-01-17
**New Features:**
* **Defense System**: Added player 【Armor】. Damage is no longer dealt when Attack is lower than Defense.
* **Evasion Logic**: Introduced a 1-100 random number determination logic; supports manual input to simulate evasion.
* **Precision Upgrade**: HP calculation upgraded from `int` to `double` to support decimal displays.

***

### [Ver 0.1] - 2026-01-16
* **Core Framework**: Implemented basic arithmetic calculator logic.
* **First Product**: Successfully built the first `.exe` executable file.
