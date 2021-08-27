using Colyseus.Schema;

namespace RealtimeArena.Room
{
	public partial class GamePlayer : Schema
	{
		[Type(0, "string")]
		public string id = default(string);

		[Type(1, "string")]
		public string profileName = default(string);

		[Type(2, "int32")]
		public int exp = default(int);

		[Type(3, "int32")]
		public int teamBP = default(int);

		[Type(4, "string")]
		public string mainCharacter = default(string);

		[Type(5, "int32")]
		public int mainCharacterExp = default(int);

		[Type(6, "uint8")]
		public byte team = 0;

		[Type(7, "uint8")]
		public byte state = 0;
	}
}
