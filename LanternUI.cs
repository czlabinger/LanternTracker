using MagicUI.Core;
using MagicUI.Elements;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace LanternTracker {
    internal class LanternUI : IDisposable {
        internal LayoutRoot layout;
        internal StackLayout vstack;
        internal TextObject TotalCounter { get; }
        internal TextObject RoomCounter { get; }
        internal TextObject DBBuildHelper { get; }
        internal StackLayout totalRow;
        internal StackLayout roomRow;
        private Image totalImg;
        private Image roomImg;
        private float targetHeight = Screen.height * 0.05f;

        //TODO: Fix image scaling
        internal LanternUI() {
            layout = new LayoutRoot(true, "LumaflyLanternUI");

            vstack = new StackLayout(layout)
            {
                Orientation = Orientation.Vertical,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Spacing = 5,
                Padding = new Padding(Screen.width * 0.13f, Screen.height * 0.15f, 0, 0),
                Visibility = Visibility.Hidden,
            };

            totalRow = new StackLayout(layout)
            {
                Orientation = Orientation.Horizontal,
                Spacing = Screen.width * 0.01f,
            };

            roomRow = new StackLayout(layout)
            {
                Orientation = Orientation.Horizontal,
                Spacing = Screen.width * 0.01f,
            };

            TotalCounter = CreateCounter("0/0");
            RoomCounter = CreateCounter("0/0");
            DBBuildHelper = CreateCounter("You broke");


            float aspectRatio = 1 / 1;
            float scaledWidth = targetHeight * aspectRatio;

            byte[] totalImgData = StreamToByteArray(Assembly.GetExecutingAssembly().GetManifestResourceStream("LumaflyLanternTracker.Assets.lantern_total.png"));
            Texture2D totalTexture = new Texture2D(Convert.ToInt32(scaledWidth), Convert.ToInt32(targetHeight));

            totalTexture.LoadImage(totalImgData);
            Sprite totalSprite = Sprite.Create(totalTexture, new Rect(0, 0, scaledWidth, targetHeight), new Vector2(0.5f, 0.5f));

            totalImg = new Image(layout, totalSprite, "total lanterns image")
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,

            };



            byte[] roomImgData = StreamToByteArray(Assembly.GetExecutingAssembly().GetManifestResourceStream("LumaflyLanternTracker.Assets.lantern_room.png"));
            Texture2D roomTexture = new Texture2D(Convert.ToInt32(scaledWidth), Convert.ToInt32(targetHeight));

            aspectRatio = 1 / 1;
            scaledWidth = targetHeight * aspectRatio;

            totalTexture.LoadImage(roomImgData);
            Sprite roomSprite = Sprite.Create(totalTexture, new Rect(0, 0, scaledWidth, targetHeight), new Vector2(0.5f, 0.5f));

            roomImg = new Image(layout, roomSprite, "room lanterns image")
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,

            };

            totalRow.Children.Add(totalImg);
            totalRow.Children.Add(TotalCounter);
            roomRow.Children.Add(roomImg);
            roomRow.Children.Add(RoomCounter);

            vstack.Children.Add(totalRow);
            vstack.Children.Add(roomRow);
            vstack.Children.Add(DBBuildHelper);
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

        private byte[] StreamToByteArray(Stream stream) {
            if (stream is MemoryStream memStream)
                return memStream.ToArray();

            using (var memoryStream = new MemoryStream()) {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }

}
