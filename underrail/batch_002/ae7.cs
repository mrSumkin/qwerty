using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001545 RID: 5445
[eiz("SBTA")]
[Serializable]
public sealed class ae7 : a6k, ISerializable
{
	// Token: 0x0600797C RID: 31100 RVA: 0x0032DD3C File Offset: 0x0032BF3C
	private ae7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("SBTA:I", typeof(Guid));
	}

	// Token: 0x0600797D RID: 31101 RVA: 0x0032DD68 File Offset: 0x0032BF68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBTA:I", this.a);
	}

	// Token: 0x0600797E RID: 31102 RVA: 0x0032DD88 File Offset: 0x0032BF88
	public ae7()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x0600797F RID: 31103 RVA: 0x0032DDA0 File Offset: 0x0032BFA0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc b = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc = (c5x != null) ? c5x.h.b : null;
		if (b == null || amc == null)
		{
			return dc4.e;
		}
		double a_ = aw1.b(base.vg().q(), c5x);
		cd1 cd = b.aa().Offense.u();
		if (cd.TypedDefinition != null && amc.a8().j == cgy.b && amc.a8().Area == b.a8().Area)
		{
			AmmoType? ammoType = null;
			if (cd.LoadedAmmo.Count > 0)
			{
				ammoType = new AmmoType?(cd.LoadedAmmo[cd.LoadedAmmo.Count - 1]);
			}
			if (awq.a(b, cd) && ammoType != null)
			{
				ec6 ec = new ec6();
				double a_2 = (double)b.aa().GetSpecializationValue<aye>(true) * aye.a;
				ec.a(b, amc, cd, ammoType.Value, awq.a(base.vg().e(), amc, a_), true, a_2, true, null);
				return dc4.c;
			}
		}
		return dc4.e;
	}

	// Token: 0x040030AA RID: 12458
	private new Guid a;
}
