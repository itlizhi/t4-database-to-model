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
 
	[Table("sys_user")]
    public class sys_user
    {
       
        [Key]
	    public int Id { get; set; }
    
        public string Email { get; set; }
    
        public string Password { get; set; }
    
        public string UserName { get; set; }
    
        /// <summary>
        /// 测试枚举字段
        /// </summary>
        public byte UserStatus { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDateTime { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        public string Modifier { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDateTime { get; set; }
    
        /// <summary>
        /// 是否删除，默认 false
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
