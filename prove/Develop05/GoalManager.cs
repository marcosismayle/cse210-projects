GoalManager
- goals: List<Goal>
+ AddGoal(newGoal: Goal): void
+ RecordEvent(goalName: string): void
+ DisplayGoals(): void
+ SaveData(): void
+ LoadData(): void
