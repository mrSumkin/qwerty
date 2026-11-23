using System;

// Token: 0x02001B58 RID: 7000
public class e6l
{
	// Token: 0x0600979D RID: 38813 RVA: 0x003B156C File Offset: 0x003AF76C
	public void a(bke A_0, double A_1 = 1.0)
	{
		A_0.g(A_0.ab() + this.a * A_1);
		A_0.f(A_0.ai() + this.b * A_1);
		A_0.c(A_0.y() + this.c * A_1);
		if (A_0.e() == btz.c || A_0.e() == btz.f)
		{
			A_0.b(A_0.aj() + this.d);
		}
	}

	// Token: 0x0600979E RID: 38814 RVA: 0x003B15E4 File Offset: 0x003AF7E4
	public static e6l a(fv A_0)
	{
		e6l e6l = new e6l();
		if (A_0 != null)
		{
			e6l.a = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("PrecisionBonus", new double?(0.0)).Value;
			e6l.b = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("CriticalChanceBonus", new double?(0.0)).Value;
			e6l.c = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("CriticalDamageModifier", new double?(0.0)).Value;
			e6l.d = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("FocusPenaltyModifier", new double?(0.0)).Value;
			e6l.e = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ScopeType", new int?(0)).Value;
		}
		return e6l;
	}

	// Token: 0x04003A35 RID: 14901
	public double a;

	// Token: 0x04003A36 RID: 14902
	public double b;

	// Token: 0x04003A37 RID: 14903
	public double c;

	// Token: 0x04003A38 RID: 14904
	public double d;

	// Token: 0x04003A39 RID: 14905
	public int e;
}
