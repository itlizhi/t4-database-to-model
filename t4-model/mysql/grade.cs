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
 
	[Table("grade")]
    public class grade
    {
       
        [Key]
	    public int ID { get; set; }
    
        public int? StudentID { get; set; }
    
        public string Grade { get; set; }
    
        public bool IsDelete { get; set; }
    }
}
