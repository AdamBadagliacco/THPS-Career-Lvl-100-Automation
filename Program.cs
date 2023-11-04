using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace KeyBoardInput {
    class Program {
        static void Main(string[] args) {
            GetPlatTrophy4Me();
        }

        public static void GetPlatTrophy4Me() {
            var simulator = new InputSimulator();

            //Countdown to switch to Chiaki
            Console.WriteLine("Running script in:");
            for (int i = 5; i > 0; i--) {
                Console.WriteLine($"Counting down: {i}");
                Thread.Sleep(1000); // Sleep for 1 second (1000 milliseconds)
            }
            Console.WriteLine("Countdown complete!");


            //Do tricks until you get achievement, program can be closed then
            while (true) {
                RestartRun(simulator);
                DoTricks4AMillionPoints(simulator);
            }
        }

        public static void RestartRun(InputSimulator simulator) {
            int waitBetweenButtonClicks = 200;
            PressButton(simulator, VirtualKeyCode.VK_O); //Pause Game
            Thread.Sleep(waitBetweenButtonClicks);
            PressButton(simulator, VirtualKeyCode.UP);
            Thread.Sleep(waitBetweenButtonClicks);
            PressButton(simulator, VirtualKeyCode.RETURN); //Press "End Run"
            Thread.Sleep(waitBetweenButtonClicks);
            PressButton(simulator, VirtualKeyCode.RETURN); //See Park Goals here (Sceen not on custom parks)
            Thread.Sleep(750); 
            PressButton(simulator, VirtualKeyCode.RETURN); //See score here (Make sure it's a million points)
            Thread.Sleep(950); 
            PressButton(simulator, VirtualKeyCode.RETURN); //Press "Retry Level"
            Thread.Sleep(2700); 
        }

        public static void DoTricks4AMillionPoints(InputSimulator simulator) {
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            VarialMcTwist(simulator);
            The900(simulator);
            PressButton(simulator, VirtualKeyCode.RETURN);
            Thread.Sleep(1000); //Let tony land
        }

        public static void Manual(InputSimulator simulator) {
            PressButton(simulator, VirtualKeyCode.UP);
            PressButton(simulator, VirtualKeyCode.DOWN);
            Thread.Sleep(200); // Give Tony Time to Land
        }

        public static void The900(InputSimulator simulator) {
            PressButton(simulator, VirtualKeyCode.RETURN);
            PressButton(simulator, VirtualKeyCode.RIGHT);
            PressButton(simulator, VirtualKeyCode.LEFT);
            PressButton(simulator, VirtualKeyCode.BACK);
            Manual(simulator); //Land into a Manual
        }

        public static void VarialMcTwist(InputSimulator simulator) {
            PressButton(simulator, VirtualKeyCode.RETURN);
            PressButton(simulator, VirtualKeyCode.UP);
            PressButton(simulator, VirtualKeyCode.LEFT);
            PressButton(simulator, VirtualKeyCode.BACK);
            Manual(simulator); //Land into a Manual
        }

        public static void PressButton(InputSimulator simulator, VirtualKeyCode button2Press) {
            simulator.Keyboard.KeyDown(button2Press);
            Thread.Sleep(75);
            simulator.Keyboard.KeyUp(button2Press);
            Thread.Sleep(10);
        }

        public static void PrintKeyCodes() { //Used this to refernce all keycodes
            foreach (VirtualKeyCode keyCode in Enum.GetValues(typeof(VirtualKeyCode))) {
                Console.WriteLine(keyCode);
            }
        }
    }
}
