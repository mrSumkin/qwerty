using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A8E RID: 6798
[eiz("SHWISE")]
[Serializable]
public sealed class de1 : els, ISerializable
{
	// Token: 0x06009394 RID: 37780 RVA: 0x003A2EA8 File Offset: 0x003A10A8
	private de1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009395 RID: 37781 RVA: 0x003A2EB8 File Offset: 0x003A10B8
	public de1() : base(de1.a, "Разрушенная воля", ci8.c)
	{
		base.Duration = 10000;
		base.Icon = "Status.ShatteredWill";
		base.Stacking = axm.b;
		base.MaxStacks = 10;
		base.TickPeriod = d0u.b;
		foreach (csn csn in new axp().b)
		{
			base.StaticEffects.Add(new dpw(csn.Name, -10));
		}
		foreach (object obj in Enum.GetValues(typeof(BaseAbilityEnum)))
		{
			BaseAbilityEnum baseAbilityEnum = (BaseAbilityEnum)obj;
			base.StaticEffects.Add(new ax6(baseAbilityEnum.ToString().a(), -base.Stacks));
		}
		base.StaticEffects.Add(new d9(-2, true, false));
		base.StaticEffects.Add(new ba(-2, false, true, true));
	}

	// Token: 0x06009396 RID: 37782 RVA: 0x003A3010 File Offset: 0x003A1210
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ShatteredWill", new object[]
		{
			base.Stacks,
			base.Stacks * 10,
			base.Stacks * 2
		});
	}

	// Token: 0x06009397 RID: 37783 RVA: 0x003A305C File Offset: 0x003A125C
	protected override void c8()
	{
		if (base.Stacks == 10)
		{
			this.ad = "DITJKWSP";
			return;
		}
		foreach (dpw dpw in Enumerable.OfType<dpw>(base.StaticEffects))
		{
			dpw.a(-base.Stacks * 10);
		}
		foreach (ax6 ax in Enumerable.OfType<ax6>(base.StaticEffects))
		{
			ax.a(-base.Stacks);
		}
		d9 d = Enumerable.FirstOrDefault<d9>(Enumerable.OfType<d9>(base.StaticEffects));
		if (d != null)
		{
			d.a = -base.Stacks * 2;
		}
		ba ba = Enumerable.FirstOrDefault<ba>(Enumerable.OfType<ba>(base.StaticEffects));
		if (ba != null)
		{
			ba.Amount = -base.Stacks * 2;
		}
	}

	// Token: 0x040038B2 RID: 14514
	public new static readonly string a = "shatteredWillStatusEffect";
}
