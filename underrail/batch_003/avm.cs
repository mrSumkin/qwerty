using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AF5 RID: 6901
[eiz("SRSE")]
[Serializable]
public sealed class avm : els, ISerializable
{
	// Token: 0x0600957E RID: 38270 RVA: 0x003AA554 File Offset: 0x003A8754
	private avm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600957F RID: 38271 RVA: 0x003AA560 File Offset: 0x003A8760
	public avm(int A_0, int A_1) : base(avm.a, "Перезарядка щита", ci8.b)
	{
		base.Duration = A_1;
		base.VisualEffects.Add(new ud(this, "ShieldRecharging"));
		base.TickPeriod = d0u.b;
		base.Icon = "Abilities.21";
		base.Stacking = axm.b;
		base.Power = A_0;
		base.DynamicEffects.Add(new a7g(A_0));
	}

	// Token: 0x06009580 RID: 38272 RVA: 0x003AA5D0 File Offset: 0x003A87D0
	public override string cb(ll A_0)
	{
		a7g a7g = Enumerable.FirstOrDefault<wq>(base.DynamicEffects) as a7g;
		if (a7g != null)
		{
			return qv.a("StatusEffects/ShieldRecharging", new object[]
			{
				a7g.a()
			});
		}
		return string.Empty;
	}

	// Token: 0x04003991 RID: 14737
	public new static readonly string a = "shieldRecharging";
}
