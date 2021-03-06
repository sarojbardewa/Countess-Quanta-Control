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
    
    public partial class Operator
    {
        public Operator()
        {
            this.ButtonOperators = new HashSet<ButtonOperator>();
            this.SpeechOperators = new HashSet<SpeechOperator>();
            this.GestureOperators = new HashSet<GestureOperator>();
        }
    
        public int OperatorID { get; set; }
        public int ParentOperatorID { get; set; }
        public Nullable<int> OperatorTypeID { get; set; }
        public Nullable<int> OptionID { get; set; }
        public decimal Weight { get; set; }
        public string LogicGate { get; set; }
    
        public virtual OperatorType OperatorType { get; set; }
        public virtual Option Option { get; set; }
        public virtual ICollection<ButtonOperator> ButtonOperators { get; set; }
        public virtual ICollection<SpeechOperator> SpeechOperators { get; set; }
        public virtual ICollection<GestureOperator> GestureOperators { get; set; }
    }
}
