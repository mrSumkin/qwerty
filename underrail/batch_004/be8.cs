using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02002053 RID: 8275
public class be8 : dhf
{
	// Token: 0x0600C46E RID: 50286 RVA: 0x00443DF8 File Offset: 0x00441FF8
	public List<int> e()
	{
		return this.b;
	}

	// Token: 0x0600C46F RID: 50287 RVA: 0x00443E00 File Offset: 0x00442000
	internal List<bcn> d()
	{
		return this.a;
	}

	// Token: 0x0600C470 RID: 50288 RVA: 0x00443E0C File Offset: 0x0044200C
	public be8(List<euz> A_0, int A_1, int A_2, int A_3, int A_4, int A_5) : base(A_0, A_3, A_4, A_5, A_2, A_1, 0, be8.b(), be8.c())
	{
		wj.a();
		this.a.Clear();
		foreach (euz euz in A_0)
		{
			bcn bcn = (bcn)euz;
			this.a.Add(bcn);
			bcn.aum(new EventHandler<EventArgs>(this.a));
			bcn.aul(new EventHandler<EventArgs>(this.a));
		}
		this.a();
	}

	// Token: 0x0600C471 RID: 50289 RVA: 0x00443ED8 File Offset: 0x004420D8
	private new static int c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			return 26;
		}
		return wj.bm.c;
	}

	// Token: 0x0600C472 RID: 50290 RVA: 0x00443F04 File Offset: 0x00442104
	private static Type b()
	{
		if (wj.a().c())
		{
			return null;
		}
		return typeof(dg8);
	}

	// Token: 0x0600C473 RID: 50291 RVA: 0x00443F24 File Offset: 0x00442124
	private void a()
	{
		this.b.Clear();
		foreach (bcn item in Enumerable.ToList<bcn>(Enumerable.Where<bcn>(this.a, new Func<bcn, bool>(be8.a.a.a))))
		{
			this.b.Add(this.a.IndexOf(item));
		}
	}

	// Token: 0x0600C474 RID: 50292 RVA: 0x00443FC4 File Offset: 0x004421C4
	private void a(object A_0, EventArgs A_1)
	{
		bcn bcn = A_0 as bcn;
		if (!base.f())
		{
			foreach (bcn bcn2 in this.a)
			{
				if (bcn2 != bcn && !bcn2.IsColapsed)
				{
					bcn2.IsColapsed = true;
					base.a(bcn2 as euz, null);
					break;
				}
			}
		}
		base.a(bcn as euz, null);
		this.a();
	}

	// Token: 0x0600C475 RID: 50293 RVA: 0x00444068 File Offset: 0x00442268
	public void a(List<int> A_0)
	{
		foreach (int num in A_0)
		{
			if (num > 0 && num < this.a.Count)
			{
				this.a[num].IsColapsed = false;
			}
		}
	}

	// Token: 0x0600C476 RID: 50294 RVA: 0x004440E0 File Offset: 0x004422E0
	public override void xj(euz A_0)
	{
		bcn bcn = A_0 as bcn;
		if (bcn != null)
		{
			bcn.aul(new EventHandler<EventArgs>(this.a));
		}
		this.a.Insert(0, bcn);
		this.a();
		base.xj(A_0);
	}

	// Token: 0x0600C477 RID: 50295 RVA: 0x00444128 File Offset: 0x00442328
	public override void xk(euz A_0, int A_1)
	{
		if (A_1 < 0 || A_1 > this.a.Count)
		{
			return;
		}
		bcn bcn = A_0 as bcn;
		if (bcn != null)
		{
			if (!base.f() && !bcn.IsColapsed)
			{
				if (Enumerable.FirstOrDefault<bcn>(Enumerable.Where<bcn>(this.a, new Func<bcn, bool>(be8.a.a.b))) != null)
				{
					bcn.IsColapsed = true;
				}
			}
			bcn.aul(new EventHandler<EventArgs>(this.a));
		}
		this.a.Insert(A_1, bcn);
		this.a();
		base.xk(A_0, A_1);
	}

	// Token: 0x0600C478 RID: 50296 RVA: 0x004441DC File Offset: 0x004423DC
	public override void xl(euz A_0)
	{
		bcn bcn = A_0 as bcn;
		if (bcn != null)
		{
			bcn.aum(new EventHandler<EventArgs>(this.a));
		}
		this.a.Remove(bcn);
		this.a();
		base.xl(A_0);
	}

	// Token: 0x0600C479 RID: 50297 RVA: 0x00444224 File Offset: 0x00442424
	public override void xm(int A_0)
	{
		if (A_0 < 0 || A_0 > this.a.Count - 1)
		{
			return;
		}
		bcn bcn = this.a[A_0];
		if (bcn != null)
		{
			bcn.aum(new EventHandler<EventArgs>(this.a));
		}
		this.a.RemoveAt(A_0);
		this.a();
		base.xm(A_0);
	}

	// Token: 0x0600C47A RID: 50298 RVA: 0x0044428C File Offset: 0x0044248C
	public override void xn()
	{
		foreach (bcn bcn in this.a)
		{
			bcn.aum(new EventHandler<EventArgs>(this.a));
		}
		base.xn();
	}

	// Token: 0x0600C47B RID: 50299 RVA: 0x004442F4 File Offset: 0x004424F4
	public euz a(object A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		foreach (bcn bcn in this.a)
		{
			euz euz = (euz)bcn;
			if (euz.Tag == A_0)
			{
				return euz;
			}
		}
		return null;
	}

	// Token: 0x0400479B RID: 18331
	private new List<bcn> a = new List<bcn>();

	// Token: 0x0400479C RID: 18332
	private new List<int> b = new List<int>();

	// Token: 0x02002054 RID: 8276
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C47E RID: 50302 RVA: 0x00444380 File Offset: 0x00442580
		internal bool a(bcn A_0)
		{
			return !A_0.IsColapsed;
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x0044438C File Offset: 0x0044258C
		internal bool b(bcn A_0)
		{
			return !A_0.IsColapsed;
		}

		// Token: 0x0400479D RID: 18333
		public static readonly be8.a a = new be8.a();

		// Token: 0x0400479E RID: 18334
		public static Func<bcn, bool> b;

		// Token: 0x0400479F RID: 18335
		public static Func<bcn, bool> c;
	}
}
