using MagicUI.Core;
using MagicUI.Elements;
using System;
using UnityEngine;

namespace LumaflyLanternTracker {
    internal class LumaflyLanternUI : IDisposable {
        private readonly LayoutRoot layout;
        private readonly StackLayout LanternStack;
        public TextObject TotalCounter { get; }
        public TextObject RoomCounter { get; }

        public LumaflyLanternUI() {
            layout = new LayoutRoot(true, "LumaflyLanternUI");

            LanternStack = new StackLayout(layout)
            {
                Orientation = Orientation.Vertical,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Spacing = 5,
                Padding = new Padding(Screen.width * 0.13f, Screen.height * 0.15f, 0, 0)
            };

            TotalCounter = CreateCounter("0/0");
            RoomCounter = CreateCounter("0/0");
            
            LanternStack.Children.Add(TotalCounter);
            LanternStack.Children.Add(RoomCounter);
        }

        private TextObject CreateCounter(string initialText) {
            return new TextObject(layout)
            {
                Text = initialText,
                FontSize = Convert.ToInt32((Convert.ToDouble(Screen.width) * 0.01)),
            };
        }

        public void Dispose() {
            layout.Destroy();
        }
    }

}
