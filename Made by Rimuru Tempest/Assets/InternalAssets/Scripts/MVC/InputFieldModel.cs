namespace RimuruDev.FromPlayclapp.MVC
{
    public sealed class InputFieldModel
    {
        public InputFieldNode motionSpeed = default;
        public InputFieldNode spawnCooldown = default;
        public InputFieldNode distance = default;

        public InputFieldModel(InputFieldNode motionSpeed, InputFieldNode spawnCooldown, InputFieldNode distance)
        {
            this.motionSpeed = motionSpeed;
            this.spawnCooldown = spawnCooldown;
            this.distance = distance;
        }

        ~InputFieldModel()
        {
            motionSpeed = default;
            spawnCooldown = default;
            distance = default;
        }
    }
}