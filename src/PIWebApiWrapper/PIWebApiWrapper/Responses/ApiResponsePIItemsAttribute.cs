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
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("56103532-B676-4BE6-9D36-7D619F8769DE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttribute
	{
		[DispId(1)]
		PIItemsAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E61F43CF-CE23-4C4A-A81D-9FB3EC10BCE7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttribute")]
	public class ApiResponsePIItemsAttribute : ApiParentResponse, IApiResponsePIItemsAttribute
	{
		public PIItemsAttribute Data { get; set; }
		public ApiResponsePIItemsAttribute(int statusCode, IDictionary<string, string> headers, PIItemsAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
