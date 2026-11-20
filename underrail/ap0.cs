using System;
using System.Runtime.Serialization;

// Token: 0x02001A54 RID: 6740
[eiz("IE2")]
[Serializable]
public sealed class ap0 : d3e, ISerializable
{
	// Token: 0x0600924D RID: 37453 RVA: 0x0039F0E4 File Offset: 0x0039D2E4
	private ap0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600924E RID: 37454 RVA: 0x0039F0F4 File Offset: 0x0039D2F4
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.b = true;
		A_0.a().Defense.a(0);
		A_0.a().Defense.c(0);
	}

	// Token: 0x0600924F RID: 37455 RVA: 0x0039F134 File Offset: 0x0039D334
	public ap0()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x06009250 RID: 37456 RVA: 0x0039F148 File Offset: 0x0039D348
	public override d3e b3()
	{
		ap0 ap = new ap0();
		this.xx(ap);
		return ap;
	}
}
