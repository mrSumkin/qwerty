using System;
using System.Runtime.Serialization;

// Token: 0x0200050E RID: 1294
[eiz("CIPSAE")]
[Serializable]
public sealed class dq0 : cl6, b2h, ISerializable
{
	// Token: 0x0600215D RID: 8541 RVA: 0x000B23A8 File Offset: 0x000B05A8
	private dq0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dq0);
		}
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x000B23D4 File Offset: 0x000B05D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000B23E0 File Offset: 0x000B05E0
	public dq0(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x000B23EC File Offset: 0x000B05EC
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} подготавливает действие: ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), "...", null));
		return ecs;
	}
}
