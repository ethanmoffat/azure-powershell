// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Insights.Legacy.Models;

namespace Microsoft.Azure.Insights.Legacy
{
    /// <summary>
    /// Operations for metric definitions.
    /// </summary>
    public partial interface IMetricDefinitionOperations
    {
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// The resource identifier of the target resource to get metrics for.
        /// </param>
        /// <param name='filterString'>
        /// An OData $filter expression that supports querying by the name of
        /// the metric definition. For example, "name.value eq 'Percentage
        /// CPU'". Name is optional, meaning the expression may be "".
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        Task<MetricDefinitionListResponse> GetMetricDefinitionsAsync(string resourceUri, string filterString, CancellationToken cancellationToken);
    }
}
