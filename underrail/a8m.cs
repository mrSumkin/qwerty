using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200084A RID: 2122
public abstract class a8m : el4
{
	// Token: 0x06003497 RID: 13463 RVA: 0x00143958 File Offset: 0x00141B58
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x00143964 File Offset: 0x00141B64
	public override string a4()
	{
		return "XPBL_DB_PIR" + this.a.ToString();
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x0014397C File Offset: 0x00141B7C
	public override string a5()
	{
		return "Мёртвый пират " + this.a.ToString();
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x00143994 File Offset: 0x00141B94
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x0600349B RID: 13467 RVA: 0x0014399C File Offset: 0x00141B9C
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x001439A0 File Offset: 0x00141BA0
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x001439A8 File Offset: 0x00141BA8
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x001439C0 File Offset: 0x00141BC0
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600349F RID: 13471 RVA: 0x001439C4 File Offset: 0x00141BC4
	public a8m(int A_0) : base(new string[]
	{
		ega.bc
	})
	{
		this.a = A_0;
	}

	// Token: 0x060034A0 RID: 13472 RVA: 0x001439E4 File Offset: 0x00141BE4
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
					if (this.a != 2)
					{
						List<string> list = new List<string>
						{
							"xpbl_pr1",
							"xpbl_pr2",
							"xpbl_pr3",
							"xpbl_pr4",
							"xpbl_pr5",
							"xpbl_pr6",
							"xpbl_pr_f1",
							"xpbl_pr_f2",
							"xpbl_pr_f3",
							"xpbl_pr_f4"
						};
						string str = list[random.Next(0, list.Count)];
						aspect.a = "Creatures\\" + str + "\\di";
					}
					aspect.b.Y = random.Next(0, 8);
					a_ = d06.a(a_);
				}
			}
		}
	}

	// Token: 0x04001B87 RID: 7047
	private new int a;
}
