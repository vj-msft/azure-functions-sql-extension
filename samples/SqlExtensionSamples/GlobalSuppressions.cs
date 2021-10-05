﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

// These suppression rules override parameters required by functions binding that cannot be converted to discard variables per issue: https://github.com/Azure/azure-functions-dotnet-worker/issues/323
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.AddProductsArray.Run(Microsoft.AspNetCore.Http.HttpRequest,SqlExtensionSamples.Product[]@)~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.AddProductsAsyncCollector.Run(Microsoft.AspNetCore.Http.HttpRequest,Microsoft.Azure.WebJobs.IAsyncCollector{SqlExtensionSamples.Product})~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.AddProductsCollector.Run(Microsoft.AspNetCore.Http.HttpRequest,Microsoft.Azure.WebJobs.ICollector{SqlExtensionSamples.Product})~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProducts.Run(Microsoft.AspNetCore.Http.HttpRequest,System.Collections.Generic.IEnumerable{SqlExtensionSamples.Product})~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProductsAsyncEnumerable.Run(Microsoft.AspNetCore.Http.HttpRequest,System.Collections.Generic.IAsyncEnumerable{SqlExtensionSamples.Product})~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProductsNameEmpty.Run(Microsoft.AspNetCore.Http.HttpRequest,System.Collections.Generic.IEnumerable{SqlExtensionSamples.Product})~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProductsNameNull.Run(Microsoft.AspNetCore.Http.HttpRequest,System.Collections.Generic.IEnumerable{SqlExtensionSamples.Product})~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProductsSqlCommand.Run(Microsoft.AspNetCore.Http.HttpRequest,Microsoft.Data.SqlClient.SqlCommand)~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.GetProductsStoredProcedure.Run(Microsoft.AspNetCore.Http.HttpRequest,System.Collections.Generic.IEnumerable{SqlExtensionSamples.Product})~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.InputBindingSamples.GetProductsString.Run(Microsoft.AspNetCore.Http.HttpRequest,System.String)~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Unused parameter is required by functions binding", Scope = "member", Target = "~M:SqlExtensionSamples.TimerTriggerProducts.Run(Microsoft.Azure.WebJobs.TimerInfo,Microsoft.Extensions.Logging.ILogger,Microsoft.Azure.WebJobs.ICollector{SqlExtensionSamples.Product})")]
