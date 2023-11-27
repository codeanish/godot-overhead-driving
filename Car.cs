using Godot;
using System;

public partial class Car : Area2D
{
	[Export]
	public int Speed {get; set;} = 400; // How fast the player will move (pixels/sec).
	
	[Export]
	public float RotationSpeed {get; set; } = 1.5f; // How fast the player will rotate (degrees/sec).

	private int _rotationDirection;

	public void GetInput()
	{
		_rotationDirection = 0;
		if (Input.IsActionPressed("TurnRight"))
		{
			_rotationDirection -= 1;
		}
		if (Input.IsActionPressed("TurnLeft"))
		{
			_rotationDirection += 1;
		}
		if (Input.IsActionPressed("Accelerate"))
		{
			var velocity = new Vector2(0, -Speed);

			Position = new Vector2(Position.X, Position.Y - Speed);
			// Position = new Vector2(Position.x, Position.y - Speed);
			// Position = new Vector2(Position.x, Position
		}
	}	
	public override void _Ready()
	{
		// ScreenSize = GetViewportRect().Size;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// var velocity = Vector2.Zero;
		// velocity.
	}

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
		Rotation += _rotationDirection * RotationSpeed * (float)delta;
				
    }
}
