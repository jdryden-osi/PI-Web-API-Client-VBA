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

	[Guid("7D1F4CA2-6F2D-4076-8C8B-E11791139BAE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIVersion
	{
		[DispId(1)]
		string FullVersion { get; set; }

		[DispId(2)]
		string MajorMinorRevision { get; set; }

		[DispId(3)]
		string Build { get; set; }

	}

	[Guid("90F3C60E-A7BC-4833-BFE2-246302AA7BE6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIVersion))]
	[ProgId("PIWebAPIWrapper.PIVersion")]
	[DataContract]

	public class PIVersion : IPIVersion
	{
		public PIVersion()
		{
		}

		[DataMember(Name = "FullVersion", EmitDefaultValue = false)]
		public string FullVersion { get; set; }

		[DataMember(Name = "MajorMinorRevision", EmitDefaultValue = false)]
		public string MajorMinorRevision { get; set; }

		[DataMember(Name = "Build", EmitDefaultValue = false)]
		public string Build { get; set; }

	}
}
