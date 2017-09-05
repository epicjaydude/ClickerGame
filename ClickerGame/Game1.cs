using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace ClickerGame
{


    /// <summary>
    /// TODO:
    /// ADD SCALING PRICES
    /// MAKE PRICES APPEAR
    /// ADD MORE SHOP OPTIONS (pic for #3 ready)
    /// </summary>

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D numSp;
        Texture2D shop;
        Texture2D clickSpc;
        Texture2D clickSpc2;
        Texture2D clickSpc3;
        Texture2D clickSpcH;
        Texture2D clickSpc2H;
        Texture2D clickSpc3H;
        Texture2D shopOp1;
        Texture2D shopOp2;
        Texture2D shopOp3;
        Texture2D shopOp4;
        float spX1 = 0;
        float spX2 = 0;
        float spX3 = 0;
        float spX4 = 0;
        float spX5 = 0;
        float spX6 = 0;
        float spX7 = 0;
        float x1 = 0;
        float x2 = 0;
        float x3 = 0;
        float x4 = 0;
        float x5 = 0;
        float x6 = 0;
        float x7 = 0;
        float Op1Y =0;
        float Op2Y = 0;
        float Op3Y = 0;
        float Op4Y = 0;
        float clicks = 0;
        float sAmount = 0;
        float cAmount = 1;
        ButtonState hold;
        int shopCon1 = 0;
        int shopCon2 = 0;
        int shopCon3 = 0;
        int shopCon4 = 0;
        int op1Num = 0;
        int op2Num = 0;
        int op3Num = 0;
        int op4Num = 0;
        int op1Pri = 15;
        int op2Pri = 50;
        int op3Pri = 120;
        int op4Pri = 500;
        int clickCon = 1;
        //bought plate
        int o1n1;
        int o1n2;
        int o2n1;
        int o2n2;
        int o3n1;
        int o3n2;
        int o4n1;
        int o4n2;
        //cost plate
        int o1p1;
        int o1p2;
        int o1p3;
        int o2p1;
        int o2p2;
        int o2p3;
        int o3p1;
        int o3p2;
        int o3p3;
        int o4p1;
        int o4p2;
        int o4p3;
        int o1s;
        int o2s;
        int o3s;
        int o4s;
        bool H = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 850;
            graphics.PreferredBackBufferHeight = 550;
            graphics.ApplyChanges();

        }


        protected override void Initialize()
        {
            
            

            base.Initialize();
        }


        protected override void LoadContent()
        {
            numSp = this.Content.Load<Texture2D>("numSp");
            spriteBatch = new SpriteBatch(GraphicsDevice);
            shop = this.Content.Load<Texture2D>("ClickShop");
            shopOp1 = this.Content.Load<Texture2D>("shopOp1");
            shopOp2 = this.Content.Load<Texture2D>("shopOp2");
            shopOp3 = this.Content.Load<Texture2D>("shopOp3");
            shopOp4 = this.Content.Load<Texture2D>("shopOp4");
            clickSpc = this.Content.Load<Texture2D>("clickSpace");
            clickSpc2 = this.Content.Load<Texture2D>("clickSpace2");
            clickSpc3 = this.Content.Load<Texture2D>("clickSpace3");
            clickSpcH = this.Content.Load<Texture2D>("clickSpaceH");
            clickSpc2H = this.Content.Load<Texture2D>("clickSpace2H");
            clickSpc3H = this.Content.Load<Texture2D>("clickSpace3H");
        }


        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {
            if (IsActive)
            {

                //reseting values
                o1n1 = 0;
                o1n2 = 0;
                o2n1 = 0;
                o2n2 = 0;
                o3n1 = 0;
                o3n2 = 0;
                o4n1 = 0;
                o4n2 = 0;
                o1p1 = 0;
                o1p2 = 0;
                o1p3 = 0;
                o2p1 = 0;
                o2p2 = 0;
                o2p3 = 0;
                o3p1 = 0;
                o3p2 = 0;
                o3p3 = 0;
                o4p1 = 0;
                o4p2 = 0;
                o4p3 = 0;
                o1s = 0;
                o2s = 0;
                o3s = 0;
                o4s = 0;

                //declaring mouse shit 
                MouseState state = Mouse.GetState();
                var mousePosition = new Point(state.X, state.Y);
                //shop
                //FIRST OPTION
                op1Pri = (int)(15.0 * System.Math.Pow (1.2 ,op1Num)) ;
                shopCon1 = 0;
                if (clicks >= op1Pri)
                {
                    shopCon1 = 1;
                    if (mousePosition.X > 400 & mousePosition.X < 800 & mousePosition.Y > 50 & mousePosition.Y < 101)
                    {
                        shopCon1 = 2;
                        // //click +1
                        if (state.LeftButton != hold)
                        {
                            if (state.LeftButton == ButtonState.Pressed)
                            {
                                op1Num += 1;
                                    cAmount += 1;
                                    clicks -= op1Pri;
                                    //click look
                                    if (clickCon < 2)
                                        clickCon = 2;
                                }
                            
                        }
                    }
                }
                //cost plate
                o1p1 = op1Pri;
                if (o1p1 >= 10)
                {
                    while (o1p1 >= 10)
                    {
                        o1p1 -= 10;
                        o1p2 += 1;
                    }
                    if (o1p2 >= 10)
                    {
                        while (o1p2 >= 10)
                        {
                            o1p2 -= 10;
                            o1p3 += 1;
                        }
                    }
                }

                o1n1 = op1Num;
                //bought plate
                if (o1n1 >= 10)
                {
                    while (o1n1 >= 10)
                    {
                        o1n1 -= 10;
                        o1n2 += 1;
                    }
                }
                

                //SECOND OPTION
                op2Pri = (int)(50.0* System.Math.Pow(1.2, op2Num));
                shopCon2 = 0;
                    if (clicks >= op2Pri)
                    {
                        shopCon2 = 1;
                        if (mousePosition.X > 400 & mousePosition.X < 800 & mousePosition.Y > 103 & mousePosition.Y < 153)
                        {
                            shopCon2 = 2;
                            //sec +1
                            if (state.LeftButton != hold)
                            {
                                if (state.LeftButton == ButtonState.Pressed)
                                {
                                op2Num += 1;
                                sAmount += 1;
                                    clicks -= op2Pri;
                                }
                            }
                        }
                    }

                //cost plate
                o2p1 = op2Pri;
                if (o2p1 >= 10)
                {
                    while (o2p1 >= 10)
                    {
                        o2p1 -= 10;
                        o2p2 += 1;
                    }
                    if (o2p2 >= 10)
                    {
                        while (o2p2 >= 10)
                        {
                            o2p2 -= 10;
                            o2p3 += 1;
                        }
                    }
                }

                o2n1 = op2Num;
                //bought plate
                if (o2n1 >= 10)
                {
                    while (o2n1 >= 10)
                    {
                        o2n1 -= 10;
                        o2n2 += 1;
                    }
                }

                //THIRD OPTION
                op3Pri = (int)(125.0 * System.Math.Pow(1.2, op3Num));
                shopCon3 = 0;
                if (clicks > op3Pri)
                {
                    shopCon3 = 1;
                    if (mousePosition.X > 400 & mousePosition.X < 800 & mousePosition.Y > 155 & mousePosition.Y < 205)
                    {
                        shopCon3 = 2;
                        //click +2
                        if (state.LeftButton != hold)
                        {
                            if (state.LeftButton == ButtonState.Pressed)
                            {
                                op3Num += 1;
                                cAmount += 2;
                                    clicks -= op3Pri;
                                    //click look
                                    if (clickCon < 3)
                                        clickCon = 3;
                                }
                            }
                        }
                    }

                //cost plate
                o3p1 = op3Pri;
                if (o3p1 >= 10)
                {
                    while (o3p1 >= 10)
                    {
                        o3p1 -= 10;
                        o3p2 += 1;
                    }
                    if (o3p2 >= 10)
                    {
                        while (o3p2 >= 10)
                        {
                            o3p2 -= 10;
                            o3p3 += 1;
                        }
                    }
                }

                o3n1 = op3Num;
                //bought plate
                if (o3n1 >= 10)
                {
                    while (o3n1 >= 10)
                    {
                        o3n1 -= 10;
                        o3n2 += 1;
                    }
                }

                //FOURTH OPTION
                op4Pri = (int)(500.0 * System.Math.Pow(1.2, op4Num));
                shopCon4 = 0;
                if (clicks > op4Pri)
                {
                    shopCon4 = 1;
                    if (mousePosition.X > 400 & mousePosition.X < 800 & mousePosition.Y > 207 & mousePosition.Y < 257)
                    {
                        shopCon4 = 2;
                         //sec +2
                        if (state.LeftButton != hold)
                        {
                            if (state.LeftButton == ButtonState.Pressed)
                            {
                                op4Num += 1;
                                sAmount += 2;
                                    clicks -= op4Pri;
                                }
                            }
                        }
                    }

                //cost plate
                o4p1 = op4Pri;
                if (o4p1 >= 10)
                {
                    while (o4p1 >= 10)
                    {
                        o4p1 -= 10;
                        o4p2 += 1;
                    }
                    if (o4p2 >= 10)
                    {
                        while (o4p2 >= 10)
                        {
                            o4p2 -= 10;
                            o4p3 += 1;
                        }
                    }
                }

                o4n1 = op4Num;
                //bought plate
                if (o4n1 >= 10)
                {
                    while (o4n1 >= 10)
                    {
                        o4n1 -= 10;
                        o4n2 += 1;
                    }
                }

                //clicker shit

                clicks += sAmount * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    x1 = clicks;
                    if (mousePosition.X < 400 & mousePosition.Y > 50)
                    {//mousing over (highlights)
                        H = true;
                        if (state.LeftButton != hold)
                        {//check not holding
                            if (state.LeftButton == ButtonState.Pressed)
                            {//add click
                                clicks += cAmount;
                            }
                        }
                    }
                    else {//not hovering
                        H = false;
                    }
                    x1 = clicks;
                    //**DISPLAY SYSTEM**
                    if (x1 >= 10)
                    {
                        while (x1 >= 10)
                        {
                            x1 -= 10;
                            x2 += 1;
                        }
                        if (x2 >= 10)
                        {
                            while (x2 >= 10)
                            {
                                x2 -= 10;
                                x3 += 1;
                            }
                            if (x3 >= 10)
                            {
                                while (x3 >= 10)
                                {
                                    x3 -= 10;
                                    x4 += 1;
                                }
                                if (x4 >= 10)
                                {
                                    while (x4 >= 10)
                                    {
                                        x4 -= 10;
                                        x5 += 1;
                                    }
                                    if (x5 >= 10)
                                    {
                                        while (x5 >= 10)
                                        {
                                            x5 -= 10;
                                            x6 += 1;
                                        }
                                        if (x6 >= 10)
                                        {
                                            while (x6 >= 10)
                                            {
                                                x6 -= 10;
                                                x7 += 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //resets values
                    spX1 = x1 * 50;
                    spX2 = x2 * 50;
                    spX3 = x3 * 50;
                    spX4 = x4 * 50;
                    spX5 = x5 * 50;
                    spX6 = x6 * 50;
                    spX7 = x7 * 50;
                    x1 = 0;
                    x2 = 0;
                    x3 = 0;
                    x4 = 0;
                    x5 = 0;
                    x6 = 0;
                    x7 = 0;
                    hold = Mouse.GetState().LeftButton;

                Op1Y = shopCon1 * 50;
                Op2Y = shopCon2 * 50;
                Op3Y = shopCon3 * 50;
                Op4Y = shopCon4 * 50;

                    base.Update(gameTime);
                }
            }
        


        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            //numbers
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX7, 50, 50), position: new Vector2(0, 0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX6, 50, 50), position: new Vector2(50, 0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX5, 50, 50), position: new Vector2(100,0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX4, 50, 50), position: new Vector2(150, 0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX3, 50, 50), position: new Vector2(200, 0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX2, 50, 50), position: new Vector2(250, 0));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)spX1, 50, 50), position: new Vector2(300, 0));

            //shop highlight shit 
            spriteBatch.Draw(shop, position: new Vector2(400, 50));
            spriteBatch.Draw(shopOp1, sourceRectangle: new Rectangle(0, (int)Op1Y, 400, 50), position: new Vector2(400, 51));
            spriteBatch.Draw(shopOp2, sourceRectangle: new Rectangle(0, (int)Op2Y, 400, 50), position: new Vector2(400, 103));
            spriteBatch.Draw(shopOp3, sourceRectangle: new Rectangle(0, (int)Op3Y, 400, 50), position: new Vector2(400, 155));
            spriteBatch.Draw(shopOp4, sourceRectangle: new Rectangle(0, (int)Op4Y, 400, 50), position: new Vector2(400, 207));

            //numbers shop
            //BOUGHT
            //1
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o1n1 * 50), 50, 50), position: new Vector2(450, 51));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o1n2 * 50), 50, 50), position: new Vector2(400, 51));
            //2
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o2n1 * 50), 50, 50), position: new Vector2(450, 103));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o2n2 * 50), 50, 50), position: new Vector2(400, 103));
            //3
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o3n1 * 50), 50, 50), position: new Vector2(450, 155));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o3n2 * 50), 50, 50), position: new Vector2(400, 155));
            //4
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o4n1 * 50), 50, 50), position: new Vector2(450, 207));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o4n2 * 50), 50, 50), position: new Vector2(400, 207));
            //PRICE
            //1
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o1p1 * 50), 50, 50), position: new Vector2(800, 51));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o1p2 * 50), 50, 50), position: new Vector2(750, 51));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o1p3 * 50), 50, 50), position: new Vector2(700, 51));
            //2
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o2p1 * 50), 50, 50), position: new Vector2(800, 103));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o2p2 * 50), 50, 50), position: new Vector2(750, 103));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o2p3 * 50), 50, 50), position: new Vector2(700, 103));
            //3
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o3p1 * 50), 50, 50), position: new Vector2(800, 155));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o3p2 * 50), 50, 50), position: new Vector2(750, 155));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o3p3 * 50), 50, 50), position: new Vector2(700, 155));
            //4
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o4p1 * 50), 50, 50), position: new Vector2(800, 207));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o4p2 * 50), 50, 50), position: new Vector2(750, 207));
            spriteBatch.Draw(numSp, sourceRectangle: new Rectangle(0, (int)(o4p3 * 50), 50, 50), position: new Vector2(700, 207));

            //click pic
            if (clickCon == 2) {
                if (H == false)
                {
                    spriteBatch.Draw(clickSpc2, position: new Vector2(0, 50));
                }
                else {
                    spriteBatch.Draw(clickSpc2H, position: new Vector2(0, 50));
                }
            }
            else if (clickCon == 3) {
                if (H == false)
                {
                    spriteBatch.Draw(clickSpc3, position: new Vector2(0, 50));
                }
                else {
                    spriteBatch.Draw(clickSpc3H, position: new Vector2(0, 50));
                }
            }
            else {
                if (H == false)
                {
                    spriteBatch.Draw(clickSpc, position: new Vector2(0, 50));
                }
                else {
                    spriteBatch.Draw(clickSpcH, position: new Vector2(0, 50));
                }
            }
            //end
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}