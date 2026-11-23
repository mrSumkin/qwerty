using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A81 RID: 6785
[eiz("CONTW")]
[Serializable]
public sealed class fp : els, ISerializable
{
	// Token: 0x06009356 RID: 37718 RVA: 0x003A1ED0 File Offset: 0x003A00D0
	private fp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009357 RID: 37719 RVA: 0x003A1EDC File Offset: 0x003A00DC
	public fp(string A_0, int A_1, int A_2, cd1 A_3 = null) : base(fp.a, "Загрязнённая рана", ci8.c)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "ContaminatedWound";
		base.Stacking = axm.c;
		cwt cwt = new cwt();
		cwt.i = new ap9("Contaminated wound", A_0);
		cwt.l = true;
		cwt.p = true;
		cwt.e = false;
		cwt.r = true;
		cwt.w = true;
		cwt.f = new List<csk>
		{
			new csk(DamageType.Bio, A_2)
		};
		cwt.q = false;
		cwt.b = true;
		if (A_3 != null && A_3.TypedDefinition != null)
		{
			cwt.ae = euf.d(A_3.TypedDefinition);
		}
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x06009358 RID: 37720 RVA: 0x003A1FB8 File Offset: 0x003A01B8
	public override string cb(ll A_0)
	{
		vf vf = Enumerable.FirstOrDefault<vf>(Enumerable.OfType<vf>(base.DynamicEffects));
		if (vf != null && vf.TurnTickAttack != null && vf.TurnTickAttack.f.Count > 0)
		{
			return qv.a("StatusEffects/ContaminatedWound", new object[]
			{
				vf.TurnTickAttack.f[0].Amount
			});
		}
		return "";
	}

	// Token: 0x0400388B RID: 14475
	public new static readonly string a = "contaminatedWound";
}
