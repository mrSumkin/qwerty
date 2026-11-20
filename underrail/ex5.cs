using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011EF RID: 4591
[eiz("CEPBT")]
[Serializable]
public sealed class ex5 : azv, enp, ISerializable
{
	// Token: 0x060062A5 RID: 25253 RVA: 0x002AA420 File Offset: 0x002A8620
	private ex5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x002AA42C File Offset: 0x002A862C
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x002AA430 File Offset: 0x002A8630
	public override string tr()
	{
		return "CaveEarPoisonBearTrap";
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x002AA438 File Offset: 0x002A8638
	public ex5(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x002AA444 File Offset: 0x002A8644
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
		cl5.c(base.TrapItem);
		cl5.b(base.TrapItem);
		bhe a_2 = new bhe((int)Math.Max(1.0, (double)num2 * (1.0 - num)) * d0u.b);
		A_1.aa().StatusEffects.a(a_2, false, false, false);
	}
}
