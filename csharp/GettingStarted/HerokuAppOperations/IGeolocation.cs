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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IGeolocation
    {
        // This method is called when the user clicks the "Where am I?" button or performs an action
        // to determine their current geolocation.
        public void OnclickWhereami();

     // This method retrieves and displays the location details such as latitude, longitude,
     // based on the current geolocation.
        public void GetLocationDetails();
     // This method is invoked when the user clicks a "Show in Maps" button 
     // to open the current geolocation in a mapping application, such as Google Maps.
        public void OnclickShowInMaps();
    }
}
