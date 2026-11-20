using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200084D RID: 2125
public abstract class a5t : el4
{
	// Token: 0x060034A3 RID: 13475 RVA: 0x00143B54 File Offset: 0x00141D54
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x00143B60 File Offset: 0x00141D60
	public override string a4()
	{
		return "XPBL_DB_SOR" + this.a.ToString();
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x00143B78 File Offset: 0x00141D78
	public override string a5()
	{
		return "Мёртвый соурмирбэрен " + this.a.ToString();
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x00143B90 File Offset: 0x00141D90
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x00143B98 File Offset: 0x00141D98
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00143B9C File Offset: 0x00141D9C
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00143BA4 File Offset: 0x00141DA4
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x00143BBC File Offset: 0x00141DBC
	public override bool a9()
	{
		return true;
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x00143BC0 File Offset: 0x00141DC0
	public a5t(int A_0) : base(new string[]
	{
		ega.bb
	})
	{
		this.a = A_0;
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00143BE0 File Offset: 0x00141DE0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"deadBody",
				base.c()
			})) as c5x;
			c5x a_ = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"blood",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				cd0 aspect = c5x.GetAspect<cd0>();
				if (aspect != null)
				{
					Random random = new Random();
					List<string> list = new List<string>
					{
						"xpbl_svgw1",
						"xpbl_svgw2",
						"xpbl_svgw3",
						"xpbl_svgw4"
					};
					string str = list[random.Next(0, list.Count)];
					aspect.a = "Creatures\\" + str + "\\di";
					aspect.b.Y = random.Next(0, 8);
					a_ = d06.a(a_);
				}
			}
		}
	}

	// Token: 0x04001B88 RID: 7048
	private new int a;
}
