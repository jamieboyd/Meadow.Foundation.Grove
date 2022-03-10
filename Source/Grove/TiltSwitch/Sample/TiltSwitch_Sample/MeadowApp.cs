﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;

namespace Grove.TiltSwitch_Sample
{
    // Change F7MicroV2 to F7Micro for V1.x boards
    public class MeadowApp : App<F7MicroV2, MeadowApp>
    {
        public MeadowApp()
        {
            Console.WriteLine("Initialize hardware...");

            var tiltSwitch = new TiltSwitch(Device, Device.Pins.D13);

            tiltSwitch.Changed += (s, e) =>
            {
                Console.WriteLine(tiltSwitch.IsOn ? "Switch is High" : "Switch is Low");
            };
        }
    }
}