using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020015E6 RID: 5606
[eiz("SKLHAA")]
[Serializable]
public abstract class a4h : a6k, ISerializable
{
	// Token: 0x06007B8C RID: 31628 RVA: 0x0033ACBC File Offset: 0x00338EBC
	protected a4h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B8D RID: 31629 RVA: 0x0033ACC8 File Offset: 0x00338EC8
	protected a4h()
	{
	}

	// Token: 0x06007B8E RID: 31630 RVA: 0x0033ACD0 File Offset: 0x00338ED0
	protected CharacterState a()
	{
		bke bke = base.vg().e().b8().Offense.u().TypedDefinition;
		if (string.Equals(bke.ac(), "k", StringComparison.OrdinalIgnoreCase))
		{
			return CharacterState.Custom2;
		}
		if (string.Equals(bke.ac(), "s", StringComparison.OrdinalIgnoreCase))
		{
			return CharacterState.Custom3;
		}
		if (string.Equals(bke.ac(), "xpbls", StringComparison.OrdinalIgnoreCase))
		{
			return CharacterState.Custom4;
		}
		if (string.Equals(bke.ac(), "xpblm", StringComparison.OrdinalIgnoreCase))
		{
			return CharacterState.Custom5;
		}
		return CharacterState.Custom1;
	}
}
