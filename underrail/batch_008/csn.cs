using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E32 RID: 7730
[eiz("S5")]
[Serializable]
public abstract class csn : Stat<int>, ISerializable
{
	// Token: 0x0600AB48 RID: 43848 RVA: 0x003F6334 File Offset: 0x003F4534
	protected csn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("S5:N");
			this.b = (SkillCategory)A_0.GetValue("S5:C", typeof(SkillCategory));
			return;
		}
		if (base.GetType() == typeof(csn))
		{
			this.a = A_0.GetString("_Name");
			this.b = (SkillCategory)A_0.GetValue("_Category", typeof(SkillCategory));
			return;
		}
		this.a = A_0.GetString("Skill+_Name");
		this.b = (SkillCategory)A_0.GetValue("Skill+_Category", typeof(SkillCategory));
	}

	// Token: 0x0600AB49 RID: 43849 RVA: 0x003F6404 File Offset: 0x003F4604
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S5:N", this.a);
		info.AddValue("S5:C", this.b);
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x0600AB4A RID: 43850
	public abstract string Name { get; }

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600AB4B RID: 43851
	public abstract SkillCategory Category { get; }

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x003F6438 File Offset: 0x003F4638
	public ech Skills
	{
		get
		{
			return base.e() as ech;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x0600AB4D RID: 43853 RVA: 0x003F6448 File Offset: 0x003F4648
	public Dictionary<Type, float> Synergies
	{
		get
		{
			return this.fj() ?? new Dictionary<Type, float>();
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x003F645C File Offset: 0x003F465C
	public Dictionary<Type, float> BaseAbilityBonuses
	{
		get
		{
			return this.fi() ?? new Dictionary<Type, float>();
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x0600AB4F RID: 43855 RVA: 0x003F6470 File Offset: 0x003F4670
	public virtual string DLC
	{
		get
		{
			return null;
		}
	}

	// Token: 0x0600AB50 RID: 43856 RVA: 0x003F6474 File Offset: 0x003F4674
	protected csn(int A_0 = 0, ech A_1 = null) : base(A_0)
	{
		base.a(A_0);
		base.a(A_1);
	}

	// Token: 0x0600AB51 RID: 43857 RVA: 0x003F648C File Offset: 0x003F468C
	public void a()
	{
		if (base.g() < 0)
		{
			base.b(0);
		}
	}

	// Token: 0x0600AB52 RID: 43858 RVA: 0x003F64A4 File Offset: 0x003F46A4
	public override string ToString()
	{
		return this.a;
	}

	// Token: 0x0600AB53 RID: 43859 RVA: 0x003F64AC File Offset: 0x003F46AC
	public virtual string aib()
	{
		return null;
	}

	// Token: 0x0600AB54 RID: 43860 RVA: 0x003F64B4 File Offset: 0x003F46B4
	internal void a(efk A_0, int? A_1 = null)
	{
		float num = 1f;
		if (base.e() != null && base.e().re() != null)
		{
			float num2 = float.MinValue;
			foreach (KeyValuePair<Type, float> keyValuePair in this.BaseAbilityBonuses)
			{
				to to = base.e().re().BaseAbilities.b(keyValuePair.Key);
				if (to != null)
				{
					int a_ = 0;
					this.av9(A_0, ref a_);
					float num3 = keyValuePair.Value * to.a(a_);
					if (num3 > num2)
					{
						num2 = num3;
					}
				}
			}
			num += num2;
		}
		if (base.e() != null && base.e().re() != null && !(base.e().re() is e3q))
		{
			if (base.e().re().b(d8o.o))
			{
				num *= euf.b().NpcBossSkillModifier;
			}
			else
			{
				num *= euf.b().NpcSkillModifier;
			}
		}
		base.b((int)((float)A_1.GetValueOrDefault(base.f()) * num));
	}

	// Token: 0x0600AB55 RID: 43861 RVA: 0x003F6604 File Offset: 0x003F4804
	protected virtual void av9(efk A_0, ref int A_1)
	{
	}

	// Token: 0x0600AB56 RID: 43862 RVA: 0x003F6608 File Offset: 0x003F4808
	protected override void ah5(ref int A_0)
	{
		A_0 = Math.Max(0, A_0);
	}

	// Token: 0x0600AB57 RID: 43863 RVA: 0x003F6618 File Offset: 0x003F4818
	internal void a(Dictionary<csn, int> A_0 = null)
	{
		this.c = false;
		int num = base.g();
		if (this.Skills != null && base.e() != null && base.e().re() != null && base.g() < csn.a(base.e().re().Level))
		{
			foreach (KeyValuePair<Type, float> keyValuePair in this.Synergies)
			{
				csn csn = this.Skills.b(keyValuePair.Key);
				if (csn != null)
				{
					int num2;
					int num3;
					if (A_0 != null && A_0.TryGetValue(csn, out num2))
					{
						num3 = num2;
					}
					else
					{
						num3 = csn.f();
					}
					int num4 = (int)(keyValuePair.Value * (float)num3);
					base.b(Math.Min(base.g() + num4, csn.a(base.e().re().Level)));
				}
			}
		}
		this.c = (base.g() > num);
	}

	// Token: 0x0600AB58 RID: 43864 RVA: 0x003F6748 File Offset: 0x003F4948
	protected virtual Dictionary<Type, float> fi()
	{
		return null;
	}

	// Token: 0x0600AB59 RID: 43865 RVA: 0x003F674C File Offset: 0x003F494C
	protected virtual Dictionary<Type, float> fj()
	{
		return null;
	}

	// Token: 0x0600AB5A RID: 43866 RVA: 0x003F6754 File Offset: 0x003F4954
	protected override void lm(object A_0, c1 A_1)
	{
		if (base.e() != null && base.e().re() != null)
		{
			base.e().re().bl();
		}
	}

	// Token: 0x0600AB5B RID: 43867 RVA: 0x003F678C File Offset: 0x003F498C
	public static int a(int A_0)
	{
		return aiy.aj * (A_0 + 2);
	}

	// Token: 0x0600AB5C RID: 43868 RVA: 0x003F6798 File Offset: 0x003F4998
	public static string a(Type A_0)
	{
		czh.a(A_0, "skillType");
		if (!typeof(csn).IsAssignableFrom(A_0))
		{
			return null;
		}
		a1 a = Enumerable.FirstOrDefault<a1>(Enumerable.OfType<a1>(A_0.GetCustomAttributes(typeof(a1), true)));
		if (a != null)
		{
			return a.Name;
		}
		return null;
	}

	// Token: 0x04003FEF RID: 16367
	private string a;

	// Token: 0x04003FF0 RID: 16368
	private SkillCategory b;

	// Token: 0x04003FF1 RID: 16369
	public bool c;
}
