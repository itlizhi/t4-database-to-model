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
 
	[Table("mitpk")]
    public class mitpk
    {
       
        [Key]
	    public int pk1 { get; set; }
	    [ExplicitKey]
        public string pk2 { get; set; }
    
        public DateTime addtime { get; set; }
    }
}
