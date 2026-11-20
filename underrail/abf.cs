using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002041 RID: 8257
public sealed class abf : euz
{
	// Token: 0x0600C3B9 RID: 50105 RVA: 0x0043DC78 File Offset: 0x0043BE78
	public abf(ax3 A_0, bsq A_1 = null)
	{
		czh.a(A_0, "window");
		wj wj = wj.a();
		this.d = A_0;
		this.c = A_1;
		if (wj.c())
		{
			esj esj = new esj(abf.a.c * (a0c.a.c + 1) - 1, abf.a.d * (a0c.a.d + 1) - 1);
			if (esj.d % 2 != 0)
			{
				esj.d++;
			}
			base.Size = esj;
		}
		else
		{
			esj a_ = new esj(abf.a.c * (wj.ez.c + 1) - 1, abf.a.d * (wj.ez.d + 1) - 1);
			wj.a(ref a_.d);
			base.Size = a_;
		}
		this.b = new a0c[abf.a.c, abf.a.d];
		for (int i = 0; i < abf.a.d; i++)
		{
			for (int j = 0; j < abf.a.c; j++)
			{
				a0c a0c = new a0c(this, this.c);
				if (wj.c())
				{
					a0c.Location = new Point(j * (a0c.a.c + 1), i * (a0c.a.d + 1));
				}
				else
				{
					a0c.Location = new Point(j * (wj.ez.c + 1), i * (wj.ez.d + 1));
				}
				this.b[j, i] = a0c;
				this.aox(a0c);
			}
		}
		this.a();
	}

	// Token: 0x0600C3BA RID: 50106 RVA: 0x0043DE4C File Offset: 0x0043C04C
	public void a()
	{
		List<c3n> list = new List<c3n>();
		cnk cnk = ces.a();
		if (cnk != null && cnk.aqu() != null && cnk.aqu().v() != null)
		{
			foreach (aia aia in cnk.aqu().v().PsiAbilities)
			{
				if (!string.IsNullOrEmpty(aia.CapabilityFullTypeName))
				{
					c3n c3n = dgk.a(aia.CapabilityFullTypeName);
					if (c3n != null)
					{
						list.Add(c3n);
					}
				}
			}
			list = new List<c3n>(Enumerable.Cast<c3n>(Enumerable.OrderBy<c7i, int>(Enumerable.OfType<c7i>(list), new Func<c7i, int>(abf.a.a.a))));
		}
		int num = 0;
		for (int i = 0; i < abf.a.d; i++)
		{
			for (int j = 0; j < abf.a.c; j++)
			{
				a0c a0c = this.b[j, i];
				if (list.Count > num)
				{
					a0c.i = list[num].TechnicalName;
				}
				else
				{
					a0c.i = null;
				}
				num++;
			}
		}
	}

	// Token: 0x04004736 RID: 18230
	private new static readonly esj a = new esj(11, 4);

	// Token: 0x04004737 RID: 18231
	private new a0c[,] b;

	// Token: 0x04004738 RID: 18232
	private new bsq c;

	// Token: 0x04004739 RID: 18233
	public new ax3 d;

	// Token: 0x02002042 RID: 8258
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C3BE RID: 50110 RVA: 0x0043DFDC File Offset: 0x0043C1DC
		internal int a(c7i A_0)
		{
			return (int)(A_0.School * (PsiSchool)1000 + A_0.Tier);
		}

		// Token: 0x0400473A RID: 18234
		public static readonly abf.a a = new abf.a();

		// Token: 0x0400473B RID: 18235
		public static Func<c7i, int> b;
	}
}
