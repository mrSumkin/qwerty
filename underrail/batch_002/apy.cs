using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A70 RID: 6768
[eiz("PFBRSE")]
[Serializable]
public sealed class apy : els, ISerializable
{
	// Token: 0x06009300 RID: 37632 RVA: 0x003A0B44 File Offset: 0x0039ED44
	private apy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009301 RID: 37633 RVA: 0x003A0B50 File Offset: 0x0039ED50
	public apy(int A_0, double A_1, int A_2, bool A_3 = true) : base(A_3 ? apy.a : (apy.a + Guid.NewGuid().ToString()), "Парафиброзная регенерация", ci8.b)
	{
		base.Duration = A_2;
		base.TickPeriod = d0u.b;
		base.Icon = "Abilities.111";
		base.Stacking = (A_3 ? axm.b : axm.c);
		base.Power = A_0;
		base.DynamicEffects.Add(new a7i(A_0, 0f));
		base.StaticEffects.Add(new e3r(DamageType.Mechanical, -A_1));
		base.StaticEffects.Add(new e3r(DamageType.Heat, -A_1));
	}

	// Token: 0x06009302 RID: 37634 RVA: 0x003A0C0C File Offset: 0x0039EE0C
	public override string cb(ll A_0)
	{
		int num = 0;
		double value = 0.0;
		a7i a7i = Enumerable.FirstOrDefault<wq>(base.DynamicEffects) as a7i;
		if (a7i != null)
		{
			num = a7i.Amount;
		}
		e3r e3r = Enumerable.FirstOrDefault<d3e>(base.StaticEffects) as e3r;
		if (e3r != null)
		{
			value = e3r.Value;
		}
		return qv.a("StatusEffects/ParafibroticRegeneration", new object[]
		{
			num,
			Math.Abs(value).ToString("P0")
		});
	}

	// Token: 0x0400386E RID: 14446
	public new static readonly string a = "parafibroticRegeneration";
}
