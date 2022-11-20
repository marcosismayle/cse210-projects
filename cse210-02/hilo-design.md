# Hilo Design

|Object: director|
|--------------|
|**Responsibility:**|
|- The responsibility of the director is constrol the game|

|Behavior:|State:|
|---------|------|
|- Starts the game by running the main game loop|- start game|
|- list the cards and show the current|- list cards|
|- get user inputs|- get inputs|
|- update the player score|- update score|
|- ouput the game score|- output score|
---

---
|Object: card|
|--------------|
|**Responsibility:**|
|generate a random card between 1 to 13 and calculate the score|

|Behavior:|State:|
|---------|------|
|- create atribute for a sigle card|- single card|
|- Show initial score|- print initial score|
|- calculate the score|- score calculate|
