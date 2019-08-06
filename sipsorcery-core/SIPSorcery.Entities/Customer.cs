//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSorcery.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public bool Active { get; set; }
        public string AdminID { get; set; }
        public string AdminMemberID { get; set; }
        public string AuthorisedApps { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CreatedFromIPAddress { get; set; }
        public string CustomerPassword { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailAddressConfirmed { get; set; }
        public int ExecutionCount { get; set; }
        public string Firstname { get; set; }
        public string ID { get; set; }
        public string Inserted { get; set; }
        public string InviteCode { get; set; }
        public string Lastname { get; set; }
        public int MaxExecutionCount { get; set; }
        public string PasswordResetID { get; set; }
        public string PasswordResetIDSetAt { get; set; }
        public string SecurityAnswer { get; set; }
        public string SecurityQuestion { get; set; }
        public bool Suspended { get; set; }
        public string SuspendedReason { get; set; }
        public string Timezone { get; set; }
        public string WebSite { get; set; }
        public string APIKey { get; set; }
        public string ServiceLevel { get; set; }
        public string usernamerecoveryidsetat { get; set; }
        public Nullable<int> usernamerecoveryfailurecount { get; set; }
        public string usernamerecoverylastattemptat { get; set; }
        public string usernamerecoveryid { get; set; }
        public string ServiceRenewalDate { get; set; }
        public string RTCCInternationalPrefixes { get; set; }
        public string Salt { get; set; }
        public string FTPPrefix { get; set; }
        public string RTCCReconciliationURL { get; set; }
    }
}
