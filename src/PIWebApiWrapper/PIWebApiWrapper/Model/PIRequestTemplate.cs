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

	[Guid("B485C349-DDE8-48D9-8155-076B0578F269")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIRequestTemplate
	{
		[DispId(1)]
		string Resource { get; set; }

	}

	[Guid("89AB8F3E-6E3A-49C0-A29E-9F4CF697AFF5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIRequestTemplate))]
	[ProgId("PIWebAPIWrapper.PIRequestTemplate")]
	[DataContract]

	public class PIRequestTemplate : IPIRequestTemplate
	{
		public PIRequestTemplate()
		{
		}

		[DataMember(Name = "Resource", EmitDefaultValue = false)]
		public string Resource { get; set; }

	}
}
