using System;

public interface IActionOverTime {
	void Update();
	bool IsComplete { get; }
}