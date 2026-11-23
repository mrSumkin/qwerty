using System;
using System.Linq;

// Token: 0x02000FA5 RID: 4005
public static class c7w
{
	// Token: 0x060051D3 RID: 20947 RVA: 0x0024C474 File Offset: 0x0024A674
	public static void a(efk A_0, int A_1)
	{
		if (A_0 != null)
		{
			int num = A_0.CustomProperties.GetPrimitivePropertyValue<int>("motionDrags", new int?(0)).Value;
			num += A_1;
			A_0.CustomProperties["motionDrags"] = num;
		}
	}

	// Token: 0x060051D4 RID: 20948 RVA: 0x0024C4C0 File Offset: 0x0024A6C0
	public static void a(c5x A_0, int A_1)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			e3q e3q = A_0.h.b.aa() as e3q;
			if (e3q != null)
			{
				c7w.a(e3q, A_1);
			}
			y4 y = Enumerable.FirstOrDefault<y4>(A_0.h.b.aa().StatusEffects.Get<y4>());
			y4 y2 = new y4(30000);
			y2.Stacks = Math.Min(A_1, y2.MaxStacks);
			if (y != null)
			{
				y2.f = y.f;
				y2.e = y.e;
				y2.g = y.g;
			}
			byf byf = Enumerable.FirstOrDefault<byf>(A_0.h.b.aa().StatusEffects.Get<byf>());
			if (byf != null)
			{
				A_0.h.b.aa().StatusEffects.d(byf);
			}
			due due = Enumerable.FirstOrDefault<due>(A_0.h.b.aa().StatusEffects.Get<due>());
			if (due != null)
			{
				A_0.h.b.aa().StatusEffects.d(due);
			}
			A_0.h.b.aa().StatusEffects.a(y2, true, false, false);
			eyr eyr = new eyr(y2.Duration + Convert.ToInt32((25.0 + 25.0 * cuo.a.NextDouble()) * 60.0 * 1000.0));
			eyr.a = 1;
			eyr eyr2 = Enumerable.FirstOrDefault<eyr>(A_0.h.b.aa().StatusEffects.Get<eyr>());
			if (eyr2 != null)
			{
				eyr.a += eyr2.a;
			}
			A_0.h.b.aa().StatusEffects.a(eyr, true, false, true);
		}
	}
}
