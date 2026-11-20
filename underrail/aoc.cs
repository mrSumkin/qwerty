using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F16 RID: 7958
public abstract class aoc : a8s, c7i
{
	// Token: 0x0600B73F RID: 46911
	public abstract PsiSchool ch();

	// Token: 0x0600B740 RID: 46912
	public abstract int ci();

	// Token: 0x0600B741 RID: 46913 RVA: 0x0040D350 File Offset: 0x0040B550
	public override int bh()
	{
		return (int)(this.ch() * (PsiSchool)1000 + this.ci());
	}

	// Token: 0x0600B742 RID: 46914 RVA: 0x0040D368 File Offset: 0x0040B568
	public override string bm(cnm A_0)
	{
		return "Psi." + this.TechnicalName;
	}

	// Token: 0x0600B743 RID: 46915 RVA: 0x0040D37C File Offset: 0x0040B57C
	public override bool hm(cnm A_0)
	{
		return A_0.b8() != null && !A_0.b8().SpecialStates.d && A_0.b8().Feats.Contains<c3v>() && (!dm9.f || !(A_0.b8() is e3q) || A_0.b8().Offense.a(this.TechnicalName)) && base.hm(A_0);
	}

	// Token: 0x0600B744 RID: 46916 RVA: 0x0040D400 File Offset: 0x0040B600
	public override bool cu(cnm A_0)
	{
		return A_0.b8() != null && !A_0.b8().SpecialStates.d && A_0.b8().Feats.Contains<c3v>() && (!dm9.f || !(A_0.b8() is e3q) || A_0.b8().Offense.a(this.TechnicalName)) && base.cu(A_0);
	}

	// Token: 0x0600B745 RID: 46917 RVA: 0x0040D484 File Offset: 0x0040B684
	public virtual List<brl> ck()
	{
		return new List<brl>();
	}

	// Token: 0x0600B746 RID: 46918 RVA: 0x0040D48C File Offset: 0x0040B68C
	protected virtual PsiAbilityCategories b(cnm A_0)
	{
		return PsiAbilityCategories.None;
	}

	// Token: 0x0600B747 RID: 46919 RVA: 0x0040D494 File Offset: 0x0040B694
	protected virtual float c(cnm A_0)
	{
		float num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = (float)A_0.b8().Offense.ag()[this.ch()].f();
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
			double num2 = 1.0;
			PsiAbilityCategories psiAbilityCategories = this.b(A_0);
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
}
