using System;
using System.Runtime.Serialization;

// Token: 0x02001475 RID: 5237
[eiz("DGGA")]
[Serializable]
public sealed class a17 : a6k, ISerializable
{
	// Token: 0x06007639 RID: 30265 RVA: 0x0031F554 File Offset: 0x0031D754
	private a17(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600763A RID: 30266 RVA: 0x0031F560 File Offset: 0x0031D760
	public a17()
	{
	}

	// Token: 0x0600763B RID: 30267 RVA: 0x0031F56C File Offset: 0x0031D76C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		if (!(c5x.s.b is yp))
		{
			return dc4.e;
		}
		if (base.vg().q().IsPlayer)
		{
			bmj.a(base.vg().q(), new d53("Газовая граната обезврежена.", adi.h, null, false));
		}
		c5x.an();
		string path = "components\\Containers\\ThinGrenadeCase";
		if (ez2.GetItemDefinition<a1k>(path, true) != null)
		{
			fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(path));
			mk mk = new mk();
			mk.StaticItems.z3(a_, true);
			mk.ym(null, base.vg().q(), null);
		}
		base.vg().q().c().a("DisarmGasGrenade");
		return dc4.c;
	}
}
