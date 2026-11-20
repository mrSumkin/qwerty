using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200058A RID: 1418
public sealed class ek2 : ex7
{
	// Token: 0x060024CA RID: 9418 RVA: 0x000CFF08 File Offset: 0x000CE108
	public cyt a()
	{
		return this.a;
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000CFF14 File Offset: 0x000CE114
	public bool atb(string A_0, bool A_1 = true)
	{
		if (!this.a(A_0))
		{
			eei eei = ao5.a(A_0);
			if (eei != null)
			{
				this.a.t().c().Insert(0, new eza(eei));
				if (A_1)
				{
					this.e(eei);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x000CFF68 File Offset: 0x000CE168
	public bool atc(string A_0, bool A_1 = true)
	{
		ek2.c c = new ek2.c();
		c.a = A_0;
		eza eza = Enumerable.FirstOrDefault<eza>(Enumerable.Where<eza>(this.a.t().c(), new Func<eza, bool>(c.a)));
		if (eza != null)
		{
			this.a.t().c().Remove(eza);
			eza.State = e3c.b;
			eza.Read = false;
			this.a.t().a().Insert(0, eza);
			if (eza.Value != null && A_1)
			{
				this.c(eza.Value);
			}
		}
		return false;
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000D0008 File Offset: 0x000CE208
	public bool atd(string A_0, bool A_1 = true)
	{
		ek2.b b = new ek2.b();
		b.a = A_0;
		eza eza = Enumerable.FirstOrDefault<eza>(Enumerable.Where<eza>(this.a.t().c(), new Func<eza, bool>(b.a)));
		if (eza != null)
		{
			this.a.t().c().Remove(eza);
			eza.State = e3c.c;
			eza.Read = false;
			this.a.t().b().Insert(0, eza);
			if (eza.Value != null && A_1)
			{
				this.b(eza.Value);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000D00AC File Offset: 0x000CE2AC
	private bool a(string A_0)
	{
		ek2.a a = new ek2.a();
		a.a = A_0;
		return Enumerable.Any<eza>(this.a.t().c(), new Func<eza, bool>(a.a)) || Enumerable.Any<eza>(this.a.t().a(), new Func<eza, bool>(a.b)) || Enumerable.Any<eza>(this.a.t().b(), new Func<eza, bool>(a.c));
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x000D0140 File Offset: 0x000CE340
	public void a(cyt A_0)
	{
		this.b();
		this.a = A_0;
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000D0150 File Offset: 0x000CE350
	public void b()
	{
		if (this.a != null)
		{
			this.a = null;
		}
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000D0164 File Offset: 0x000CE364
	private void e(eei A_0)
	{
		a7v.a(new bxa(A_0));
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000D0174 File Offset: 0x000CE374
	private void d(eei A_0)
	{
		a7v.a(new j6(A_0));
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000D0184 File Offset: 0x000CE384
	private void c(eei A_0)
	{
		a7v.a(new cd5(A_0));
		if (this.a.v() != null)
		{
			c5x c5x = this.a.v().b() as c5x;
			if (c5x != null && c5x.h.b != null && A_0.ClassicExperience > 0)
			{
				e3q e3q = c5x.h.b.aa() as e3q;
				if (e3q != null && e3q.e() == ExperienceSystem.Oddity)
				{
					if (A_0.OddityExperience > 0)
					{
						c5x.h.b.a(A_0.OddityExperience, null);
						return;
					}
				}
				else
				{
					c5x.h.b.a(A_0.ClassicExperience, null);
				}
			}
		}
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x000D0248 File Offset: 0x000CE448
	private void b(eei A_0)
	{
		a7v.a(new cwz(A_0));
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000D0258 File Offset: 0x000CE458
	private void a(eei A_0)
	{
		ek2.d d = new ek2.d();
		d.a = A_0;
		eza eza = Enumerable.FirstOrDefault<eza>(Enumerable.Where<eza>(this.a.t().c(), new Func<eza, bool>(d.a)));
		if (eza != null)
		{
			this.a.t().c().Remove(eza);
		}
		if (eza != null)
		{
			eza.State = e3c.c;
			this.a.t().b().Insert(0, eza);
		}
	}

	// Token: 0x04001561 RID: 5473
	private cyt a;

	// Token: 0x0200058C RID: 1420
	[CompilerGenerated]
	private sealed class d
	{
		// Token: 0x060024DB RID: 9435 RVA: 0x000D02EC File Offset: 0x000CE4EC
		internal bool a(eza A_0)
		{
			return A_0.Value == this.a;
		}

		// Token: 0x04001562 RID: 5474
		public eei a;
	}

	// Token: 0x0200058D RID: 1421
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x060024DD RID: 9437 RVA: 0x000D0304 File Offset: 0x000CE504
		internal bool a(eza A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x04001563 RID: 5475
		public string a;
	}

	// Token: 0x0200058E RID: 1422
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060024DF RID: 9439 RVA: 0x000D0320 File Offset: 0x000CE520
		internal bool a(eza A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x04001564 RID: 5476
		public string a;
	}

	// Token: 0x0200058F RID: 1423
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060024E1 RID: 9441 RVA: 0x000D033C File Offset: 0x000CE53C
		internal bool a(eza A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000D0350 File Offset: 0x000CE550
		internal bool b(eza A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000D0364 File Offset: 0x000CE564
		internal bool c(eza A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x04001565 RID: 5477
		public string a;
	}
}
