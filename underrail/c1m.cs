using System;
using System.Runtime.Serialization;

// Token: 0x0200050B RID: 1291
[eiz("CASAE")]
[Serializable]
public sealed class c1m : cl6, b2h, ISerializable
{
	// Token: 0x06002151 RID: 8529 RVA: 0x000B20D8 File Offset: 0x000B02D8
	private c1m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(c1m);
		}
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x000B2104 File Offset: 0x000B0304
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x000B2110 File Offset: 0x000B0310
	public c1m(ap9 A_0, string A_1, ci8 A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x000B211C File Offset: 0x000B031C
	public override ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} применяет ", (base.f() != null) ? base.f().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.ai[base.c()]), base.d(), null));
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}
}
