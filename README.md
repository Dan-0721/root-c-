# 🚀 RPG Combat Simulator (root-c-)

This is my first C# learning project, aimed at implementing a complete combat numerical settlement system.

## 📢 Changelog

### [Ver 0.2.1] - 2026-01-18
***Robust Input Validation & Cinematic Performance (稳健输入校验与演出优化)***
* **ASCII Startup Logo**: 新增自定义 ASCII Art 字符画启动界面，提升项目辨识度。
* **Input Sanitization**: 引入 `int.TryParse` 机制，彻底拦截因输入字母或非法符号导致的程序崩溃。
* **Persistent Menu**: 通过 `while(true)` 实现循环验证逻辑，确保玩家完成有效选择前不会退出。
* **Weapon Arsenal Update**: 
    * **Great Katana (大太刀)**: 2000 基础伤害，20% 暴击率。
    * **Giant Cannon (巨型加农炮)**: 1000 基础伤害，50% 暴击率。
    * **Chicken Bone (鸡骨头)**: 30 基础伤害，实装 99% 概率的双重暴击判定逻辑。
* **Cinematic Pacing**: 使用 `Thread.Sleep()` 增加文字显示停顿，模拟游戏蓄力与解析的节奏感。
* **Code Refactoring**: 成功解决变量作用域问题，将 `choice` 数据安全传递至循环体外进行结算。

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
