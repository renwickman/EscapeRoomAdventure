using System;

namespace EscapeRoomAdventure
{
  interface ISystem
  {
    void Operate();
    string Status { get; set; }
  }
}