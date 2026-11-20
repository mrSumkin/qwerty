using System;
using System.Runtime.Serialization;

// Token: 0x0200050A RID: 1290
[eiz("CCE")]
[Serializable]
public sealed class a0m : cl6, b2h, ISerializable
{
	// Token: 0x0600214D RID: 8525 RVA: 0x000B1FE4 File Offset: 0x000B01E4
	private a0m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(a0m);
		}
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x000B2010 File Offset: 0x000B0210
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x000B201C File Offset: 0x000B021C
	public a0m(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x000B202C File Offset: 0x000B022C
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} употребляет: ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}
}
