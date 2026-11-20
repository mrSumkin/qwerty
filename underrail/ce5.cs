using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F0C RID: 7948
public abstract class ce5 : ehl, c7i
{
	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x0600B69F RID: 46751
	public abstract PsiSchool School { get; }

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x0600B6A0 RID: 46752
	public abstract int Tier { get; }

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x0040BA84 File Offset: 0x00409C84
	public override int Order
	{
		get
		{
			return (int)(this.School * (PsiSchool)1000 + this.Tier);
		}
	}

	// Token: 0x0600B6A3 RID: 46755 RVA: 0x0040BAA4 File Offset: 0x00409CA4
	public override string bm(cnm A_0)
	{
		return "Psi." + this.TechnicalName;
	}

	// Token: 0x0600B6A4 RID: 46756 RVA: 0x0040BAB8 File Offset: 0x00409CB8
	public float e(cnm A_0)
	{
		return this.cj(A_0) * this.f(A_0);
	}

	// Token: 0x0600B6A5 RID: 46757 RVA: 0x0040BACC File Offset: 0x00409CCC
	public override string bp(cnm A_0)
	{
		return "Invoke " + this.Name;
	}

	// Token: 0x0600B6A6 RID: 46758 RVA: 0x0040BAE0 File Offset: 0x00409CE0
	public override bool hm(cnm A_0)
	{
		if (A_0.b8() == null)
		{
			return false;
		}
		if (!A_0.b8().PsiAbilities.c(this) || A_0.b8().SpecialStates.d || !A_0.b8().Feats.Contains<c3v>())
		{
			return false;
		}
		if (dm9.f && A_0.b8() is e3q && !A_0.b8().Offense.a(this.TechnicalName))
		{
			return false;
		}
		float num = this.e(A_0);
		return A_0.b8().i((int)num) && base.hm(A_0);
	}

	// Token: 0x0600B6A7 RID: 46759 RVA: 0x0040BB98 File Offset: 0x00409D98
	public override bool cu(cnm A_0)
	{
		return A_0.b8() != null && A_0.b8().PsiAbilities.c(this) && !A_0.b8().SpecialStates.d && (!dm9.f || !(A_0.b8() is e3q) || A_0.b8().Offense.a(this.TechnicalName)) && base.cu(A_0);
	}

	// Token: 0x0600B6A8 RID: 46760 RVA: 0x0040BC20 File Offset: 0x00409E20
	public override bna iw(cnm A_0)
	{
		return bna.b;
	}

	// Token: 0x0600B6A9 RID: 46761 RVA: 0x0040BC24 File Offset: 0x00409E24
	public override int afh(cnm A_0)
	{
		int num = base.afh(A_0);
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<cvc>() && (int)A_0.b8().Defense.q().zo() == (int)A_0.b8().Defense.q().zm())
		{
			num = Math.Max(0, num - (int)((double)cvc.a + (double)A_0.b8().GetSpecializationValue<a2u>(true) * a2u.a));
		}
		return num;
	}

	// Token: 0x0600B6AA RID: 46762 RVA: 0x0040BCB8 File Offset: 0x00409EB8
	public virtual List<brl> ck()
	{
		return new List<brl>();
	}

	// Token: 0x0600B6AB RID: 46763 RVA: 0x0040BCC0 File Offset: 0x00409EC0
	public override float afi(cnm A_0)
	{
		float num = base.afi(A_0);
		if ((this.cm(A_0) & PsiAbilityCategories.Telekinetic) != PsiAbilityCategories.None && A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<cqf>())
		{
			num += 1f;
		}
		return num;
	}

	// Token: 0x0600B6AC RID: 46764
	protected abstract float cj(cnm A_0);

	// Token: 0x0600B6AD RID: 46765 RVA: 0x0040BD14 File Offset: 0x00409F14
	protected virtual float f(cnm A_0)
	{
		float num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = (float)A_0.b8().Offense.ag()[this.School].f();
		}
		else
		{
			num = 1f;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().Feats.Contains<c80>())
			{
				num *= (float)((double)(1f + c80.b) - (double)A_0.b8().GetSpecializationValue<bk7>(true) * bk7.a);
			}
			if (A_0.b8().Feats.Contains<eh3>())
			{
				num *= (float)(1.0 - eh3.b);
			}
			if (A_0.b8().StatusEffects.a(f9.a))
			{
				num *= (float)(1.0 - e9.a(A_0));
			}
			double num2 = 1.0;
			PsiAbilityCategories psiAbilityCategories = this.cm(A_0);
			if (psiAbilityCategories != PsiAbilityCategories.None)
			{
				foreach (de7 de in A_0.b8().GetMicrofeats<de7>())
				{
					if ((de.a() & psiAbilityCategories) == psiAbilityCategories)
					{
						num2 = Math.Max(0.0, num2 + de.b());
					}
				}
			}
			if (num2 != 1.0)
			{
				num *= Convert.ToSingle(num2);
			}
		}
		return num;
	}

	// Token: 0x0600B6AE RID: 46766 RVA: 0x0040BEA4 File Offset: 0x0040A0A4
	protected override float cl(cnm A_0)
	{
		float num = 1f;
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().StatusEffects.a(f9.a))
			{
				num *= (float)(1.0 - pv.e);
			}
			double num2 = 1.0;
			PsiAbilityCategories psiAbilityCategories = this.cm(A_0);
			if (psiAbilityCategories != PsiAbilityCategories.None)
			{
				foreach (a09 a in A_0.b8().GetMicrofeats<a09>())
				{
					if ((a.a() & psiAbilityCategories) == psiAbilityCategories)
					{
						num2 = Math.Max(0.0, num2 + a.b());
					}
				}
			}
			if (num2 != 1.0)
			{
				num *= Convert.ToSingle(num2);
			}
		}
		return num;
	}

	// Token: 0x0600B6AF RID: 46767 RVA: 0x0040BF98 File Offset: 0x0040A198
	protected override float afj(cnm A_0)
	{
		float num = base.afj(A_0);
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(f9.a))
		{
			num += pv.a;
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<aq2>())
		{
			num += (float)aq2.a;
		}
		return num;
	}

	// Token: 0x0600B6B0 RID: 46768 RVA: 0x0040C010 File Offset: 0x0040A210
	protected new static int? a(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				return coh.Definition.a7().GetPrimitivePropertyValue<int>("PsiSkillLevelOverride", null);
			}
		}
		return null;
	}

	// Token: 0x0600B6B1 RID: 46769 RVA: 0x0040C068 File Offset: 0x0040A268
	protected static int GetEffectivePsiSkillLevel<T>(cnm invocationSet) where T : eoh
	{
		int result = 0;
		if (invocationSet != null)
		{
			int? num = ce5.a(invocationSet);
			if (num != null)
			{
				result = num.Value;
			}
			else if (invocationSet.b8() != null)
			{
				T t = invocationSet.b8().Skills.Get<T>();
				if (t != null)
				{
					result = t.g();
				}
			}
		}
		return result;
	}

	// Token: 0x0600B6B2 RID: 46770 RVA: 0x0040C0D4 File Offset: 0x0040A2D4
	protected virtual PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.None;
	}
}
