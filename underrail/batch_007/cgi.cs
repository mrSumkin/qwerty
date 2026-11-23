using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200021A RID: 538
internal class cgi
{
	// Token: 0x06000F0B RID: 3851 RVA: 0x0003EF34 File Offset: 0x0003D134
	public IList<e6u> a()
	{
		return this.b.Values;
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0003EF44 File Offset: 0x0003D144
	public cgi(er0 A_0, IEnumerable<d0z> A_1)
	{
		czh.a(A_0, "session");
		this.a = A_0;
		this.a(A_1);
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
	public void a(d0z A_0)
	{
		cgi.a a = new cgi.a();
		a.a = A_0;
		for (int i = this.b.Count - 1; i >= 0; i--)
		{
			IEnumerable<abo> enumerable = this.b.Values[i].d;
			Func<abo, bool> func;
			if ((func = a.b) == null)
			{
				func = (a.b = new Func<abo, bool>(a.a));
			}
			if (Enumerable.Any<abo>(enumerable, func))
			{
				this.b.RemoveAt(i);
			}
		}
		for (int j = this.e.Count - 1; j >= 0; j--)
		{
			if (this.e[j].a == a.a)
			{
				this.e.RemoveAt(j);
			}
		}
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x0003F070 File Offset: 0x0003D270
	private void a(IEnumerable<d0z> A_0)
	{
		if (A_0 != null)
		{
			foreach (d0z d0z in A_0)
			{
				if (d0z.c.e != chj.c)
				{
					this.a(d0z.c);
				}
				if (d0z.d.e != chj.c)
				{
					this.a(d0z.d);
				}
			}
			List<e6u> list = new List<e6u>();
			list.Add(new e6u(this.a));
			List<e6u> list2 = new List<e6u>();
			for (int i = 1; i <= this.d.Count; i++)
			{
				List<e6u> list3 = new List<e6u>();
				foreach (abo a_ in this.d)
				{
					foreach (e6u e6u in list)
					{
						if (e6u.b(a_))
						{
							e6u e6u2 = e6u.b();
							e6u2.a(a_);
							list2.Add(e6u2);
							if (i != this.d.Count)
							{
								list3.Add(e6u2.b());
							}
						}
					}
				}
				list = list3;
			}
			foreach (e6u e6u3 in list2)
			{
				if (e6u3.c())
				{
					this.a(e6u3);
				}
			}
		}
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x0003F260 File Offset: 0x0003D460
	private void a(abo A_0)
	{
		this.d.Add(A_0);
		this.e.Add(A_0);
		if (A_0.e == chj.b)
		{
			this.f.Add(A_0.c);
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x0003F298 File Offset: 0x0003D498
	private void a(e6u A_0)
	{
		this.b.Add(A_0, A_0);
		this.c.Add(A_0);
	}

	// Token: 0x04000903 RID: 2307
	private er0 a;

	// Token: 0x04000904 RID: 2308
	private SortedList<e6u, e6u> b = new SortedList<e6u, e6u>();

	// Token: 0x04000905 RID: 2309
	public List<e6u> c = new List<e6u>();

	// Token: 0x04000906 RID: 2310
	public List<abo> d = new List<abo>();

	// Token: 0x04000907 RID: 2311
	public List<abo> e = new List<abo>();

	// Token: 0x04000908 RID: 2312
	public HashSet<ee4> f = new HashSet<ee4>();

	// Token: 0x0200021B RID: 539
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000F12 RID: 3858 RVA: 0x0003F2BC File Offset: 0x0003D4BC
		internal bool a(abo A_0)
		{
			return A_0.a == this.a;
		}

		// Token: 0x04000909 RID: 2313
		public d0z a;

		// Token: 0x0400090A RID: 2314
		public Func<abo, bool> b;
	}
}
