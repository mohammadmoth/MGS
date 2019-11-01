﻿using System;
using System.Collections.Generic;
using System.Text;
using ServerGame.Interface.Event;
using ServerGame.Event;
using ServerGame;
using ServerGame.Program.Data;

namespace ServerGame.Core.Event
{
    public abstract class MessageSenderAbstract : IMessageSender
    {
        private string _eventName;
        public string EventName { get => _eventName; set => _eventName = value; }

        public abstract event EventHandler<MessageSenderEventArgs> MessageSending;
        public abstract event EventHandler<MessageSenderEventArgs> MessageSent;

        public abstract void OnMessageSending(Message msg);
        public abstract void OnMessageSent(Message msg);
    }
}
