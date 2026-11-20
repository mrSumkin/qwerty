using System;
using System.Runtime.Serialization;

// Token: 0x02000508 RID: 1288
[eiz("CIPE")]
[Serializable]
public sealed class b9s : cl6, b2h, ISerializable
{
	// Token: 0x06002143 RID: 8515 RVA: 0x000B1DC8 File Offset: 0x000AFFC8
	private b9s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b9s);
		}
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000B1DF4 File Offset: 0x000AFFF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x000B1E00 File Offset: 0x000B0000
	public b9s(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000B1E0C File Offset: 0x000B000C
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} вызывает ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}
}
