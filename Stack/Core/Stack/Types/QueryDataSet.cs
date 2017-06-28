/* ========================================================================
 * Copyright (c) 2005-2017 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Reciprocal Community License ("RCL") Version 1.00
 * 
 * Unless explicitly acquired and licensed from Licensor under another 
 * license, the contents of this file are subject to the Reciprocal 
 * Community License ("RCL") Version 1.00, or subsequent versions
 * as allowed by the RCL, and You may not copy or use this file in either 
 * source code or executable form, except in compliance with the terms and 
 * conditions of the RCL.
 * 
 * All software distributed under the RCL is provided strictly on an 
 * "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, 
 * AND LICENSOR HEREBY DISCLAIMS ALL SUCH WARRANTIES, INCLUDING WITHOUT 
 * LIMITATION, ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
 * PURPOSE, QUIET ENJOYMENT, OR NON-INFRINGEMENT. See the RCL for specific 
 * language governing rights and limitations under the RCL.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/RCL/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Opc.Ua
{
    #region NodeTypeDescription Class
    public partial class NodeTypeDescription
    {
        #region Supporting Properties and Methods
        /// <summary>
        /// A handle assigned to the item during processing.
        /// </summary>
        public object Handle { get; set; }
        
        /// <summary>
        /// Whether the value has been processed.
        /// </summary>
        public bool Processed { get; set; }
        #endregion
                            
        #region Private Fields
        #endregion
    }
    #endregion

    #region QueryDataDescription Class
    public partial class QueryDataDescription
    {
        /// <summary>
        /// Stores the parsed form of the index range parameter.
        /// </summary>
        public NumericRange ParsedIndexRange { get; set; }
    }
    #endregion
}
