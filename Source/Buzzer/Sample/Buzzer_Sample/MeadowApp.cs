﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Grove.Audio;
using System;
using System.Threading.Tasks;

namespace Grove.Buzzer_Sample
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        Buzzer buzzer;

        public override Task Initialize()
        {
            Console.WriteLine("Initialize...");

            buzzer = new Buzzer(Device, Device.Pins.D13);

            return Task.CompletedTask;
        }

        public override async Task Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Playing A major triad starting at A4");
                await buzzer.PlayTone(440, 500); //A
                await buzzer.PlayTone(554.37f, 500); //C#
                await buzzer.PlayTone(659.25f, 500); //E

                await Task.Delay(2500);
            }
        }

        //<!=SNOP=>
    }
}