﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Sensors.Switches;
using System;
using System.Threading.Tasks;

namespace Grove.SwitchP_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        SwitchP groveSwitch;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            groveSwitch = new SwitchP(Device, Device.Pins.D13);

            groveSwitch.Changed += (s, e) =>
            {
                Console.WriteLine(groveSwitch.IsOn ? "Switch is High" : "Switch is Low");
            };

            return Task.CompletedTask;
        }

        //<!=SNOP=>
    }
}