# Meadow.Foundation.Grove.Sensors.Motion.PIRMotionSensor

**Grove GPIO PIRMotionSensor (Parallax PIR)**

The **PIRMotionSensor** library is designed for the [Wilderness Labs](www.wildernesslabs.co) Meadow .NET IoT platform and is part of [Meadow.Foundation](https://developer.wildernesslabs.co/Meadow/Meadow.Foundation/).

The **Meadow.Foundation** peripherals library is an open-source repository of drivers and libraries that streamline and simplify adding hardware to your C# .NET Meadow IoT application.

For more information on developing for Meadow, visit [developer.wildernesslabs.co](http://developer.wildernesslabs.co/).

To view all Wilderness Labs open-source projects, including samples, visit [github.com/wildernesslabs](https://github.com/wildernesslabs/).

## Usage

```csharp
PIRMotionSensor motionSensor;

public override Task Initialize()
{
    motionSensor = new PIRMotionSensor(
        Device.CreateDigitalInterruptPort(
            Device.Pins.D13,
            InterruptMode.EdgeBoth,
            ResistorMode.Disabled));

    motionSensor.OnMotionStart += (sender) =>
    {
        Resolver.Log.Info($"Motion start  {DateTime.Now}");
    };

    motionSensor.OnMotionEnd += (sender) =>
    {
        Resolver.Log.Info($"Motion end  {DateTime.Now}");
    };

    return Task.CompletedTask;
}

```
## How to Contribute

- **Found a bug?** [Report an issue](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Have a **feature idea or driver request?** [Open a new feature request](https://github.com/WildernessLabs/Meadow_Issues/issues)
- Want to **contribute code?** Fork the [Meadow.Foundation.Grove](https://github.com/WildernessLabs/Meadow.Foundation.Grove) repository and submit a pull request against the `develop` branch


## Need Help?

If you have questions or need assistance, please join the Wilderness Labs [community on Slack](http://slackinvite.wildernesslabs.co/).