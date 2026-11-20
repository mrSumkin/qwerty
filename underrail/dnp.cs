using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02001139 RID: 4409
[euj]
public sealed class dnp
{
	// Token: 0x06005E48 RID: 24136 RVA: 0x0027FECC File Offset: 0x0027E0CC
	[ayh("HLAAJ")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			amc b = A_1.h.b;
			if (b == null)
			{
				return;
			}
			eoj a_ = new eoj(b.aa(), b.aa().Gear.g().Item, null);
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(dnp.a.a.a)));
			bool flag = false;
			ah7 ah;
			if (bsf == null || bsf.Definition == null)
			{
				flag = true;
				ah = new ah7("headlamp", null);
				ah.Layer = aju.x;
			}
			else
			{
				ah = bsf.Definition;
			}
			float num = Math.Max(1f, qa.a(a_));
			float num2 = Math.Max(0.2f, qa.b(a_));
			float a_2 = num2 / (num + 0.5f);
			ah.Light = new ae8(new Color(255, 255, 200, 255), num2, LightType.Increment);
			ah.Range = num;
			ah.LightFadeRate = a_2;
			ah.Angle = 60f;
			ah.Direction = bnx.b(A_1.VisualDirection);
			if (flag)
			{
				ah.g().be(A_1);
			}
			else
			{
				ah.d();
			}
			bfq bfq = new bfq("headlightBuzzing", "HeadlightBuzzing");
			bfq.d(true);
			A_1.Zone.ActionManager.g9(new a4s(bfq, null, new ar7(A_1), null), atp.a);
		}
	}

	// Token: 0x06005E49 RID: 24137 RVA: 0x0028006C File Offset: 0x0027E26C
	[ayh("HLARJ")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(dnp.a.a.b)));
			if (bsf != null)
			{
				bsf.ig();
			}
			A_1.c().a("headlightBuzzing", false);
		}
	}

	// Token: 0x06005E4A RID: 24138 RVA: 0x002800D8 File Offset: 0x0027E2D8
	[ayh("HLATJ")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			amc aspect = A_1.GetAspect<amc>();
			if (aspect != null && aspect.aa().Gear.g().Item != null)
			{
				eoj a_ = new eoj(aspect.aa(), aspect.aa().Gear.g().Item, null);
				double a_2 = Math.Max(0.20000000298023224, qa.e(a_));
				aspect.aa().Gear.g().Item.a(a_2, true);
			}
		}
	}

	// Token: 0x06005E4B RID: 24139 RVA: 0x00280168 File Offset: 0x0027E368
	[ayh("HLAHBJ")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(dnp.a.a.c)));
			if (bsf != null && bsf.Definition != null)
			{
				Vector2 vector = bnx.b(A_1.VisualDirection);
				if (bsf.Definition.m != vector)
				{
					bsf.Definition.m = vector;
					bsf.b();
				}
			}
		}
	}

	// Token: 0x0200113A RID: 4410
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005E4F RID: 24143 RVA: 0x00280214 File Offset: 0x0027E414
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "headlamp";
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x00280238 File Offset: 0x0027E438
		internal bool b(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "headlamp";
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0028025C File Offset: 0x0027E45C
		internal bool c(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "headlamp";
		}

		// Token: 0x0400257F RID: 9599
		public static readonly dnp.a a = new dnp.a();

		// Token: 0x04002580 RID: 9600
		public static Func<bsf, bool> b;

		// Token: 0x04002581 RID: 9601
		public static Func<bsf, bool> c;

		// Token: 0x04002582 RID: 9602
		public static Func<bsf, bool> d;
	}
}
