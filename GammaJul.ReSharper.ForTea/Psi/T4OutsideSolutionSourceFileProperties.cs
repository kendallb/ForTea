﻿#region License
//    Copyright 2012 Julien Lebosquain
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion
using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi;
using JetBrains.Util;

namespace GammaJul.ReSharper.ForTea.Psi {

	internal sealed class T4OutsideSolutionSourceFileProperties : IPsiSourceFileProperties {

		public IEnumerable<string> GetPreImportedNamespaces() {
			return EmptyList<string>.InstanceList;
		}

		public string GetDefaultNamespace() {
			return String.Empty;
		}

		public bool ShouldBuildPsi {
			get { return true; }
		}

		public bool IsGeneratedFile {
			get { return false; }
		}

		public bool ProvidesCodeModel {
			get { return true; }
		}

		public bool IsNonUserFile {
			get { return false; }
		}

		public ICollection<PreProcessingDirective> GetDefines() {
			return EmptyList<PreProcessingDirective>.InstanceList;
		}

		public bool IsICacheParticipant {
			get { return false; }
		}

	}

}