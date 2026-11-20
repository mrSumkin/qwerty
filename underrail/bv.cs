using System;
using System.Runtime.Serialization;

// Token: 0x0200050D RID: 1293
[eiz("CPSAE")]
[Serializable]
public sealed class bv : cl6, b2h, ISerializable
{
	// Token: 0x06002159 RID: 8537 RVA: 0x000B22B8 File Offset: 0x000B04B8
	private bv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bv);
		}
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000B22E4 File Offset: 0x000B04E4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000B22F0 File Offset: 0x000B04F0
	public bv(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000B22FC File Offset: 0x000B04FC
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} выполняет действие: ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}
}
