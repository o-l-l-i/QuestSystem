# QuestSystem

This is a collection of code related to a quest system in a game I built but haven't finished yet.

It's not a complete working system in this form, but I thought to share it just to show how I built it.

I did some reading on the topic and took a few attempts earlier before creating this one. It's not that pretty but it did work in practice. I'm sure there's much better designed ones out there than my crude attempt.

The core things related to the quest system, **Quest** and **QuestManager** classes are somewhat complete and intact, and I have also included stubs of classes that were required for the functionality, so that the code would not feel too incomplete with the missing method calls etc.

## Quest system features

- My quest system allowed creation of quests in text format by basically filling a constructor and creating a new instance of Quest class
    - These quests were then stored in a central quest registry (a List)
    - Simple, but it worked just fine for the purpose

- Basically the quests were constructed from three steps:

    1. Requirements (to start a quest)
        - One or more
        - Different types

    2. Objectives (what the player is required to do)
        - One or more
        - Different types

    3. Rewards (what the player gets for a quest completion)
        - One or more rewards
        - Different types

- The quests would then be assigned to NPC characters, which could give them to the player if he/she met the requirements

- NPC characters could have one more quests available

- The player could have more than one quest active at the same time

- Quest completion would reward the player with:
    - Some basic things like experience, money and so on
    - Could also be negative/neutral like losing/giving an item away
    - Unlocking of new quests and removing obstacles that block access to an area

Below is a list of the quest requirements, objectives and rewards I implemented:

### Requirements

- No requirements
- Some earlier quest completed
- Have a certain amount of money
- Have a certain amount of experience
- Have killed a certain amount of enemies
- Have reached a certain dungeon level

### Objectives

- Kill a certain amount of enemies
- Kill all enemies on a dungeon level
- Find an item
- Find an item and bring it to a NPC
- Gain certain amount of experience
- Find certain amount of food
- Gain certain amount of money

### Rewards

- Item
- Experience
- Money
- Food
- Remove obstacle
- Give item to NPC
- Hide NPC avatar
- Unlock a new quest

© 2020 Olli Sorjonen All Rights Reserved
