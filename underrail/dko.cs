using System;

// Token: 0x020018E2 RID: 6370
[eiz("SRIVF")]
[Serializable]
public sealed class dko : d76
{
	// Token: 0x060086EB RID: 34539 RVA: 0x0037DD54 File Offset: 0x0037BF54
	public double m1(coh A_0)
	{
		if (A_0 != null)
		{
			eoj a_ = new eoj(null, A_0, null);
			int num = bdj.b(a_);
			double num2 = bdj.c(a_) * (double)num;
			double num3 = (double)(2 - (num - cp3.f) / (cp3.g - cp3.f));
			double num4 = 1.5 - (double)(Math.Max(50, bdj.a(a_)) / cp3.h / 2);
			return num2 * dko.a * num3 * num4;
		}
		return 0.0;
	}

	// Token: 0x04003453 RID: 13395
	private static double a = 10.0;
}
