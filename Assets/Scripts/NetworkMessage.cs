[System.Serializable]
public class NetworkMessage
{
   public string _opCode;
   public string _playerSessionId;

   public NetworkMessage(string opCode, string playerSessionId)
   {
      _opCode = opCode;
      _playerSessionId = playerSessionId;
   }
}
