using System;

// Token: 0x020018C6 RID: 6342
public static class b87
{
	// Token: 0x06008695 RID: 34453 RVA: 0x0037C718 File Offset: 0x0037A918
	public static bool b(efk A_0, efk A_1, coh A_2, double A_3 = 1.0)
	{
		double num = b87.a(A_0, A_1, A_2, A_3);
		A_1.Suspicion += num;
		return A_1.Suspicion < 1.5;
	}

	// Token: 0x06008696 RID: 34454 RVA: 0x0037C750 File Offset: 0x0037A950
	public static double a(efk A_0, efk A_1, coh A_2, double A_3 = 1.0)
	{
		double a_ = (double)A_1.Detection * (1.0 - Math.Min((double)A_1.Level * dwh.s, dwh.t)) / (double)Math.Max(1, A_0.Skills.Get<bq0>().g());
		return d05.b(0.45, a_, 5.0) * dwh.q[A_2.Definition.bj()] * dwh.r * A_3;
	}

	// Token: 0x06008697 RID: 34455 RVA: 0x0037C7D8 File Offset: 0x0037A9D8
	public static bool a(efk A_0, efk A_1)
	{
		return (double)A_1.Detection * (1.0 - Math.Min((double)A_1.Level * dwh.s, dwh.t)) / (double)Math.Max(1, A_0.Skills.Get<bq0>().g()) <= 2.5;
	}
}
