using Godot;
using System;

public partial class TestCar : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;

	[Export]
	public float RotationSpeed { get; set; } = 1.5f;

	private float _rotationDirection;

	public void GetInput()
	{
		_rotationDirection = Input.GetAxis("TurnLeft", "TurnRight");
		Velocity = Transform.X * Input.GetAxis("Accelerate", "Brake") * Speed;
	}

    public override void _PhysicsProcess(double delta)
    {
		GetInput();
		Rotation += _rotationDirection * RotationSpeed * (float)delta;
		MoveAndSlide();
    }
}
