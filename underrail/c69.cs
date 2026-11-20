using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FCC RID: 8140
public static class c69
{
	// Token: 0x0600BF32 RID: 48946 RVA: 0x00422828 File Offset: 0x00420A28
	public static bool a(ebk A_0, ebk A_1, coh A_2, bool A_3 = false)
	{
		if (A_0 != null && A_2 != null)
		{
			if (A_1 != null && A_1.yx() != null && c69.a(A_2, A_1.yx()) && A_1.yx().Stacks < A_1.yx().Definition.be())
			{
				int num = Math.Min(A_2.Stacks, A_1.yx().Definition.be() - A_1.yx().Stacks);
				int a_ = A_1.yx().Stacks;
				A_1.yx().Stacks += num;
				A_1.yx().agn(A_2);
				A_1.yc(A_1.yx(), a_, A_1.yx().Stacks);
				if (num == A_2.Stacks)
				{
					A_0.yd();
				}
				else
				{
					int a_2 = A_2.Stacks;
					A_2.Stacks -= num;
					A_0.yc(A_2, a_2, A_2.Stacks);
				}
				return true;
			}
			if ((!A_0.yy() || A_0.yx() == A_2) && (A_0.yd() == A_2 || !A_0.yy()) && A_1 != null && A_1.ye(A_0, A_2))
			{
				coh coh = A_1.yb(A_2, A_3);
				if (coh != null && A_0.ye(A_1, coh))
				{
					A_0.yb(coh, false);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BF33 RID: 48947 RVA: 0x00422994 File Offset: 0x00420B94
	public static bool a(coh A_0, coh A_1)
	{
		return A_0 != null && A_1 != null && (A_0.fx(A_1) && !string.IsNullOrEmpty(A_0.Definition.a5()) && !string.IsNullOrEmpty(A_1.Definition.a5())) && A_0.Definition.a5().Equals(A_1.Definition.a5());
	}

	// Token: 0x0600BF34 RID: 48948 RVA: 0x00422A04 File Offset: 0x00420C04
	public static bool b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null || (serviceOrThrow.aqu().v().IsInControl && !serviceOrThrow.aqu().v().SpecialStates.f);
	}

	// Token: 0x0600BF35 RID: 48949 RVA: 0x00422A64 File Offset: 0x00420C64
	public static bool a()
	{
		if (dz6.e())
		{
			return true;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInCombat;
	}

	// Token: 0x040044BB RID: 17595
	public static readonly Color a = Color.White * 0.5f;
}
