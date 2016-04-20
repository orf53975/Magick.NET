﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
  [TestClass]
  public partial class OpenCLDeviceTests
  {
    private const string _Category = "OpenCLDevice";

    [TestMethod, TestCategory(_Category)]
    public void Test_Name()
    {
      foreach (OpenCLDevice device in OpenCL.Devices)
      {
        Assert.IsNotNull(device.Name);
      }
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_IsEnabled()
    {
      foreach (OpenCLDevice device in OpenCL.Devices)
      {
        bool isEnabled = device.IsEnabled;

        device.IsEnabled = !isEnabled;
        Assert.AreNotEqual(isEnabled, device.IsEnabled);

        device.IsEnabled = isEnabled;
        Assert.AreEqual(isEnabled, device.IsEnabled);
      }
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_Type()
    {
      foreach (OpenCLDevice device in OpenCL.Devices)
      {
        Assert.AreNotEqual(OpenCLDeviceType.Undefined, device.DeviceType);
      }
    }

    [TestMethod, TestCategory(_Category)]
    public void Test_Version()
    {
      foreach (OpenCLDevice device in OpenCL.Devices)
      {
        Assert.IsNotNull(device.Version);
      }
    }
  }
}