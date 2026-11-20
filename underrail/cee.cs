using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Lightning;

// Token: 0x0200122D RID: 4653
[eiz("ETASE1")]
public sealed class cee : cf9
{
	// Token: 0x0600644D RID: 25677 RVA: 0x002B1628 File Offset: 0x002AF828
	public void rx(els A_0, amc A_1)
	{
		axg axg = A_0 as axg;
		if (A_1 != null && axg != null && axg.a != null)
		{
			cee.a a = new cee.a();
			c5x c5x = A_1.a8();
			if (c5x == null)
			{
				return;
			}
			a.a = "electricTorch_" + axg.a.Id.ToString();
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(c5x.RaysEmitters), new Func<bsf, bool>(a.a)));
			if (bsf == null || bsf.Definition == null)
			{
				new ah7(a.a, null)
				{
					Layer = aju.x,
					Light = new ae8(c5c.h, (float)c5c.e, LightType.Increment),
					Range = Convert.ToSingle(c5c.g),
					LightFadeRate = Convert.ToSingle(c5c.f)
				}.g().be(c5x);
			}
			bfq bfq = new bfq("electricTorchBuzzing", "ElectricTorchBuzzing");
			bfq.d(true);
			c5x.Zone.ActionManager.g9(new a4s(bfq, null, new ar7(c5x), null), atp.a);
		}
	}

	// Token: 0x0600644E RID: 25678 RVA: 0x002B1758 File Offset: 0x002AF958
	public void ry(els A_0, amc A_1)
	{
		axg axg = A_0 as axg;
		if (A_1 != null && axg != null && axg.a != null)
		{
			cee.b b = new cee.b();
			c5x c5x = A_1.a8();
			if (c5x == null)
			{
				return;
			}
			b.a = "electricTorch_" + axg.a.Id.ToString();
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(c5x.RaysEmitters), new Func<bsf, bool>(b.a)));
			if (bsf != null)
			{
				bsf.ig();
			}
			c5x.c().a("electricTorchBuzzing", false);
		}
	}

	// Token: 0x0600644F RID: 25679 RVA: 0x002B1804 File Offset: 0x002AFA04
	public void rz(els A_0, amc A_1)
	{
		this.rx(A_0, A_1);
	}

	// Token: 0x06006450 RID: 25680 RVA: 0x002B1810 File Offset: 0x002AFA10
	public void r0(els A_0, amc A_1)
	{
		this.ry(A_0, A_1);
	}

	// Token: 0x06006451 RID: 25681 RVA: 0x002B181C File Offset: 0x002AFA1C
	public void r1(els A_0, amc A_1)
	{
	}

	// Token: 0x06006452 RID: 25682 RVA: 0x002B1820 File Offset: 0x002AFA20
	public void r2(els A_0, amc A_1)
	{
		this.ry(A_0, A_1);
	}

	// Token: 0x0200122E RID: 4654
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06006455 RID: 25685 RVA: 0x002B183C File Offset: 0x002AFA3C
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == this.a;
		}

		// Token: 0x04002A0F RID: 10767
		public string a;
	}

	// Token: 0x0200122F RID: 4655
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06006457 RID: 25687 RVA: 0x002B186C File Offset: 0x002AFA6C
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == this.a;
		}

		// Token: 0x04002A10 RID: 10768
		public string a;
	}
}
