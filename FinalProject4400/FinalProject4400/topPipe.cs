﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Windows.Threading;

namespace FinalProject4400
{
    class topPipe : flappyBaseClass
    {
        BitmapImage top;
        BitmapImage bottom;
        //double minX = 0.0;
        double pipeHeight = 500;
        double gameAreaWidth = 0;
        double gameAreaHeight = 0;
        Image newPipe;
        private Boolean goLeft = true;
        private Thread posnThread = null;
        private Int32 waitTime;
        double incrementSize = 1;

        public topPipe(Canvas gameArea, Dispatcher dispatcher, Int32 waitTime) : base(gameArea, dispatcher, waitTime)
        {
            //kingdomWidth = (int)this.kingdom.ActualWidth;
            //maxX = kingdomWidth - Creaturewidth;

            top = LoadBitmap(@"pipeTop.png", pipeHeight);
            bottom = LoadBitmap(@"pipeBottom.png", pipeHeight);

            newPipe = new Image();
            newPipe.Source = top;

            newPipe.Height = pipeHeight;
            //waitTime = this.waitTime;
            //MessageBox.Show(waitTime.ToString());
        }


        public override void Place(double x, double random)
        {
            this.x = gameArea.ActualWidth;
            this.y = -300 + random;

            this.waitTime = 10;

            gameArea.Children.Add(newPipe);
            newPipe.SetValue(Canvas.RightProperty, this.x);
            newPipe.SetValue(Canvas.TopProperty, this.y);

            posnThread = new Thread(Position);

            posnThread.Start();
        }

        void Position()
        {
            while (true)
            {
                if (Paused == false)
                {
                    if (goLeft)
                    {
                        x -= incrementSize;
                        this.ActualHeight = newPipe.ActualHeight;
                        this.ActualWidth = newPipe.ActualWidth;
                        Action getInfo = delegate ()
                        {
                            this.GetLeft = Canvas.GetLeft(newPipe);
                            this.GetTop = Canvas.GetTop(newPipe);
                        };
                        gameArea.Dispatcher.Invoke(DispatcherPriority.Normal, getInfo);

                        if (x < -(newPipe.ActualWidth))
                        {
                            goLeft = false;
                        }
                    }
                    else
                    {
                        Shutdown();
                    }
                    UpdatePosition();
                }
                Thread.Sleep(waitTime);
            }
        }

        void UpdatePosition()
        {
            gameAreaWidth = (int)this.gameArea.ActualWidth;
            gameAreaHeight = (int)this.gameArea.ActualHeight;

            Action action = () => { newPipe.SetValue(Canvas.LeftProperty, x); newPipe.SetValue(Canvas.TopProperty, y); };
            dispatcher.BeginInvoke(action);
        }

        void SwitchBitmap(BitmapImage theBitmap)
        {
            /*
            Random r = new Random();
            Action action = () => { creature.Source = theBitmap; };
            dispatcher.BeginInvoke(action);
            dispatcher.Invoke(() =>
            {
                kingdom.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),(byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            });*/
        }

        public override location getLocation()
        {
            location topPipeLocation = new location();
            topPipeLocation.xLocation = this.x;
            topPipeLocation.yLocation = this.y;
            return topPipeLocation;
        }
            


        public override void Shutdown()
        {
            if (posnThread != null)
            {
                posnThread.Abort();
            }
        }
    }
}