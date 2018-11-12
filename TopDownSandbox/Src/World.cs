using Proton;
using System;

namespace TopDownSandbox
{
    public class World
    {
        Tilemap map;

        public World()
        {
            map = new Tilemap();

            Camera.mainCamera.transform.position.x = 2.5f;
            Camera.mainCamera.transform.position.y = 0.5f;
            Camera.mainCamera.transform.position.z = 2.5f;
            Camera.mainCamera.transform.rotation.eulerAngles = new Vector3(30.0f, 0.0f, 0.0f);
        }

        public void Update()
        {
        }

        public void Render()
        {
            map.Render();
        }
    }
}
