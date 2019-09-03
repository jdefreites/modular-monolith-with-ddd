﻿using System;
using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Meetings.Domain.Members;

namespace CompanyName.MyMeetings.Modules.Meetings.Domain.Meetings.Events
{
    public class MeetingAttendeeAddedDomainEvent : DomainEventBase
    {
        public MeetingAttendeeAddedDomainEvent(
            MeetingId meetingId, 
            MemberId attendeeId, 
            DateTime rsvpDate, 
            MeetingAttendeeRole role, 
            int guestsNumber,
            MoneyValue fee)
        {
            MeetingId = meetingId;
            AttendeeId = attendeeId;
            RSVPDate = rsvpDate;
            Role = role;
            GuestsNumber = guestsNumber;
            Fee = fee;
        }

        public MeetingId MeetingId { get; }
        public MemberId AttendeeId { get; }

        public DateTime RSVPDate { get; }

        public MeetingAttendeeRole Role { get; }

        public int GuestsNumber { get; }

        public MoneyValue Fee { get; }
    }
}