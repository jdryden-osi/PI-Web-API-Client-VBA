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

	[Guid("CA335846-5482-4FBF-BD1C-8C6D682E65B9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeValueQuery
	{
		[DispId(1)]
		string AttributeName { get; set; }

		[DispId(2)]
		object AttributeValue { get; set; }

		[DispId(3)]
		string AttributeUOM { get; set; }

		[DispId(4)]
		string SearchOperator { get; set; }

	}

	[Guid("18D853C3-3AB3-4A58-A66E-39B1D8EAC92A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeValueQuery))]
	[ProgId("PIWebAPIWrapper.PIAttributeValueQuery")]
	[DataContract]

	public class PIAttributeValueQuery : IPIAttributeValueQuery
	{
		public PIAttributeValueQuery()
		{
		}

		[DataMember(Name = "AttributeName", EmitDefaultValue = false)]
		public string AttributeName { get; set; }

		[DataMember(Name = "AttributeValue", EmitDefaultValue = false)]
		public object AttributeValue { get; set; }

		[DataMember(Name = "AttributeUOM", EmitDefaultValue = false)]
		public string AttributeUOM { get; set; }

		[DataMember(Name = "SearchOperator", EmitDefaultValue = false)]
		public string SearchOperator { get; set; }

	}
}
