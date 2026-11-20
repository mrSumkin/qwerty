using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B13 RID: 6931
[eiz("IW")]
[Serializable]
public sealed class e1l : els, ISerializable
{
	// Token: 0x06009602 RID: 38402 RVA: 0x003AC1BC File Offset: 0x003AA3BC
	private e1l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 398)
		{
			this.a = A_0.GetDouble("IW:D");
			this.b = A_0.GetDouble("IW:H");
			return;
		}
		this.a = c6t.a;
		this.b = c6t.b;
	}

	// Token: 0x06009603 RID: 38403 RVA: 0x003AC21C File Offset: 0x003AA41C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IW:D", this.a);
		info.AddValue("IW:H", this.b);
	}

	// Token: 0x06009604 RID: 38404 RVA: 0x003AC24C File Offset: 0x003AA44C
	public e1l(int A_0, double A_1, double A_2) : base("infectedWound", "Заражённая рана", ci8.c)
	{
		this.a = A_1;
		this.b = A_2;
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.19";
		base.MaxStacks = c6t.c;
		base.Stacking = axm.b;
		base.Power = (int)(this.a * 100.0) * 100 + (int)(this.b * 100.0);
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			e3r item = new e3r((DamageType)obj, this.a);
			base.StaticEffects.Add(item);
		}
		b2g item2 = new b2g
		{
			Value = -this.b
		};
		base.StaticEffects.Add(item2);
	}

	// Token: 0x06009605 RID: 38405 RVA: 0x003AC360 File Offset: 0x003AA560
	public override string cb(ll A_0)
	{
		e3r e3r = Enumerable.FirstOrDefault<e3r>(Enumerable.OfType<e3r>(base.StaticEffects));
		b2g b2g = Enumerable.FirstOrDefault<b2g>(Enumerable.OfType<b2g>(base.StaticEffects));
		if (e3r != null && b2g != null)
		{
			return qv.a("StatusEffects/InfectedWound", new object[]
			{
				(int)(e3r.Value * 100.0),
				(int)(Math.Abs(b2g.Value) * 100.0)
			});
		}
		return string.Empty;
	}

	// Token: 0x06009606 RID: 38406 RVA: 0x003AC3E8 File Offset: 0x003AA5E8
	protected override void c8()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			e3r e3r = d3e as e3r;
			if (e3r != null)
			{
				e3r.Value = (double)base.Stacks * this.a;
			}
			else
			{
				b2g b2g = d3e as b2g;
				if (b2g != null)
				{
					b2g.Value = (double)base.Stacks * -this.b;
				}
			}
		}
	}

	// Token: 0x040039B8 RID: 14776
	private new double a;

	// Token: 0x040039B9 RID: 14777
	private double b;
}
