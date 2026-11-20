using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B05 RID: 6917
[eiz("HWSE")]
[Serializable]
public sealed class duj : els, ISerializable
{
	// Token: 0x060095C4 RID: 38340 RVA: 0x003AB290 File Offset: 0x003A9490
	private duj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("HWSE:A", typeof(vf)) as vf);
	}

	// Token: 0x060095C5 RID: 38341 RVA: 0x003AB2BC File Offset: 0x003A94BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HWSE:A", this.b);
	}

	// Token: 0x060095C6 RID: 38342 RVA: 0x003AB2D8 File Offset: 0x003A94D8
	public duj() : base(duj.a, "Гераклово похмелье", ci8.c)
	{
		base.Duration = 0;
		base.Icon = "Status.HerculianWithdrawal";
		base.Stacking = axm.b;
		base.MaxStacks = 20;
		base.TickPeriod = d0u.b;
		this.z = "HEJX0";
		base.StaticEffects.Add(new ax6("Strength", -1));
		base.StaticEffects.Add(new ax6("Dexterity", -1));
		base.StaticEffects.Add(new ax6("Constitution", -1));
		base.StaticEffects.Add(new ax6("Agility", -1));
		base.StaticEffects.Add(new i0(-0.05f, false, false, true));
		base.StaticEffects.Add(new d9(-1, true, false));
		base.StaticEffects.Add(new ba(-2, false, true, true));
		this.b = new vf();
		this.b.TurnTickAttack = new cwt();
		this.b.TurnTickAttack.i = new ap9("Drug withdrawal", null);
		this.b.TurnTickAttack.p = true;
		this.b.TurnTickAttack.l = true;
		this.b.TurnTickAttack.f.Add(new csk(DamageType.Bio, 3));
		this.b.TurnTickAttack.b = true;
		this.b.TurnTickAttack.w = true;
		this.b.TurnTickAttack.r = true;
		this.b.DynamicTickAttack = this.b.TurnTickAttack;
		base.DynamicEffects.Add(this.b);
	}

	// Token: 0x060095C7 RID: 38343 RVA: 0x003AB494 File Offset: 0x003A9694
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/HerculeanWithdrawal", new object[]
		{
			base.Stacks,
			new csk(DamageType.Bio, base.Stacks * 3),
			base.Stacks * 2,
			(int)(Math.Min(0.9f, 0.05f * (float)base.Stacks) * 100f)
		});
	}

	// Token: 0x060095C8 RID: 38344 RVA: 0x003AB50C File Offset: 0x003A970C
	protected override void c8()
	{
		foreach (ax6 ax in Enumerable.OfType<ax6>(base.StaticEffects))
		{
			ax.a(-base.Stacks);
		}
		this.b.TurnTickAttack.f[0] = new csk(DamageType.Bio, base.Stacks * 3);
		i0 i = Enumerable.FirstOrDefault<i0>(Enumerable.OfType<i0>(base.StaticEffects));
		if (i != null)
		{
			i.Amount = Math.Max(-0.9f, -0.05f * (float)base.Stacks);
		}
		d9 d = Enumerable.FirstOrDefault<d9>(Enumerable.OfType<d9>(base.StaticEffects));
		if (d != null)
		{
			d.a = -base.Stacks;
		}
		ba ba = Enumerable.FirstOrDefault<ba>(Enumerable.OfType<ba>(base.StaticEffects));
		if (ba != null)
		{
			ba.Amount = -base.Stacks * 2;
		}
	}

	// Token: 0x040039A6 RID: 14758
	public new static readonly string a = "herculeanWithdrawal";

	// Token: 0x040039A7 RID: 14759
	private vf b;
}
