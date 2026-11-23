using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities.Psi;

// Token: 0x02001F13 RID: 7955
public static class b29
{
	// Token: 0x0600B719 RID: 46873 RVA: 0x0040CE78 File Offset: 0x0040B078
	static b29()
	{
		b29.a[PsiAbilityCategories.None] = "не псионических способностей";
		b29.a[PsiAbilityCategories.Damaging] = "наносящих урон";
		b29.a[PsiAbilityCategories.NonDamaging] = "не наносящих урон";
		b29.a[PsiAbilityCategories.Telekinetic] = "телекинетики";
	}

	// Token: 0x0600B71A RID: 46874 RVA: 0x0040CED4 File Offset: 0x0040B0D4
	public static string a(PsiAbilityCategories A_0, bool A_1)
	{
		string text = "";
		if (A_0 == PsiAbilityCategories.None)
		{
			text = qv.a("StaticEffects/PsiAbilityCategories_None", new object[0]);
			if (!A_1)
			{
				text = text.ToLowerInvariant();
			}
		}
		else
		{
			bool flag = true;
			foreach (object obj in Enum.GetValues(typeof(PsiAbilityCategories)))
			{
				PsiAbilityCategories psiAbilityCategories = (PsiAbilityCategories)obj;
				if (psiAbilityCategories != PsiAbilityCategories.None && (A_0 & psiAbilityCategories) == psiAbilityCategories)
				{
					if (!flag)
					{
						text += " ";
					}
					string text2 = qv.a("StaticEffects/PsiAbilityCategories_" + psiAbilityCategories.ToString(), new object[0]);
					if (!flag || !A_1)
					{
						text2 = text2.ToLowerInvariant();
					}
					text += text2;
					flag = false;
				}
			}
			text = text + " " + qv.a("StaticEffects/PsiAbilityCategories_psi_abilities", new object[0]);
		}
		return text;
	}

	// Token: 0x0400428D RID: 17037
	private static Dictionary<PsiAbilityCategories, string> a = new Dictionary<PsiAbilityCategories, string>();
}
