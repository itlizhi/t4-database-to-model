# t4-database-to-model
T4模板生成数据库模型，包括备注，目前支持sqlserver和mysql
```
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
    [Table("TUser")]
    public class TUser
    {
       
        [Key]
        public int ID { get; set; }
    
        /// <summary>
        /// 账号/邮箱
        /// </summary>
        public string Account { get; set; }
    
        public string Password { get; set; }
    
        public string Email { get; set; }
    
        public string Mobile { get; set; }
    
        /// <summary>
        /// 测试
        /// </summary>
        public byte RoleID { get; set; }
    
        /// <summary>
        /// 用户名
        /// </summary>
        public string Creator { get; set; }
    
        public DateTime CreateDateTime { get; set; }
    
        /// <summary>
        /// 修改
        /// </summary>
        public string Modifier { get; set; }
    
        public DateTime ModifyDateTime { get; set; }
    
        public bool IsValid { get; set; }
    }

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



```
