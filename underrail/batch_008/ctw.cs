using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001529 RID: 5417
[eiz("BRCEA")]
[Serializable]
public sealed class ctw : a6k, ISerializable
{
	// Token: 0x06007916 RID: 30998 RVA: 0x0032B218 File Offset: 0x00329418
	private ctw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007917 RID: 30999 RVA: 0x0032B224 File Offset: 0x00329424
	public ctw()
	{
	}

	// Token: 0x06007918 RID: 31000 RVA: 0x0032B230 File Offset: 0x00329430
	protected override dc4 dt()
	{
		base.dt();
		y0 y = Enumerable.FirstOrDefault<y0>(Enumerable.OfType<y0>(base.vg().e().b8().Offense.u().TypedDefinition.n()));
		if (y != null)
		{
			double num = y.a;
			if (base.vg().e().b8().Offense.u().TypedDefinition.e() == btz.k && base.vg().e().b8().Feats.Contains<e6b>())
			{
				num += e6b.b + (double)base.vg().e().b8().GetSpecializationValue<db3>(true) * db3.a;
			}
			ajy a_ = new ajy(base.vg().e().b8().Offense.u(), num, y.b);
			base.vg().e().b8().StatusEffects.a(a_, false, false, false);
		}
		return dc4.c;
	}

	// Token: 0x06007919 RID: 31001 RVA: 0x0032B338 File Offset: 0x00329538
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.c;
	}
}
