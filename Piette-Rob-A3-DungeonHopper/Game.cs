// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;


// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:
    Player player = new Player();
    Enemy enemy = new Enemy();
    Platform platform = new Platform(0, 0, 0, 0);

    // A list of platforms
    Platform[] platforms = new Platform[]
    {
        new Platform(0, 550, 100, 50),
        new Platform(150, 450, 50, 50),
        new Platform(250, 550, 50, 50),
        new Platform(350, 500, 50, 50),
        new Platform(400, 400, 100, 50),
        new Platform(550, 550, 200, 50),
        new Platform(750, 450, 50, 50),
        new Platform(650, 400, 50, 50),
        new Platform(750, 300, 50, 50),
        new Platform(650, 250, 50, 50),
        new Platform(750, 150, 50, 50),
        new Platform(650, 50, 50, 50),
        new Platform(550, 100, 50, 50),
        new Platform(450, 50, 50, 50),
        new Platform(350, 100, 50, 50),
        new Platform(250, 50, 50, 50),
        new Platform(50, 100, 200, 50),
        new Platform(0, 50, 50, 50),
    };
    public void Setup()
    {
        Window.SetTitle("Dungeon Hopper");
        Window.SetSize(800, 600);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.Black);
        player.renderPlayer();
        enemy.renderEnemy();
        platform.renderPlatforms();
        player.movePlayer();
        HandlePlayerCollision();
    }

    public void HandlePlayerCollision()
    {
        bool isOnGround = false;

        // Check player collision with all platforms
        foreach (var p in platforms)
        {
            // Check for collision
            if (player.X + player.Width > p.X && player.X < p.X + p.Width &&
                player.Y + player.Height > p.Y && player.Y < p.Y + p.Height)
            {
                // Handle horizontal collision (e.g., left/right movement)
                if (player.Y + player.Height <= p.Y)
                {
                    // Player is on top of a platform, stop falling and set to platform's top
                    player.Y = p.Y - player.Height;
                    player.VerticalSpeed = 0;
                    player.IsJumping = false;
                    isOnGround = true;
                    break;
                }
            }
        }

        // If the player is not on the ground, apply gravity
        if (!isOnGround)
        {
            player.VerticalSpeed += 1; // Gravity effect
        }

        // Update the player's vertical position
        player.Y += player.VerticalSpeed;

        // Check if the player is falling too far
        if (player.Y > 600) // Assuming 600 is the bottom of the screen
        {
            player.Y = 600;
            player.VerticalSpeed = 0;
        }

        // If the player is jumping, allow them to continue moving upwards
        if (player.IsJumping)
        {
            player.Y += player.VerticalSpeed;
        }
    }
}
    



