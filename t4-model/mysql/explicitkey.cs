//-----------------------------------------------------------------------
//<copyright>
// * Copyright (C) 2016 NERICHIST All Rights Reserved
// * version : 4.0.30319.42000
// * author  : lizhi by t4
// </copyright>
//-----------------------------------------------------------------------

using System;
using Dapper.Contrib.Extensions;

namespace NSName
{
 
	[Table("explicitkey")]
    public class explicitkey
    {
	    [ExplicitKey]
        public string Guid { get; set; }
    
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    
        public bool Isdelete { get; set; }
    
        public string test { get; set; }
    }
}
