//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CountessQuantaControl
{
    using System;
    using System.Collections.Generic;
    
    public partial class GestureOperator
    {
        public int GestureOperatorID { get; set; }
        public string GestureName { get; set; }
        public Nullable<int> OperatorID { get; set; }
    
        public virtual Operator Operator { get; set; }
    }
}
