//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatServer.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChatMessage
    {
        public int Id { get; set; }
        public int ChatRoomId { get; set; }
        public int ParticipantId { get; set; }
        public string Message { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ChatRoom ChatRoom { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
