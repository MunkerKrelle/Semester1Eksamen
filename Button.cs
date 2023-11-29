using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Semester1Projekt
{
    internal class Button
    {
            private Vector2 minPosition;
            private Vector2 maxPosition;
            private Vector2 buttonPosition;
            Texture2D buttonTexture;
            private float scale = 1f;
            Rectangle rectangleForButtons;
            Color colorCode = Color.White;
            Vector2 originSprite, originText;
            public static SpriteFont font;
            public bool active = true;

            string bunttonText;

            protected Vector2 SpriteSize
            {
                get
                {
                    return new Vector2(buttonTexture.Width * scale, buttonTexture.Height * scale);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="buttonPosition">The button's position on the screen</param>
            /// <param name="buttonText">Text that is written on the button</param>
            /// <param name="actionFunction">Which function to run when clicked</param>
            public Button(Vector2 buttonPosition, string buttonText, Delegate actionFunction)
            {
                this.buttonPosition = buttonPosition;
                this.bunttonText = buttonText;
            }

            /// <summary>
            /// Destroys the object after it is clicked
            /// </summary>
            public void Destroy()
            {
            }

            public void Update()
            {
                MouseOnButton();
            }

            /// <summary>
            /// Updates the position of the buandries of the button - where the button can be clicked
            /// </summary>
            public void PositionUpdate()
            {
                minPosition.X = buttonPosition.X - (rectangleForButtons.Width / 2);
                minPosition.Y = buttonPosition.Y - (rectangleForButtons.Height / 2);
                maxPosition.X = buttonPosition.X + (rectangleForButtons.Width / 2);
                maxPosition.Y = buttonPosition.Y + (rectangleForButtons.Height / 2);
            }

            public void LoadContent(ContentManager content)
            {
                buttonTexture = content.Load<Texture2D>("Sprites/button");

                rectangleForButtons = new Rectangle((int)buttonPosition.X, (int)buttonPosition.Y, buttonTexture.Width / 2, buttonTexture.Height / 2);
                font = content.Load<SpriteFont>("Sprites/File");

                PositionUpdate();
            }

            /// <summary>
            /// Checks if the cursor is on an object and turns it gray 
            /// </summary>
            public void MouseOnButton()
            {

                if (Cursor.Position.X > minPosition.X && Cursor.Position.Y > minPosition.Y && Cursor.Position.X < maxPosition.X && Cursor.Position.Y < maxPosition.Y)
                {
                    colorCode = Color.LightGray;
                }
                else
                {
                    colorCode = Color.White;
                }
            }

            /// <summary>
            /// Checks if the mouse is pressed on a pressabled object
            /// </summary>
            public void MousePressed()
            {
                if (!active)
                {
                    return;
                }

                if (Cursor.Position.X > minPosition.X && Cursor.Position.Y > minPosition.Y && Cursor.Position.X < maxPosition.X && Cursor.Position.Y < maxPosition.Y)
                {
                    colorCode = Color.Yellow;
                }

            }

            public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
            {
                Vector2 fontLength = font.MeasureString(bunttonText);

                originSprite = new Vector2(buttonTexture.Width / 2f, buttonTexture.Height / 2f);
                originText = new Vector2(fontLength.X / 2f, fontLength.Y / 2f);

                spriteBatch.DrawString(font, bunttonText, buttonPosition, Color.Black, 0, originText, 1, SpriteEffects.None, 0.99f);
                spriteBatch.Draw(buttonTexture, rectangleForButtons, null, colorCode, 0, originSprite, SpriteEffects.None, 0.98f);
            }
        }
    }



