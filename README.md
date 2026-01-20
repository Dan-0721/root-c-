
### 🌐 中文
* 这是 **RooT** 的第一个发行版本！
* 我正式添加了一个角色。
* **当前功能：**
    * ⬅️➡️ **左右移动:** A / D
    * ⬆️ **跳跃:** 空格
    * ⚡ **冲刺:** Shift
    * ⚔️ **攻击:** J
* 👾 **开发计划:** 我将会在下个版本加入敌人！
* 🙏 **感谢你的下载！**
# 🚀 RPG Combat Simulator
## 🚀 RooT v0.1 - Initial Release

---

### 🌐 English
* This is the first release of **RooT**!
* The main character has been officially added.
* **Available Actions:**
    * ⬅️➡️ **Movement:** A / D
    * ⬆️ **Jump:** Space
    * ⚡ **Dash:** Shift
    * ⚔️ **Attack:** J
* 👾 **Next Version:** Enemies will be added!
* 🙏 **Thank you for downloading!**

---

### 🌐 日本語
* **RooT**の初回リリース版です！
* プレイヤーキャラクターを正式に実装しました。
* **アクション一覧：**
    * ⬅️➡️ **左右移動:** A / D
    * ⬆️ **ジャンプ:** Space
    * ⚡ **ダッシュ:** Shift
    * ⚔️ **攻撃:** J
* 👾 **次回予告:** 敵キャラクターを追加予定です！
* 🙏 **ダウンロードありがとうございます！**

---

(root-c-) This is my first C# learning project, aimed at implementing a complete combat numerical settlement system.

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
