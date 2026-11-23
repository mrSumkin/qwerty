using System;
using System.Runtime.Serialization;

// Token: 0x0200050C RID: 1292
[eiz("CIASAE")]
[Serializable]
public sealed class b5c : cl6, b2h, ISerializable
{
	// Token: 0x06002155 RID: 8533 RVA: 0x000B21C8 File Offset: 0x000B03C8
	private b5c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b5c);
		}
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000B21F4 File Offset: 0x000B03F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x000B2200 File Offset: 0x000B0400
	public b5c(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x000B220C File Offset: 0x000B040C
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} готовится применить ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), "...", null));
		return ecs;
	}
}
