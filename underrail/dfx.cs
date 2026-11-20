using System;
using System.Runtime.Serialization;

// Token: 0x02000500 RID: 1280
[eiz("CCBE")]
[Serializable]
public sealed class dfx : bjs, b2h, ISerializable
{
	// Token: 0x0600211D RID: 8477 RVA: 0x000B1610 File Offset: 0x000AF810
	private dfx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000B161C File Offset: 0x000AF81C
	public dfx(ap9 A_0) : base(A_0, null)
	{
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000B162C File Offset: 0x000AF82C
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.m), string.Format("- {0} зовёт на помощь.", (base.h() != null) ? base.h().a() : base.i()), null));
		return ecs;
	}
}
