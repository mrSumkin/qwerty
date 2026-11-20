using System;
using System.Runtime.Serialization;

// Token: 0x02000516 RID: 1302
[eiz("CIIPE")]
[Serializable]
public sealed class b6m : cl6, b2h, ISerializable
{
	// Token: 0x0600218D RID: 8589 RVA: 0x000B3384 File Offset: 0x000B1584
	private b6m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b6m);
		}
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x000B33B0 File Offset: 0x000B15B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000B33BC File Offset: 0x000B15BC
	public b6m(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x000B33CC File Offset: 0x000B15CC
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} подготавливает ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), "...", null));
		return ecs;
	}
}
