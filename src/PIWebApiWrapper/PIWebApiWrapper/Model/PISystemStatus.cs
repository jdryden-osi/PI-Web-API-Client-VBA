// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("EC6C39AF-8784-49E5-BAC6-2C2A1506CF06")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISystemStatus
	{
		[DispId(1)]
		double UpTimeInMinutes { get; set; }

		[DispId(2)]
		string State { get; set; }

		[DispId(3)]
		int CacheInstances { get; set; }

	}

	[Guid("90955B82-925D-4F8B-86EF-E9C1C221B301")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISystemStatus))]
	[ProgId("PIWebAPIWrapper.PISystemStatus")]
	[DataContract]

	public class PISystemStatus : IPISystemStatus
	{
		public PISystemStatus()
		{
		}

		[DataMember(Name = "UpTimeInMinutes", EmitDefaultValue = false)]
		public double UpTimeInMinutes { get; set; }

		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		[DataMember(Name = "CacheInstances", EmitDefaultValue = false)]
		public int CacheInstances { get; set; }

	}
}
