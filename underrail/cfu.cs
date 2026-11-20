using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001209 RID: 4617
[eiz("PBTT")]
[Serializable]
public sealed class cfu : azv, enp, ISerializable
{
	// Token: 0x06006328 RID: 25384 RVA: 0x002AD9BC File Offset: 0x002ABBBC
	private cfu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006329 RID: 25385 RVA: 0x002AD9C8 File Offset: 0x002ABBC8
	public override bool tq()
	{
		return true;
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x002AD9CC File Offset: 0x002ABBCC
	public cfu(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600632B RID: 25387 RVA: 0x002AD9D8 File Offset: 0x002ABBD8
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
		double num = euf.d(A_1.aa(), 1.0);
		int num2 = cl5.d(base.TrapItem);
		int a_2 = cl5.a(base.TrapItem);
		int a_3 = cl5.a(base.TrapItem, (A_0 != null) ? A_0.aa() : null);
		string a_4 = cl5.c(base.TrapItem);
		string a_5 = cl5.b(base.TrapItem);
		int num3 = (int)Math.Max(1.0, (double)num2 * (1.0 - num));
		c2b c2b = new c2b((A_0 != null) ? A_0.aa() : null, a_4, a_5, num3 * d0u.b, a_3, a_2);
		c2b.Stacks = eao.a(base.TrapItem);
		A_1.aa().StatusEffects.a(c2b, false, false, false);
	}
}
