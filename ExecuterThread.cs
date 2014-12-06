using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;
using Insomart;

namespace Insomiris
{
    public class ExecuterThread
    {
        private Image originalImage;
        private Image transformImage;
        private TransformAction action;
        private TransformData data;
        private bool doRotate = false;
        private bool isRunning = false;
        private mainScreen baseForm1;

        public Image Result
        {
            get
            {
                return transformImage;
            }
        }

        public bool Rotate
        {
            set
            {
                if (!isRunning)
                {
                    this.doRotate = value;
                }
            }
        }

        public TransformData Data
        {
            set
            {
                if (!isRunning)
                {
                    this.data = value;
                }
            }
        }

        public TransformAction Action
        {
            set
            {
                if (!isRunning)
                {
                    this.action = value;
                }
            }
        }

        public Image OriginalImage
        {
            set
            {
                if (!isRunning)
                {
                    this.originalImage = value;
                }
            }
        }

        public ExecuterThread(Image origImage, Image transformImage, mainScreen baseForm1)
        {
            this.originalImage = origImage;
            this.transformImage = transformImage;
            this.isRunning = false;
            this.baseForm1 = baseForm1;
        }

        public void Run()
        {
            if (!isRunning)
            {
                isRunning = true;
                transformImage = Insomart.Insom.Transform(originalImage, action, data);
                if (doRotate)
                {
                    transformImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                isRunning = false;
                baseForm1.RefreshUI();
            }
        }

        internal bool IsRunning()
        {
            return isRunning;
        }
    }
}
