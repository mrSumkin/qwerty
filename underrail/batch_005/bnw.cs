using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F0D RID: 7949
[ayj("MotorCognitiveTransference")]
public sealed class bnw : ce5
{
	// Token: 0x0600B6B3 RID: 46771 RVA: 0x0040C0D8 File Offset: 0x0040A2D8
	public override string y8()
	{
		return "Моторно-когнитивный перенос";
	}

	// Token: 0x0600B6B4 RID: 46772 RVA: 0x0040C0E0 File Offset: 0x0040A2E0
	public override string os()
	{
		return "MotorCognitiveTransference";
	}

	// Token: 0x0600B6B5 RID: 46773 RVA: 0x0040C0E8 File Offset: 0x0040A2E8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B6B6 RID: 46774 RVA: 0x0040C0EC File Offset: 0x0040A2EC
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B6B7 RID: 46775 RVA: 0x0040C0F0 File Offset: 0x0040A2F0
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B6B8 RID: 46776 RVA: 0x0040C0F4 File Offset: 0x0040A2F4
	public bnw()
	{
		this.m = new List<string>
		{
			d7f.b,
			bnw.a
		};
	}

	// Token: 0x0600B6B9 RID: 46777 RVA: 0x0040C128 File Offset: 0x0040A328
	public static void b(cnm A_0, out double A_1, out int A_2)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		A_1 = Math.Min(0.8, 0.15 + 0.0025 * (double)effectivePsiSkillLevel);
		A_2 = Math.Max(10, Convert.ToInt32(0.8 * (double)effectivePsiSkillLevel));
	}

	// Token: 0x0600B6BA RID: 46778 RVA: 0x0040C17C File Offset: 0x0040A37C
	public static void a(cnm A_0, out double A_1, out int A_2)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		A_1 = Math.Min(0.3, 0.1 + 0.00075 * (double)effectivePsiSkillLevel);
		A_2 = Math.Max(10, Convert.ToInt32(0.25 * (double)effectivePsiSkillLevel));
	}

	// Token: 0x0600B6BB RID: 46779 RVA: 0x0040C1D0 File Offset: 0x0040A3D0
	public static Dictionary<SkillEnum, bnw.a> a(cnm A_0, efk A_1, double A_2, double A_3)
	{
		double num = 1.0 - Math.Max(0.0, A_2 - 0.3);
		Dictionary<SkillEnum, bnw.a> dictionary = new Dictionary<SkillEnum, bnw.a>();
		if (A_1 != null)
		{
			double num2;
			int val;
			bnw.b(A_0, out num2, out val);
			double num3;
			int val2;
			bnw.a(A_0, out num3, out val2);
			foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
			{
				SkillEnum skillEnum = (SkillEnum)obj;
				if (skillEnum < SkillEnum.Dodge)
				{
					bnw.a a = default(bnw.a);
					a.a = skillEnum.a();
					csn csn = A_1.Skills.a(a.a);
					if (csn != null)
					{
						a.c = Math.Min(val, Convert.ToInt32(num2 * (double)csn.f() * num * A_3));
						a.b = Math.Min(val2, Convert.ToInt32(num3 * (double)csn.f() * num * A_3));
						dictionary[skillEnum] = a;
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0600B6BC RID: 46780 RVA: 0x0040C310 File Offset: 0x0040A510
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B6BD RID: 46781 RVA: 0x0040C344 File Offset: 0x0040A544
	public override IList<string> bi()
	{
		return this.m;
	}

	// Token: 0x0600B6BE RID: 46782 RVA: 0x0040C350 File Offset: 0x0040A550
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(bnw.a, 5 * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B6BF RID: 46783 RVA: 0x0040C39C File Offset: 0x0040A59C
	public override string bo(cnm A_0)
	{
		double num;
		int num2;
		bnw.b(A_0, out num, out num2);
		double num3;
		int num4;
		bnw.a(A_0, out num3, out num4);
		return qv.a("Psi/MotorCognitiveTransference", new object[]
		{
			Convert.ToInt32(num3 * 100.0),
			num4,
			Convert.ToInt32(num * 100.0),
			num2,
			l4.a(bnw.d, false)
		});
	}

	// Token: 0x0600B6C0 RID: 46784 RVA: 0x0040C420 File Offset: 0x0040A620
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(40, new Type[]
			{
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B6C1 RID: 46785 RVA: 0x0040C474 File Offset: 0x0040A674
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B6C2 RID: 46786 RVA: 0x0040C478 File Offset: 0x0040A678
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B6C3 RID: 46787 RVA: 0x0040C480 File Offset: 0x0040A680
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B6C4 RID: 46788 RVA: 0x0040C488 File Offset: 0x0040A688
	protected override float cj(cnm A_0)
	{
		return 80f;
	}

	// Token: 0x0600B6C5 RID: 46789 RVA: 0x0040C490 File Offset: 0x0040A690
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B6C6 RID: 46790 RVA: 0x0040C4C4 File Offset: 0x0040A6C4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004260 RID: 16992
	public new static readonly string a = "Psi.MotorCognitiveTransference";

	// Token: 0x04004261 RID: 16993
	private const int b = 5;

	// Token: 0x04004262 RID: 16994
	public static readonly int c = 2;

	// Token: 0x04004263 RID: 16995
	public static readonly int d = 3;

	// Token: 0x04004264 RID: 16996
	private new const double e = 0.15;

	// Token: 0x04004265 RID: 16997
	private new const double f = 0.0025;

	// Token: 0x04004266 RID: 16998
	private new const double g = 0.8;

	// Token: 0x04004267 RID: 16999
	private new const double h = 0.8;

	// Token: 0x04004268 RID: 17000
	private new const double i = 0.1;

	// Token: 0x04004269 RID: 17001
	private new const double j = 0.00075;

	// Token: 0x0400426A RID: 17002
	private new const double k = 0.3;

	// Token: 0x0400426B RID: 17003
	private new const double l = 0.25;

	// Token: 0x0400426C RID: 17004
	private new List<string> m;

	// Token: 0x02001F0E RID: 7950
	[eiz("MCSSEa")]
	[Serializable]
	public new struct a : ISerializable
	{
		// Token: 0x0600B6C8 RID: 46792 RVA: 0x0040C4E0 File Offset: 0x0040A6E0
		public a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetString("MCSSEa:N");
			this.b = A_0.GetInt32("MCSSEa:B");
			this.c = A_0.GetInt32("MCSSEa:O");
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x0040C518 File Offset: 0x0040A718
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("MCSSEa:N", this.a);
			info.AddValue("MCSSEa:B", this.b);
			info.AddValue("MCSSEa:O", this.c);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x0040C550 File Offset: 0x0040A750
		public a(string A_0)
		{
			this.a = A_0;
			this.b = 0;
			this.c = 0;
		}

		// Token: 0x0400426D RID: 17005
		public string a;

		// Token: 0x0400426E RID: 17006
		public int b;

		// Token: 0x0400426F RID: 17007
		public int c;
	}
}
