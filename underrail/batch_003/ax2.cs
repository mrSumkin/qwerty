using System;
using System.Runtime.Serialization;

// Token: 0x02001A53 RID: 6739
[eiz("IE1")]
[Serializable]
public sealed class ax2 : d3e, ISerializable
{
	// Token: 0x06009249 RID: 37449 RVA: 0x0039F064 File Offset: 0x0039D264
	private ax2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600924A RID: 37450 RVA: 0x0039F074 File Offset: 0x0039D274
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.c = true;
		A_0.a().Defense.a(0);
		A_0.a().Defense.c(0);
	}

	// Token: 0x0600924B RID: 37451 RVA: 0x0039F0B4 File Offset: 0x0039D2B4
	public ax2()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x0600924C RID: 37452 RVA: 0x0039F0C8 File Offset: 0x0039D2C8
	public override d3e b3()
	{
		ax2 ax = new ax2();
		this.xx(ax);
		return ax;
	}
}
