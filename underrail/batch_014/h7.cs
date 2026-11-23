using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F35 RID: 7989
[ayj("Cryokinesis")]
public sealed class h7 : ce5
{
	// Token: 0x0600B972 RID: 47474 RVA: 0x00411D34 File Offset: 0x0040FF34
	public override string y8()
	{
		return "Криокинез";
	}

	// Token: 0x0600B973 RID: 47475 RVA: 0x00411D3C File Offset: 0x0040FF3C
	public override string os()
	{
		return "Cryokinesis";
	}

	// Token: 0x0600B974 RID: 47476 RVA: 0x00411D44 File Offset: 0x0040FF44
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B975 RID: 47477 RVA: 0x00411D48 File Offset: 0x0040FF48
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B976 RID: 47478 RVA: 0x00411D4C File Offset: 0x0040FF4C
	public override int ci()
	{
		return 1;
	}

	// Token: 0x0600B977 RID: 47479 RVA: 0x00411D50 File Offset: 0x0040FF50
	public override IList<string> bi()
	{
		return this.j;
	}

	// Token: 0x0600B978 RID: 47480 RVA: 0x00411D58 File Offset: 0x0040FF58
	public h7()
	{
		this.j = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B979 RID: 47481 RVA: 0x00411D78 File Offset: 0x0040FF78
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x0600B97A RID: 47482 RVA: 0x00411DAC File Offset: 0x0040FFAC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B97B RID: 47483 RVA: 0x00411DB0 File Offset: 0x0040FFB0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		if (A_1 == v5.b)
		{
			return new List<cfd>
			{
				new cfd(d7f.b, d7f.g, true, false)
			};
		}
		return d7f.o;
	}

	// Token: 0x0600B97C RID: 47484 RVA: 0x00411DE0 File Offset: 0x0040FFE0
	public override string bo(cnm A_0)
	{
		List<a1q> list = h7.a(A_0);
		string text = qv.b("Psi/Cryokinesis");
		string result = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, new object[]
				{
					list[0].LowerBoundary,
					list[0].UpperBoundary,
					list[1].LowerBoundary,
					list[1].UpperBoundary,
					b34.a,
					l4.a((double)h7.b(A_0)),
					h7.i
				});
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600B97D RID: 47485 RVA: 0x00411EC4 File Offset: 0x004100C4
	public static int b(cnm A_0)
	{
		int num = h7.h;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<co4>())
		{
			num += d0u.b;
		}
		return num;
	}

	// Token: 0x0600B97E RID: 47486 RVA: 0x00411F08 File Offset: 0x00410108
	public new static List<a1q> a(cnm A_0)
	{
		double num = c3n.a("Cryokinesis", A_0);
		a1q item = default(a1q);
		item.DamageType = DamageType.Cold;
		a1q item2 = default(a1q);
		item2.DamageType = DamageType.Mechanical;
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<rs>(A_0);
		item.LowerBoundary = Convert.ToInt32((8.0 + 0.2 * (double)effectivePsiSkillLevel) * num);
		item.UpperBoundary = Convert.ToInt32((9.0 + 0.38 * (double)effectivePsiSkillLevel) * num);
		item2.LowerBoundary = Convert.ToInt32((6.0 + 0.15 * (double)effectivePsiSkillLevel) * num);
		item2.UpperBoundary = Convert.ToInt32((7.0 + 0.25 * (double)effectivePsiSkillLevel) * num);
		return new List<a1q>
		{
			item,
			item2
		};
	}

	// Token: 0x0600B97F RID: 47487 RVA: 0x00411FEC File Offset: 0x004101EC
	protected override int d2(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B980 RID: 47488 RVA: 0x00411FF4 File Offset: 0x004101F4
	protected override float f0(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			float? primitivePropertyValue = A_0.b8().CustomProperties.GetPrimitivePropertyValue<float>("CryokinesisRange", null);
			if (primitivePropertyValue != null)
			{
				return primitivePropertyValue.Value;
			}
		}
		return 12f;
	}

	// Token: 0x0600B981 RID: 47489 RVA: 0x0041204C File Offset: 0x0041024C
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B982 RID: 47490 RVA: 0x00412058 File Offset: 0x00410258
	protected override int br(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			int? primitivePropertyValue = A_0.b8().CustomProperties.GetPrimitivePropertyValue<int>("CryokinesisCastingTime", null);
			if (primitivePropertyValue != null)
			{
				return primitivePropertyValue.Value;
			}
		}
		return 1500;
	}

	// Token: 0x0600B983 RID: 47491 RVA: 0x004120B0 File Offset: 0x004102B0
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.c) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B984 RID: 47492 RVA: 0x004120F4 File Offset: 0x004102F4
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B985 RID: 47493 RVA: 0x004120F8 File Offset: 0x004102F8
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x04004380 RID: 17280
	private new const string a = "Cryokinesis";

	// Token: 0x04004381 RID: 17281
	private const double b = 8.0;

	// Token: 0x04004382 RID: 17282
	private const double c = 0.2;

	// Token: 0x04004383 RID: 17283
	private const double d = 0.38;

	// Token: 0x04004384 RID: 17284
	private new const double e = 6.0;

	// Token: 0x04004385 RID: 17285
	private new const double f = 0.15;

	// Token: 0x04004386 RID: 17286
	private new const double g = 0.25;

	// Token: 0x04004387 RID: 17287
	public new static readonly int h = 10000;

	// Token: 0x04004388 RID: 17288
	public new static readonly int i = 3;

	// Token: 0x04004389 RID: 17289
	private new List<string> j;
}
