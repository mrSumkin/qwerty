using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AC5 RID: 6853
[eiz("SPISE")]
[Serializable]
public sealed class zh : els, ISerializable
{
	// Token: 0x06009493 RID: 38035 RVA: 0x003A6BDC File Offset: 0x003A4DDC
	private zh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.k = A_0.GetInt32("SPISE:P");
	}

	// Token: 0x06009494 RID: 38036 RVA: 0x003A6BF8 File Offset: 0x003A4DF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPISE:P", this.k);
	}

	// Token: 0x06009495 RID: 38037 RVA: 0x003A6C14 File Offset: 0x003A4E14
	public int a()
	{
		return this.k;
	}

	// Token: 0x06009496 RID: 38038 RVA: 0x003A6C20 File Offset: 0x003A4E20
	public zh() : base(zh.a, "Паразитическое заражение", ci8.c)
	{
		base.Duration = zh.b * d0u.b;
		base.TickPeriod = d0u.b;
		base.Icon = "Misc.0";
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.y = "SPIXPJ";
		base.StaticEffects.AddRange(new d3e[]
		{
			new b2g(0.0),
			new emn(0),
			new ba(0, false, true, false)
			{
				Priority = int.MaxValue
			},
			new d9(0, true, false)
			{
				Priority = int.MaxValue
			}
		});
		cwt cwt = new cwt();
		cwt.i = new ap9(base.Name, null);
		cwt.f.Add(new csk(DamageType.Bio, 0));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
		this.b();
	}

	// Token: 0x06009497 RID: 38039 RVA: 0x003A6D40 File Offset: 0x003A4F40
	public override string cb(ll A_0)
	{
		string text = qv.b("StatusEffects/StriderParasiticInfestation_Base");
		object[] a_ = new object[]
		{
			Convert.ToInt32(zh.g * 100.0),
			zh.h,
			zh.i,
			zh.j,
			zh.f * this.k
		};
		for (int i = 1; i <= this.k; i++)
		{
			text = text + " " + qv.a("StatusEffects/StriderParasiticInfestation_Phase" + i.ToString(), a_);
		}
		return text;
	}

	// Token: 0x06009498 RID: 38040 RVA: 0x003A6DF0 File Offset: 0x003A4FF0
	public bool b()
	{
		if (this.k < 5)
		{
			this.k++;
			base.Icon = "Status.StriderParasiticInfestation." + this.k.ToString();
			vf vf = base.DynamicEffects[0] as vf;
			vf.TurnTickAttack.f[0] = new csk(DamageType.Bio, zh.f * this.k);
			vf.DynamicTickAttack.f[0] = new csk(DamageType.Bio, zh.f * this.k);
			if (this.k == 2)
			{
				((b2g)base.StaticEffects[0]).Value = -zh.g;
			}
			else if (this.k == 3)
			{
				((emn)base.StaticEffects[1]).a(-zh.h);
			}
			else if (this.k == 4)
			{
				((ba)base.StaticEffects[2]).a = -zh.i;
			}
			else if (this.k == 5)
			{
				((d9)base.StaticEffects[3]).Amount = -zh.j;
			}
			return false;
		}
		return true;
	}

	// Token: 0x0400392C RID: 14636
	public new static readonly string a = "striderParasiticInfestation";

	// Token: 0x0400392D RID: 14637
	private static readonly int b = 12;

	// Token: 0x0400392E RID: 14638
	public new static readonly int c = 10;

	// Token: 0x0400392F RID: 14639
	public new static readonly a1q d = new a1q(DamageType.Bio, 15, 40);

	// Token: 0x04003930 RID: 14640
	public new static readonly a1q e = new a1q(DamageType.Bio, 2, 5);

	// Token: 0x04003931 RID: 14641
	private static readonly int f = 2;

	// Token: 0x04003932 RID: 14642
	private static readonly double g = 0.15;

	// Token: 0x04003933 RID: 14643
	private static readonly int h = 3;

	// Token: 0x04003934 RID: 14644
	private new static readonly int i = 7;

	// Token: 0x04003935 RID: 14645
	private static readonly int j = 2;

	// Token: 0x04003936 RID: 14646
	private int k;
}
