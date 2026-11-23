using System;
using System.Runtime.Serialization;

// Token: 0x02001816 RID: 6166
[eiz("CSTA")]
[Serializable]
public sealed class nt : a6k, ISerializable
{
	// Token: 0x0600832F RID: 33583 RVA: 0x0036DD8C File Offset: 0x0036BF8C
	private nt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("CSTA:I", typeof(Guid));
	}

	// Token: 0x06008330 RID: 33584 RVA: 0x0036DDB8 File Offset: 0x0036BFB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSTA:I", this.a);
	}

	// Token: 0x06008331 RID: 33585 RVA: 0x0036DDD8 File Offset: 0x0036BFD8
	public nt()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x06008332 RID: 33586 RVA: 0x0036DDEC File Offset: 0x0036BFEC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc b = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc = (c5x != null) ? c5x.h.b : null;
		if (b == null || b.a8() == null || amc == null || amc.a8() == null)
		{
			return dc4.e;
		}
		cd1 cd = b.aa().Offense.u();
		if (cd.Battery < (double)bti.c)
		{
			return dc4.e;
		}
		if (dz6.e())
		{
			d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(b.aa());
			if (d4n == null)
			{
				return dc4.e;
			}
			if (d4n.c < (double)bti.d)
			{
				return dc4.e;
			}
			d4n.a(bti.d, true);
		}
		cd.Battery -= (double)bti.c;
		if (cd.TypedDefinition != null && amc.a8().j == cgy.b && amc.a8().Area == b.a8().Area && !amc.aa().Dead)
		{
			bon bon = base.vg().e().p() as bon;
			double a_ = aw1.b(b.a8(), amc.a8());
			double a_2;
			if (bon != null)
			{
				a_2 = bon.l9(new eoj(b.aa(), cd, null), a_);
			}
			else
			{
				a_2 = 1.0;
			}
			cmn cmn = awq.b(b, amc, null);
			cmn.g *= bti.b;
			cwt cwt = euf.a(b.aa(), amc.aa(), cmn, 0.0, null, a_2, null, true);
			cwt.af = this.a;
			cwt.k = "Атака цепной пилой";
			cwt.o = bti.e;
			awq.a(b, amc, cwt, cd, null);
			boj.a(amc.a8(), "Buzzsaw", int.MaxValue, (double)dz6.b(85), true, true, null, null, null, null, false);
		}
		return dc4.c;
	}

	// Token: 0x0400327C RID: 12924
	private new Guid a;
}
