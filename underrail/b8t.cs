using System;
using System.Collections.Generic;
using Ouroboros.Events;

// Token: 0x02000558 RID: 1368
public sealed class b8t : GlobalEventHandler<c47>, ap1
{
	// Token: 0x06002302 RID: 8962 RVA: 0x000C07C4 File Offset: 0x000BE9C4
	public cj aer()
	{
		if (this.d != null)
		{
			return this.d.a();
		}
		return null;
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000C07E0 File Offset: 0x000BE9E0
	public int aes()
	{
		return this.c.Count;
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x000C07F0 File Offset: 0x000BE9F0
	public void c()
	{
		bpo.GetServiceOrThrow<eta>().RegisterHandler<c47>(this);
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x000C0800 File Offset: 0x000BEA00
	public void b()
	{
		bpo.GetServiceOrThrow<eta>().UnregisterHandler<c47>(this);
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000C0810 File Offset: 0x000BEA10
	public void a(double A_0)
	{
		if (this.d == null && this.c.Count > 0)
		{
			brc a_ = this.c.Dequeue();
			this.d = new uz(a_);
		}
		if (this.d != null)
		{
			if (this.d.e() == aib.a)
			{
				uz uz = this.d;
				uz.a(uz.b() + A_0 * 0.0025);
				if (this.d.b() >= 1.0)
				{
					this.d.a(1.0);
					this.d.a(aib.b);
					return;
				}
			}
			else if (this.d.e() == aib.c)
			{
				uz uz2 = this.d;
				uz2.a(uz2.b() - A_0 * 0.0025);
				if (this.d.b() <= 0.0)
				{
					this.d.a(0.0);
					this.d = null;
					return;
				}
			}
			else
			{
				uz uz3 = this.d;
				double num;
				uz3.b(num = uz3.c() - A_0);
				if (num <= 0.0)
				{
					this.d.b(0.0);
					this.d.a(aib.c);
				}
			}
		}
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000C096C File Offset: 0x000BEB6C
	public override void cr(c47 A_0)
	{
		op op = A_0 as op;
		if (op != null)
		{
			ecs ecs = op.ie();
			if (ecs != null && ecs.a != null && ecs.a.Count > 0)
			{
				brc brc = new brc(b8t.a(ecs), op.id().GetValueOrDefault(3000));
				this.c.Enqueue(brc);
			}
		}
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000C09DC File Offset: 0x000BEBDC
	private static dn3 a(ecs A_0)
	{
		foreach (dl6 dl in A_0.a)
		{
			if (dl.a != null)
			{
				foreach (bph bph in dl.a)
				{
					bph.a.a = b8t.a();
				}
			}
		}
		return A_0.b();
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x000C0A90 File Offset: 0x000BEC90
	private static string a()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			return egg.b;
		}
		return wj.i1;
	}

	// Token: 0x0400149A RID: 5274
	private const int a = 3000;

	// Token: 0x0400149B RID: 5275
	private const double b = 0.0025;

	// Token: 0x0400149C RID: 5276
	private Queue<brc> c = new Queue<brc>();

	// Token: 0x0400149D RID: 5277
	private uz d;
}
