﻿using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Payload
{
    public class SendFeedbackPayload : Payload
    {
        public Feedback? Feedback { get; }
        public SendFeedbackPayload(Feedback feedback)
        {
            Feedback = feedback;
        }

        public SendFeedbackPayload(UserError error) : base(error) { }
    }
}
