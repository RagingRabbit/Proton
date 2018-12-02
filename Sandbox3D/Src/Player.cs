using Proton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player : KeyListener, CursorPosListener
{
    const float GRAVITY = 15.0f;
    const float JUMP_POWER = 6.0f;
    const float WALK_SPEED = 6.0f;
    const float HEAD_HEIGHT = 1.6f;

    public Transform transform;

    World world;
    float fallSpeed;

    public Player(World world)
    {
        transform = new Transform(Vector3.zero, Quaternion.identity);

        this.world = world;

        Input.AddKeyListener(this);
        Input.AddCursorPosListener(this);
    }

    public void OnKeyEvent(KeyCode key, bool down, KeyMod mods)
    {
        if (down && key == KeyCode.Space)
        {
            if (fallSpeed == 0.0f)
            {
                fallSpeed = JUMP_POWER;
            }
        }
    }

    public void OnCursorMove(int dx, int dy)
    {
        transform.rotation = Quaternion.AxisAngle(Vector3.up, dx / 10.0f) * Camera.mainCamera.transform.rotation * Quaternion.AxisAngle(Vector3.right, dy / 10.0f);
    }

    public void Update()
    {
        Vector3 delta = new Vector3();

        if (Input.GetKeyDown(KeyCode.A)) delta.x -= Time.delta * WALK_SPEED;
        if (Input.GetKeyDown(KeyCode.D)) delta.x += Time.delta * WALK_SPEED;
        if (Input.GetKeyDown(KeyCode.W)) delta.z -= Time.delta * WALK_SPEED;
        if (Input.GetKeyDown(KeyCode.S)) delta.z += Time.delta * WALK_SPEED;

        delta = (transform.rotation * delta.normalized * new Vector3(1, 0, 1)).normalized * delta.length;
        //if (Input.GetKeyDown(KeyCode.Space)) xzDelta.y += Time.delta * 10;
        //if (Input.GetKeyDown(KeyCode.LeftShift)) xzDelta.y -= Time.delta * 10;
        fallSpeed += -GRAVITY * Time.delta;
        delta.y += fallSpeed * Time.delta;
        delta = DoCollision(delta);
        transform.position += delta;

        Camera.mainCamera.transform = transform;
        Camera.mainCamera.transform.position.y += HEAD_HEIGHT;
    }

    Vector3 DoCollision(Vector3 delta)
    {
        int blockX = (int)(transform.position.x);
        int blockY = (int)(transform.position.y);
        int blockZ = (int)(transform.position.z);
        int blockDX = (int)(transform.position.x + delta.x);
        int blockDY = (int)(transform.position.y + delta.y);
        int blockDZ = (int)(transform.position.z + delta.z);

        if (world.GetBlockAtWorldPos(blockDX, blockY, blockZ).solid)
        {
            delta.x = 0;
        }
        if (world.GetBlockAtWorldPos(blockX, blockDY, blockZ).solid)
        {
            delta.y = 0;
            fallSpeed = 0.0f;
        }
        if (world.GetBlockAtWorldPos(blockX, blockY, blockDZ).solid)
        {
            delta.z = 0;
        }

        return delta;
    }
}
