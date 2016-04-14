using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace horloge
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //TimeSpan ts = new TimeSpan();
            //ts.s();
            //ts = ts.Add(new TimeSpan(0, 0, 1));
            //ts.s();

            //IHorloge i = new HorlogeAleatoire();
            //while (true)
            //{
            //    i.Time.s();
            //    App.DoEvents();
            //    Thread.Sleep(500);
            //}
        }

        #region DoEvents
        private static DispatcherOperationCallback exitFrameCallback = new DispatcherOperationCallback(ExitFrame);

        /// <summary> 
        /// Processes all UI messages currently in the message queue.
        /// </summary>

        public static void DoEvents()
        {
            // Create new nested message pump.

            DispatcherFrame nestedFrame = new DispatcherFrame();

            // Dispatch a callback to the current message queue, when getting called,
            // this callback will end the nested message loop.
            // note that the priority of this callback should be lower than the that of UI event messages.

            DispatcherOperation exitOperation = Dispatcher.CurrentDispatcher.BeginInvoke(
            DispatcherPriority.Background, exitFrameCallback, nestedFrame);

            // pump the nested message loop, the nested message loop will
            // immediately process the messages left inside the message queue.

            Dispatcher.PushFrame(nestedFrame);

            // If the "exitFrame" callback doesn't get finished, Abort it.

            if (exitOperation.Status != DispatcherOperationStatus.Completed)
            {
                exitOperation.Abort();
            }
        }

        private static Object ExitFrame(Object state)
        {
            DispatcherFrame frame = state as DispatcherFrame;

            // Exit the nested message loop.

            frame.Continue = false;
            return null;
        }
        #endregion


    }

    public static class MesFonctions
    {
        public static void s(this string message)
        {
            Console.WriteLine(message);
        }
        public static void s(this TimeSpan ts)
        {
            ts.ToString().s();
        }
    }
}
