﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.34014
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using ClusterMessages;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mini.pw.edu.pl/ucc/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ucc/", IsNullable=false)]
public partial class Status : IClusterMessage
{
    
    private ulong idField;
    
    private StatusThread[] threadsField;
    
    /// <uwagi/>
    public ulong Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Thread", IsNullable=false)]
    public StatusThread[] Threads {
        get {
            return this.threadsField;
        }
        set {
            this.threadsField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mini.pw.edu.pl/ucc/")]
public partial class StatusThread {
    
    private StatusThreadState stateField;
    
    private ulong howLongField;
    
    private bool howLongFieldSpecified;
    
    private ulong problemInstanceIdField;
    
    private bool problemInstanceIdFieldSpecified;
    
    private ulong taskIdField;
    
    private bool taskIdFieldSpecified;
    
    private string problemTypeField;
    
    /// <uwagi/>
    public StatusThreadState State {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <uwagi/>
    public ulong HowLong {
        get {
            return this.howLongField;
        }
        set {
            this.howLongField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HowLongSpecified {
        get {
            return this.howLongFieldSpecified;
        }
        set {
            this.howLongFieldSpecified = value;
        }
    }
    
    /// <uwagi/>
    public ulong ProblemInstanceId {
        get {
            return this.problemInstanceIdField;
        }
        set {
            this.problemInstanceIdField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ProblemInstanceIdSpecified {
        get {
            return this.problemInstanceIdFieldSpecified;
        }
        set {
            this.problemInstanceIdFieldSpecified = value;
        }
    }
    
    /// <uwagi/>
    public ulong TaskId {
        get {
            return this.taskIdField;
        }
        set {
            this.taskIdField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TaskIdSpecified {
        get {
            return this.taskIdFieldSpecified;
        }
        set {
            this.taskIdFieldSpecified = value;
        }
    }
    
    /// <uwagi/>
    public string ProblemType {
        get {
            return this.problemTypeField;
        }
        set {
            this.problemTypeField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mini.pw.edu.pl/ucc/")]
public enum StatusThreadState {
    
    /// <uwagi/>
    Idle,
    
    /// <uwagi/>
    Busy,
}
