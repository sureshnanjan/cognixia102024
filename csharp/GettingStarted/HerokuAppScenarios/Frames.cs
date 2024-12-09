/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/

using System;
using NUnit.Framework;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    public class IFramesTests
    {
        // Test implementation of the IFrames interface
        public class FramesImplementation : IFrames
        {
            public bool NestedFramesClicked { get; private set; }
            public bool TopFrameChecked { get; private set; }
            public bool BottomFrameChecked { get; private set; }
            public bool LeftFrameChecked { get; private set; }
            public bool RightFrameChecked { get; private set; }
            public bool MiddleFrameChecked { get; private set; }
            public bool IFrameClicked { get; private set; }

            public void OnClickingNestedframes()
            {
                NestedFramesClicked = true;
            }

            public void CheckTopframe()
            {
                TopFrameChecked = true;
            }

            public void CheckBottomframe()
            {
                BottomFrameChecked = true;
            }

            public void CheckLeftframe()
            {
                LeftFrameChecked = true;
            }

            public void CheckRightframe()
            {
                RightFrameChecked = true;
            }

            public void CheckMiddleframe()
            {
                MiddleFrameChecked = true;
            }

            public void OnClickingiFrame()
            {
                IFrameClicked = true;
            }
        }

        [Test]
        public void TestOnClickingNestedframes()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.OnClickingNestedframes();

            // Assert
            Assert.IsTrue(frames.NestedFramesClicked);
        }

        [Test]
        public void TestCheckTopframe()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.CheckTopframe();

            // Assert
            Assert.IsTrue(frames.TopFrameChecked);
        }

        [Test]
        public void TestCheckBottomframe()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.CheckBottomframe();

            // Assert
            Assert.IsTrue(frames.BottomFrameChecked);
        }

        [Test]
        public void TestCheckLeftframe()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.CheckLeftframe();

            // Assert
            Assert.IsTrue(frames.LeftFrameChecked);
        }

        [Test]
        public void TestCheckRightframe()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.CheckRightframe();

            // Assert
            Assert.IsTrue(frames.RightFrameChecked);
        }

        [Test]
        public void TestCheckMiddleframe()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.CheckMiddleframe();

            // Assert
            Assert.IsTrue(frames.MiddleFrameChecked);
        }

        [Test]
        public void TestOnClickingiFrame()
        {
            // Arrange
            var frames = new FramesImplementation();

            // Act
            frames.OnClickingiFrame();

            // Assert
            Assert.IsTrue(frames.IFrameClicked);
        }
    }
}
