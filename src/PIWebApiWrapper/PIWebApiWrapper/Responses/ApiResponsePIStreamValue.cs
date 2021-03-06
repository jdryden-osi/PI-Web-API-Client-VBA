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
	[Guid("22CFC241-3F17-4105-A8C1-B243490A59C8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValue
	{
		[DispId(1)]
		PIStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("16172074-27BE-4B5D-A1EA-64586F0FB218")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValue")]
	public class ApiResponsePIStreamValue : ApiParentResponse, IApiResponsePIStreamValue
	{
		public PIStreamValue Data { get; set; }
		public ApiResponsePIStreamValue(int statusCode, IDictionary<string, string> headers, PIStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
