using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A6E RID: 6766
[eiz("SSSE3")]
[Serializable]
public sealed class ahi : els, ISerializable
{
	// Token: 0x060092F4 RID: 37620 RVA: 0x003A07E4 File Offset: 0x0039E9E4
	private ahi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("SSSE3:S");
	}

	// Token: 0x060092F5 RID: 37621 RVA: 0x003A0800 File Offset: 0x0039EA00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSSE3:S", this.b);
	}

	// Token: 0x060092F6 RID: 37622 RVA: 0x003A0820 File Offset: 0x0039EA20
	public ahi(int A_0, float A_1, int A_2) : base(ahi.a, "Взрывное потрясение", ci8.c)
	{
		this.b = A_1;
		base.Icon = "Status.124";
		base.Power = Convert.ToInt32(A_1 * 1000f);
		base.MaxStacks = A_2;
		base.Duration = A_0;
		foreach (SkillEnum skillEnum in new SkillEnum[]
		{
			SkillEnum.Guns,
			SkillEnum.HeavyGuns,
			SkillEnum.Crossbows,
			SkillEnum.Throwing,
			SkillEnum.Melee,
			SkillEnum.Dodge,
			SkillEnum.Evasion
		})
		{
			List<d3e> list = base.StaticEffects;
			bxb bxb = new bxb(skillEnum.a(), -A_1);
			bxb.Priority = 260;
			bxb.a(true);
			list.Add(bxb);
		}
	}

	// Token: 0x060092F7 RID: 37623 RVA: 0x003A08D8 File Offset: 0x0039EAD8
	protected override void c8()
	{
		this.a();
	}

	// Token: 0x060092F8 RID: 37624 RVA: 0x003A08E4 File Offset: 0x0039EAE4
	private void a()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			bxb bxb = d3e as bxb;
			if (bxb != null)
			{
				bxb.a(-this.b * (float)base.Stacks);
			}
		}
	}

	// Token: 0x060092F9 RID: 37625 RVA: 0x003A0958 File Offset: 0x0039EB58
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ShellShocked", new object[]
		{
			(this.b * (float)base.Stacks).ToString("P1")
		});
	}

	// Token: 0x0400386A RID: 14442
	public new static readonly string a = "shellShocked";

	// Token: 0x0400386B RID: 14443
	private float b;
}
