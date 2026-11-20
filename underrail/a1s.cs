using System;
using System.Runtime.Serialization;

// Token: 0x02001A57 RID: 6743
[eiz("SE3")]
[Serializable]
public sealed class a1s : d3e, ISerializable
{
	// Token: 0x06009268 RID: 37480 RVA: 0x0039F620 File Offset: 0x0039D820
	private a1s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009269 RID: 37481 RVA: 0x0039F62C File Offset: 0x0039D82C
	public a1s()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x0600926A RID: 37482 RVA: 0x0039F640 File Offset: 0x0039D840
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.a = true;
		A_0.a().Defense.a(0);
		A_0.a().Defense.c(0);
	}

	// Token: 0x0600926B RID: 37483 RVA: 0x0039F680 File Offset: 0x0039D880
	public override d3e b3()
	{
		a1s a1s = new a1s();
		this.xx(a1s);
		return a1s;
	}
}
