/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// See the example below for a sample response.
    /// </summary>
    public partial class DescribeInstancesHealthResponse : AmazonWebServiceResponse
    {
        private List<SingleInstanceHealth> _instanceHealthList = new List<SingleInstanceHealth>();
        private string _nextToken;
        private DateTime? _refreshedAt;

        /// <summary>
        /// Gets and sets the property InstanceHealthList. 
        /// <para>
        /// Contains the response body with information about the health of the instance.
        /// </para>
        /// </summary>
        public List<SingleInstanceHealth> InstanceHealthList
        {
            get { return this._instanceHealthList; }
            set { this._instanceHealthList = value; }
        }

        // Check to see if InstanceHealthList property is set
        internal bool IsSetInstanceHealthList()
        {
            return this._instanceHealthList != null && this._instanceHealthList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshedAt. 
        /// <para>
        /// The date and time the information was last refreshed.
        /// </para>
        /// </summary>
        public DateTime RefreshedAt
        {
            get { return this._refreshedAt.GetValueOrDefault(); }
            set { this._refreshedAt = value; }
        }

        // Check to see if RefreshedAt property is set
        internal bool IsSetRefreshedAt()
        {
            return this._refreshedAt.HasValue; 
        }

    }
}