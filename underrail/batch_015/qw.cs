using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C07 RID: 7175
public static class qw
{
	// Token: 0x06009CF8 RID: 40184 RVA: 0x003DA7DC File Offset: 0x003D89DC
	public static double a(double A_0, double A_1, btz A_2, double A_3)
	{
		return qw.a(A_0, A_1, as3.m[A_2], A_3, as3.n[A_2]);
	}

	// Token: 0x06009CF9 RID: 40185 RVA: 0x003DA808 File Offset: 0x003D8A08
	public static double a(double A_0, double A_1, double A_2, double A_3, double A_4)
	{
		double num = 1.0;
		if (A_1 > (double)as3.bb)
		{
			num -= A_2 * (A_1 - (double)as3.bb);
			if (A_1 > A_0)
			{
				num -= A_2 * (A_1 - A_0);
			}
		}
		num += A_3 / as3.a7 * A_4;
		return d05.b(as3.ba, num, 1.0);
	}

	// Token: 0x06009CFA RID: 40186 RVA: 0x003DA86C File Offset: 0x003D8A6C
	public static double c(double A_0, double A_1)
	{
		return 1.0 - d05.b(0.0, A_1 / Math.Max(1.0, A_0), 2.0) * as3.a3;
	}

	// Token: 0x06009CFB RID: 40187 RVA: 0x003DA8A8 File Offset: 0x003D8AA8
	public static double b(double A_0, double A_1)
	{
		return 1.0 - d05.b(0.0, A_1 / Math.Max(1.0, A_0), 3.0) * as3.a5;
	}

	// Token: 0x06009CFC RID: 40188 RVA: 0x003DA8E4 File Offset: 0x003D8AE4
	public static double a(double A_0, double A_1)
	{
		return d05.b(aiy.ae, 1.0 - Math.Max(1.0, A_0) / Math.Max(1.0, A_1) * aiy.ac, aiy.ad);
	}

	// Token: 0x06009CFD RID: 40189 RVA: 0x003DA928 File Offset: 0x003D8B28
	public static double a(bke A_0, double A_1)
	{
		if (A_0 != null && A_0.t())
		{
			float npcSkillModifier = euf.b().NpcSkillModifier;
			if (npcSkillModifier > 1f)
			{
				return Math.Max(0.0, A_1 - A_1 / (double)npcSkillModifier) * as3.o;
			}
			return 0.0;
		}
		else
		{
			if (euf.a(A_0))
			{
				return A_1 * as3.p;
			}
			return A_1 * as3.o;
		}
	}

	// Token: 0x06009CFE RID: 40190 RVA: 0x003DA99C File Offset: 0x003D8B9C
	public static double a(int A_0)
	{
		return (double)((aiy.ak + (A_0 - 1)) * aiy.aj);
	}

	// Token: 0x06009CFF RID: 40191 RVA: 0x003DA9B4 File Offset: 0x003D8BB4
	public static double a(int A_0, int A_1)
	{
		double num = qw.a(A_0);
		float num2 = c2h.d(A_1);
		return num * (double)(1f + num2);
	}

	// Token: 0x06009D00 RID: 40192 RVA: 0x003DA9D8 File Offset: 0x003D8BD8
	public static void a(bke A_0, WeaponSubtype? A_1, out double A_2, out int A_3)
	{
		A_2 = 0.0;
		A_3 = 0;
		WeaponSubtype? weaponSubtype = A_1;
		if (weaponSubtype == null && A_0 != null)
		{
			weaponSubtype = A_0.ae();
		}
		if (weaponSubtype != null && as3.ah.TryGetValue(weaponSubtype.Value, out A_2))
		{
			as3.ai.TryGetValue(weaponSubtype.Value, out A_3);
		}
		if (A_0 != null)
		{
			q5 q = A_0.u();
			if (q.b != null)
			{
				q = A_0.u();
				A_3 = q.b.Value;
			}
			q = A_0.u();
			if (q.a != null)
			{
				q = A_0.u();
				A_2 = q.a.Value;
			}
		}
	}

	// Token: 0x06009D01 RID: 40193 RVA: 0x003DAAA4 File Offset: 0x003D8CA4
	public static double a(efk A_0, bke A_1, WeaponSubtype? A_2)
	{
		if (A_1 != null && A_1.t())
		{
			d3m d3m = A_0.BaseAbilities.Get<d3m>();
			double num = 1.0 - Math.Min(1.0, (double)d3m.g() / (double)Math.Max(1, d3m.f()));
			return -as3.ar * num;
		}
		double num2;
		int num3;
		qw.a(A_1, A_2, out num2, out num3);
		if (A_0.BaseAbilities.Strength > num3)
		{
			return Math.Max(0.0, (double)(A_0.BaseAbilities.Strength - num3) * num2);
		}
		return 0.0;
	}

	// Token: 0x06009D02 RID: 40194 RVA: 0x003DAB4C File Offset: 0x003D8D4C
	public static int a(efk A_0)
	{
		int val = (int)((double)A_0.Detection * 0.5 + (double)A_0.Skills.Get<c0b>().g() * 0.75);
		return Math.Max((int)((double)A_0.Detection * 0.75), val);
	}
}
