using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200155C RID: 5468
[eiz("RFT")]
[Serializable]
public sealed class s : a6k, ISerializable
{
	// Token: 0x060079D2 RID: 31186 RVA: 0x0032FA28 File Offset: 0x0032DC28
	private s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("RFT:I", typeof(Guid));
	}

	// Token: 0x060079D3 RID: 31187 RVA: 0x0032FA54 File Offset: 0x0032DC54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RFT:I", this.a);
	}

	// Token: 0x060079D4 RID: 31188 RVA: 0x0032FA74 File Offset: 0x0032DC74
	public s()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x060079D5 RID: 31189 RVA: 0x0032FA88 File Offset: 0x0032DC88
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		amc b = base.vg().q().h.b;
		c5x c5x = base.vg().h() as c5x;
		amc amc = (c5x != null) ? c5x.h.b : null;
		if (b == null || amc == null)
		{
			return dc4.e;
		}
		cd1 cd = b.aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke == null || amc.a8().j != cgy.b || amc.a8().Area != b.a8().Area)
		{
			return dc4.e;
		}
		double num = aw1.b(b.a8(), amc.a8());
		if (num > (double)(bke.ad() + 1f))
		{
			return dc4.e;
		}
		bool flag = false;
		AmmoType a_ = cd.CurrentBullet;
		if (awq.a(b, cd))
		{
			double a_2;
			if (flag)
			{
				a_2 = 0.0;
			}
			else
			{
				bon bon = base.vg().e().p() as bon;
				double a_3 = aw1.b(b.a8(), amc.a8());
				if (bon != null)
				{
					a_2 = bon.l9(new eoj(b.aa(), cd, null), a_3);
				}
				else
				{
					a_2 = 1.0;
				}
			}
			cmn cmn = awq.a(b, amc, null, null);
			cmn.b += b.aa().Offense.an();
			cwt cwt = euf.a(b.aa(), amc.aa(), num, cmn, 0.0, amc.a8().l(), b.aa().Darkvision, a_, awq.f(b), a_2, false, null, null, true, null);
			cwt.af = this.a;
			cwt.k = "Беглый огонь";
			awq.a(b, amc, cwt, cd, null, true, null, null, null, false, false, true, null, null);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x040030C5 RID: 12485
	private new Guid a;
}
