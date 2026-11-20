using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001208 RID: 4616
[eiz("REPBT")]
[Serializable]
public sealed class cxn : azv, ISerializable
{
	// Token: 0x06006323 RID: 25379 RVA: 0x002AD898 File Offset: 0x002ABA98
	private cxn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006324 RID: 25380 RVA: 0x002AD8A4 File Offset: 0x002ABAA4
	public override bool tq()
	{
		return true;
	}

	// Token: 0x06006325 RID: 25381 RVA: 0x002AD8A8 File Offset: 0x002ABAA8
	public override string tr()
	{
		return "CrawlerPoisonBearTrap";
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x002AD8B0 File Offset: 0x002ABAB0
	public cxn(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006327 RID: 25383 RVA: 0x002AD8BC File Offset: 0x002ABABC
	protected override void ts(amc A_0, amc A_1, cwt A_2, List<csk> A_3)
	{
		if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
		{
			if (A_0 != null)
			{
				etm a_ = new etm(new ap9(A_1.aa()), "яду");
				bey.a(a_, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_);
			}
			bmj.a(A_1.a8(), new ba0());
			return;
		}
		int num = ezx.e;
		if (A_0 != null && A_0.aa().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0.aa())));
		}
		ddr a_2 = new ddr((A_0 != null) ? A_0.aa() : null, ezx.d * d0u.b, num);
		A_1.aa().StatusEffects.a(a_2, false, false, false);
	}
}
