using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011FC RID: 4604
[eiz("RGPBT")]
[Serializable]
public sealed class b6y : azv, ISerializable
{
	// Token: 0x060062EA RID: 25322 RVA: 0x002ABCC0 File Offset: 0x002A9EC0
	private b6y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x002ABCCC File Offset: 0x002A9ECC
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x002ABCD0 File Offset: 0x002A9ED0
	public override string tr()
	{
		return "SpiritPoisonBearTrap";
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x002ABCD8 File Offset: 0x002A9ED8
	public b6y(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x002ABCE8 File Offset: 0x002A9EE8
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
		int num = ezx.i;
		if (A_0 != null && A_0.aa().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0.aa())));
		}
		ehp a_2 = new ehp((A_0 != null) ? A_0.aa() : null, ezx.h * d0u.b, num);
		A_1.aa().StatusEffects.a(a_2, false, false, false);
	}
}
