﻿using System;
using System.Collections.Generic;
using System.Text;
using ServerGame.Interface.Permissions;

namespace ServerGame.Program.Room
{
   public class Room : Core.Room.RoomAbstract
    {
        public   string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  int MaxPlayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
          IPermissionsUser PermissionsUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  List<IUser> UserInRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  DateTime DateStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  DateTime DataEnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected  List<Ievnet> _MyEvnets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public Room ()
        {
        


        }
        public  bool AddEventListener(Ievnet evnet)
        {
            Console.WriteLine("fuck");
            return false;
        }

        public  bool JoinUserToRoom(IUser User)
        {
            throw new NotImplementedException();
        }

        public  bool Test()
        {
            throw new NotImplementedException();
        }

        protected  bool _AddNewUser(IUser User)
        {
            throw new NotImplementedException();
        }

        protected  bool _CheckBlackList(IUser InputUserToSendData)
        {
            throw new NotImplementedException();
        }

        protected  bool _CheckPermissionsUser(IUser InputUserToSendData)
        {
            throw new NotImplementedException();
        }
    }
}
