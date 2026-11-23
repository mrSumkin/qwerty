using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02002036 RID: 8246
public class b93 : dhf
{
	// Token: 0x0600C358 RID: 50008 RVA: 0x00439FB8 File Offset: 0x004381B8
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x0600C359 RID: 50009 RVA: 0x00439FC4 File Offset: 0x004381C4
	public b93(List<euz> A_0, int A_1, int A_2, int A_3, int A_4, int A_5) : base(A_0, A_3, A_4, A_5, A_2, A_1, -1, null, 26)
	{
		foreach (euz euz in A_0)
		{
			eko eko = (eko)euz;
			this.a.Add(eko);
			this.a();
			eko.b(new EventHandler<EventArgs>(this.a));
			eko.a(new EventHandler<EventArgs>(this.a));
		}
	}

	// Token: 0x0600C35A RID: 50010 RVA: 0x0043A078 File Offset: 0x00438278
	public b93(List<euz> A_0, int A_1, int A_2) : this(A_0, 3, 0, 5, A_2, A_1)
	{
	}

	// Token: 0x0600C35B RID: 50011 RVA: 0x0043A088 File Offset: 0x00438288
	private void a()
	{
		this.b.Clear();
		foreach (eko eko in Enumerable.ToList<eko>(Enumerable.Where<eko>(this.a, new Func<eko, bool>(b93.a.a.a))))
		{
			this.b.Add(eko.Code);
		}
	}

	// Token: 0x0600C35C RID: 50012 RVA: 0x0043A124 File Offset: 0x00438324
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

	// Token: 0x0600C35D RID: 50013 RVA: 0x0043A19C File Offset: 0x0043839C
	public override void xj(euz A_0)
	{
		eko eko = A_0 as eko;
		if (eko != null)
		{
			eko.a(new EventHandler<EventArgs>(this.a));
		}
		this.a.Add(eko);
		this.a();
		base.xj(A_0);
	}

	// Token: 0x0600C35E RID: 50014 RVA: 0x0043A1E4 File Offset: 0x004383E4
	public override void xk(euz A_0, int A_1)
	{
		if (A_1 < 0 || A_1 > this.a.Count)
		{
			return;
		}
		eko eko = A_0 as eko;
		if (eko != null)
		{
			if (!base.f() && !eko.IsColapsed)
			{
				if (Enumerable.FirstOrDefault<eko>(Enumerable.Where<eko>(this.a, new Func<eko, bool>(b93.a.a.b))) != null)
				{
					eko.IsColapsed = true;
				}
			}
			eko.a(new EventHandler<EventArgs>(this.a));
		}
		this.a.Insert(A_1, eko);
		this.a();
		base.xk(A_0, A_1);
	}

	// Token: 0x0600C35F RID: 50015 RVA: 0x0043A298 File Offset: 0x00438498
	public override void xl(euz A_0)
	{
		eko eko = A_0 as eko;
		if (eko != null)
		{
			eko.b(new EventHandler<EventArgs>(this.a));
		}
		this.a.Remove(eko);
		this.a();
		base.xl(A_0);
	}

	// Token: 0x0600C360 RID: 50016 RVA: 0x0043A2E0 File Offset: 0x004384E0
	public override void xm(int A_0)
	{
		if (A_0 < 0 || A_0 > this.a.Count - 1)
		{
			return;
		}
		eko eko = this.a[A_0];
		if (eko != null)
		{
			eko.b(new EventHandler<EventArgs>(this.a));
		}
		this.a.RemoveAt(A_0);
		this.a();
		base.xm(A_0);
	}

	// Token: 0x0600C361 RID: 50017 RVA: 0x0043A348 File Offset: 0x00438548
	public override void xn()
	{
		foreach (eko eko in this.a)
		{
			eko.b(new EventHandler<EventArgs>(this.a));
		}
		base.xn();
	}

	// Token: 0x0600C362 RID: 50018 RVA: 0x0043A3B0 File Offset: 0x004385B0
	public euz a(object A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		foreach (eko eko in this.a)
		{
			if (eko.Tag == A_0)
			{
				return eko;
			}
		}
		return null;
	}

	// Token: 0x0600C363 RID: 50019 RVA: 0x0043A420 File Offset: 0x00438620
	private void a(object A_0, EventArgs A_1)
	{
		eko eko = A_0 as eko;
		if (!base.f() && !eko.IsColapsed)
		{
			foreach (eko eko2 in this.a)
			{
				if (eko2 != eko && !eko2.IsColapsed)
				{
					eko2.IsColapsed = true;
					base.a(eko2, null);
					break;
				}
			}
		}
		base.a(eko, null);
		this.a();
	}

	// Token: 0x040046EF RID: 18159
	private new List<eko> a = new List<eko>();

	// Token: 0x040046F0 RID: 18160
	private new List<string> b = new List<string>();

	// Token: 0x02002037 RID: 8247
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C366 RID: 50022 RVA: 0x0043A4D8 File Offset: 0x004386D8
		internal bool a(eko A_0)
		{
			return !A_0.IsColapsed;
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x0043A4E4 File Offset: 0x004386E4
		internal bool b(eko A_0)
		{
			return !A_0.IsColapsed;
		}

		// Token: 0x040046F1 RID: 18161
		public static readonly b93.a a = new b93.a();

		// Token: 0x040046F2 RID: 18162
		public static Func<eko, bool> b;

		// Token: 0x040046F3 RID: 18163
		public static Func<eko, bool> c;
	}
}
