using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A6F RID: 6767
[eiz("DSEFX")]
[Serializable]
public sealed class c4z : els, ISerializable
{
	// Token: 0x060092FB RID: 37627 RVA: 0x003A09A0 File Offset: 0x0039EBA0
	private c4z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("DSEFX:S");
	}

	// Token: 0x060092FC RID: 37628 RVA: 0x003A09BC File Offset: 0x0039EBBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DSEFX:S", this.b);
	}

	// Token: 0x060092FD RID: 37629 RVA: 0x003A09DC File Offset: 0x0039EBDC
	public c4z(int A_0, float A_1) : base(c4z.a, "Деморализованность", ci8.c)
	{
		this.b = A_1;
		base.Icon = "Status.123";
		base.Power = Convert.ToInt32(A_1 * 1000f);
		base.Duration = A_0;
		List<d3e> list = base.StaticEffects;
		bxb bxb = new bxb(SkillEnum.Guns.a(), -A_1);
		bxb.Priority = 250;
		bxb.a(true);
		list.Add(bxb);
		List<d3e> list2 = base.StaticEffects;
		bxb bxb2 = new bxb(SkillEnum.HeavyGuns.a(), -A_1);
		bxb2.Priority = 250;
		bxb2.a(true);
		list2.Add(bxb2);
		List<d3e> list3 = base.StaticEffects;
		bxb bxb3 = new bxb(SkillEnum.Crossbows.a(), -A_1);
		bxb3.Priority = 250;
		bxb3.a(true);
		list3.Add(bxb3);
		List<d3e> list4 = base.StaticEffects;
		bxb bxb4 = new bxb(SkillEnum.Throwing.a(), -A_1);
		bxb4.Priority = 250;
		bxb4.a(true);
		list4.Add(bxb4);
		List<d3e> list5 = base.StaticEffects;
		bxb bxb5 = new bxb(SkillEnum.Melee.a(), -A_1);
		bxb5.Priority = 250;
		bxb5.a(true);
		list5.Add(bxb5);
	}

	// Token: 0x060092FE RID: 37630 RVA: 0x003A0B10 File Offset: 0x0039ED10
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Demoralized", new object[]
		{
			this.b.ToString("P0")
		});
	}

	// Token: 0x0400386C RID: 14444
	public new static readonly string a = "demoralized";

	// Token: 0x0400386D RID: 14445
	private float b;
}
