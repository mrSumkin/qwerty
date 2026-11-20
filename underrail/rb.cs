using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001822 RID: 6178
[ayj("RemoteScanCallOverload")]
public sealed class rb : m0
{
	// Token: 0x06008383 RID: 33667 RVA: 0x0036EA3C File Offset: 0x0036CC3C
	public override string y8()
	{
		return "Вызов перегрузки удалённым сканированием";
	}

	// Token: 0x06008384 RID: 33668 RVA: 0x0036EA44 File Offset: 0x0036CC44
	public override string os()
	{
		return "RemoteScanCallOverload";
	}

	// Token: 0x06008385 RID: 33669 RVA: 0x0036EA4C File Offset: 0x0036CC4C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008386 RID: 33670 RVA: 0x0036EA50 File Offset: 0x0036CC50
	public override int bh()
	{
		return 1;
	}

	// Token: 0x06008387 RID: 33671 RVA: 0x0036EA54 File Offset: 0x0036CC54
	public override bool hl()
	{
		return true;
	}

	// Token: 0x06008388 RID: 33672 RVA: 0x0036EA58 File Offset: 0x0036CC58
	public override IList<string> bi()
	{
		return new List<string>
		{
			rb.e
		};
	}

	// Token: 0x06008389 RID: 33673 RVA: 0x0036EA6C File Offset: 0x0036CC6C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpell);
	}

	// Token: 0x0600838A RID: 33674 RVA: 0x0036EA74 File Offset: 0x0036CC74
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.j,
			d = new int?(65)
		};
	}

	// Token: 0x0600838B RID: 33675 RVA: 0x0036EA94 File Offset: 0x0036CC94
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600838C RID: 33676 RVA: 0x0036EA9C File Offset: 0x0036CC9C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.ActiveCamera;
	}

	// Token: 0x0600838D RID: 33677 RVA: 0x0036EAA0 File Offset: 0x0036CCA0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Utilities/RemoteScanCallOverload", new object[]
		{
			Convert.ToInt32(rb.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600838E RID: 33678 RVA: 0x0036EAD0 File Offset: 0x0036CCD0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600838F RID: 33679 RVA: 0x0036EADC File Offset: 0x0036CCDC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(rb.e, rb.f * d0u.b, false, false)
		};
	}

	// Token: 0x06008390 RID: 33680 RVA: 0x0036EB04 File Offset: 0x0036CD04
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 == null)
		{
			return false;
		}
		coh coh = A_0.b9() as coh;
		return coh != null && coh.Battery >= (double)rb.d;
	}

	// Token: 0x06008391 RID: 33681 RVA: 0x0036EB4C File Offset: 0x0036CD4C
	protected override int br(cnm A_0)
	{
		return 2500;
	}

	// Token: 0x06008392 RID: 33682 RVA: 0x0036EB54 File Offset: 0x0036CD54
	protected override int hi(cnm A_0)
	{
		return rb.h;
	}

	// Token: 0x06008393 RID: 33683 RVA: 0x0036EB5C File Offset: 0x0036CD5C
	protected override float f0(cnm A_0)
	{
		return 13f;
	}

	// Token: 0x06008394 RID: 33684 RVA: 0x0036EB64 File Offset: 0x0036CD64
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x06008395 RID: 33685 RVA: 0x0036EB68 File Offset: 0x0036CD68
	public new static double a(cnm A_0)
	{
		double num = rb.a;
		if (A_0 != null && A_0.b8() != null)
		{
			int num2 = A_0.b8().Skills.Get<adx>().g();
			if (num2 > 0)
			{
				double num3 = Math.Min(1.0, (double)num2 / (double)rb.c);
				num = Math.Round(num + (rb.b - rb.a) * num3, 2);
			}
		}
		return num;
	}

	// Token: 0x04003285 RID: 12933
	public new static readonly double a = 0.35;

	// Token: 0x04003286 RID: 12934
	public static readonly double b = 1.0;

	// Token: 0x04003287 RID: 12935
	public static readonly int c = 125;

	// Token: 0x04003288 RID: 12936
	public static readonly int d = 20;

	// Token: 0x04003289 RID: 12937
	public new static readonly string e = "RemoteScanCallOverload";

	// Token: 0x0400328A RID: 12938
	public static readonly int f = 4;

	// Token: 0x0400328B RID: 12939
	public new static readonly int g = 5;

	// Token: 0x0400328C RID: 12940
	public new static readonly int h = 25;
}
