using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011F7 RID: 4599
[eiz("LPBTT")]
[Serializable]
public sealed class a2c : azv, ISerializable
{
	// Token: 0x060062C8 RID: 25288 RVA: 0x002AB3D8 File Offset: 0x002A95D8
	private a2c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x002AB3E4 File Offset: 0x002A95E4
	public override bool tq()
	{
		return true;
	}

	// Token: 0x060062CA RID: 25290 RVA: 0x002AB3E8 File Offset: 0x002A95E8
	public override string tr()
	{
		return "LeperPoisonBearTrap";
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x002AB3F0 File Offset: 0x002A95F0
	public a2c(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x002AB3FC File Offset: 0x002A95FC
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
		int num = ezx.q;
		if (A_0 != null && A_0.aa().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0.aa())));
		}
		ab6 ab = new ab6((A_0 != null) ? A_0.aa() : null, ezx.t * d0u.b, num);
		ab.Stacks = ezx.u;
		A_1.aa().StatusEffects.a(ab, false, false, false);
	}
}
