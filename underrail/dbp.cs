using System;
using System.Collections.Generic;

// Token: 0x0200068B RID: 1675
public static class dbp
{
	// Token: 0x06002AF6 RID: 10998 RVA: 0x000F91C0 File Offset: 0x000F73C0
	static dbp()
	{
		euy euy = new euy("спину трупа", null, true);
		euy euy2 = euy.a("голову и шею", true);
		euy2.a("затылок и чуть выше", true);
		euy2.a("затылок и чуть ниже", true);
		euy2.a("шею сзади", true);
		euy euy3 = euy.a("torso", true);
		euy3.a("левую лопатку", true);
		euy3.a("правую лопатку", true);
		euy3.a("верхнюю часть позвоночника", true);
		euy3.a("среднюю часть позвоночника", true);
		euy3.a("левую часть поясницы", true);
		euy3.a("правую часть поясницы", true);
		euy euy4 = euy.a("руку", true);
		euy4.a("заднюю часть левого плеча", false);
		euy4.a("заднюю часть правого плеча", false);
		euy4.a("плечо левой руки", false);
		euy4.a("плечо правой руки", false);
		euy4.a("локоть левой руки", false);
		euy4.a("локоть правой руки", false);
		euy4.a("заднюю часть предплечья левой руки", false);
		euy4.a("заднюю часть предплечья правой руки", false);
		euy euy5 = euy.a("legs", true);
		euy5.a("левую ягодицу", false);
		euy5.a("правую ягодицу", false);
		euy5.a("левое подколенное сухожилие", true);
		euy5.a("правое подколенное сухожилие", true);
		euy5.a("заднюю часть левого колена", false);
		euy5.a("заднюю часть правого колена", false);
		euy5.a("заднюю часть левой лодыжки", false);
		euy5.a("заднюю часть правой лодыжки", false);
		euy5.a("левую пятку", false);
		euy5.a("правую пятку", false);
		euy euy6 = new euy("грудь трупа", null, true);
		euy euy7 = euy6.a("голову и шею", true);
		euy7.a("лоб", true);
		euy7.a("левый глаз", true);
		euy7.a("правый глаз", true);
		euy7.a("нос", true);
		euy7.a("mouth", true);
		euy7.a("горло", true);
		euy euy8 = euy6.a("torso", true);
		euy8.a("левое плечо", false);
		euy8.a("правое плечо", false);
		euy8.a("левую часть груди", true);
		euy8.a("правую часть груди", true);
		euy8.a("левую верхнюю часть грудной клетки", true);
		euy8.a("правую верхнюю часть грудной клетки", true);
		euy8.a("левую нижнюю часть грудной клетки", true);
		euy8.a("правую нижнюю часть грудной клетки", true);
		euy8.a("верхнюю часть живота", true);
		euy8.a("нижнюю часть живота", true);
		euy8.a("пах", true);
		euy euy9 = euy6.a("legs", true);
		euy9.a("левый тазобедренный сустав", true);
		euy9.a("правый тазобедренный сустав", true);
		euy9.a("левое бедро", true);
		euy9.a("правое бедро", true);
		euy9.a("левое колено", false);
		euy9.a("правое колено", false);
		euy9.a("левую голень", false);
		euy9.a("правую голень", false);
		euy9.a("левую лодыжку", false);
		euy9.a("правую лодыжку", false);
		euy9.a("левую ногу", false);
		euy9.a("правую ногу", false);
		dbp.a.Add(euy);
		dbp.a.Add(euy6);
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x000F952C File Offset: 0x000F772C
	public static euy a(int A_0)
	{
		List<euy> list = new List<euy>();
		dbp.a(list, dbp.a);
		Random random = new Random(A_0);
		return list[random.Next(list.Count)];
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x000F9564 File Offset: 0x000F7764
	private static void a(List<euy> A_0, List<euy> A_1)
	{
		foreach (euy euy in A_1)
		{
			if (euy.c.Count == 0)
			{
				A_0.Add(euy);
			}
			else
			{
				dbp.a(A_0, euy.c);
			}
		}
	}

	// Token: 0x040018AC RID: 6316
	public static readonly List<euy> a = new List<euy>();
}
