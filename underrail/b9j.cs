using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011F2 RID: 4594
[eiz("RZPBT")]
[Serializable]
public sealed class b9j : azv, ISerializable
{
	// Token: 0x060062B3 RID: 25267 RVA: 0x002AABB0 File Offset: 0x002A8DB0
	private b9j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x002AABBC File Offset: 0x002A8DBC
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062B5 RID: 25269 RVA: 0x002AABC0 File Offset: 0x002A8DC0
	public override string tr()
	{
		return "BlackDragonPoisonBearTrap";
	}

	// Token: 0x060062B6 RID: 25270 RVA: 0x002AABC8 File Offset: 0x002A8DC8
	public b9j(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062B7 RID: 25271 RVA: 0x002AABD4 File Offset: 0x002A8DD4
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
		dns a_2 = new dns(ezx.g * d0u.b);
		A_1.aa().StatusEffects.a(a_2, false, false, false);
	}
}
