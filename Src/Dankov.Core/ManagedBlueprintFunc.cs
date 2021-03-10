using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using UnrealEngine.Framework;

namespace Dankov.Core
{
    public static class ManagedBlueprintFunc
    {
        private const float rotationSpeed = 2.5f;

        private static Actor actor = new("Bullet");
        private static SceneComponent sceneComponent = new(actor);
        private static Transform actorTransform;
        private static readonly StaticMeshComponent component = new(actor, setAsRoot: true);

        public static void Function()
        {
            Debug.AddOnScreenMessage(-1, 50.0f, Color.Green, "Blueprint function invoked!");
            var camera = World.GetActor<Camera>("MainCamera");
            World.GetFirstPlayerController().SetViewTarget(camera);

            //actor = new("Bullet");
            //sceneComponent = new(actor);
            component.SetStaticMesh(StaticMesh.Cube);

            sceneComponent.SetRelativeLocation(new Vector3(150, 50, 100));
            sceneComponent.SetRelativeRotation(Maths.CreateFromYawPitchRoll(5.0f, 0.0f, 0.0f));
            sceneComponent.AddLocalOffset(new Vector3(15.0f, 20.0f, 25.0f));
            sceneComponent.GetTransform(ref actorTransform);
            component.AddLocalTransform(actorTransform);

            Debug.AddOnScreenMessage(-1, 3.0f, Color.LightGreen, "Instances are created!");
        }

        public static void OnTick()
        {
            Debug.AddOnScreenMessage(1, 1.0f, Color.SkyBlue, "Frame number: " + Engine.FrameNumber);

            var deltaTime = World.DeltaTime;

            var deltaRotation = Maths.CreateFromYawPitchRoll(rotationSpeed * deltaTime, rotationSpeed * deltaTime, rotationSpeed * deltaTime);

            sceneComponent.SetWorldTransform(actorTransform);
            sceneComponent.AddLocalRotation(deltaRotation);
            sceneComponent.GetTransform(ref actorTransform);
            component.SetWorldTransform(actorTransform);
        }
    }
}