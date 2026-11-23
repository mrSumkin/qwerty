using System;
using System.Collections.Generic;

// Token: 0x02000101 RID: 257
public class ag5 : v8
{
	// Token: 0x0600060D RID: 1549 RVA: 0x0001A9C4 File Offset: 0x00018BC4
	public ag5() : this(int.MaxValue)
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0001A9D4 File Offset: 0x00018BD4
	public ag5(int A_0)
	{
		this.g = A_0;
		this.b = new Queue<dci>();
		this.d = new Queue<dci>();
		this.c = new Queue<dci>();
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0001AA24 File Offset: 0x00018C24
	public bool oy()
	{
		return this.a;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0001AA2C File Offset: 0x00018C2C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0001AA38 File Offset: 0x00018C38
	public int c()
	{
		return this.b.Count + this.c.Count;
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0001AA54 File Offset: 0x00018C54
	public bool d()
	{
		return this.f != null;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0001AA60 File Offset: 0x00018C60
	public void oz(dci A_0)
	{
		this.o0(A_0, eso.d);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x0001AA70 File Offset: 0x00018C70
	public void o0(dci A_0, eso A_1)
	{
		czh.a(A_0, "client");
		if (this.a(A_0))
		{
			return;
		}
		if (A_1 > eso.d)
		{
			this.b.Enqueue(A_0);
			return;
		}
		if (this.c.Count > this.g)
		{
			this.d.Enqueue(A_0);
			return;
		}
		this.c.Enqueue(A_0);
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x0001AADC File Offset: 0x00018CDC
	public void o1(dci A_0)
	{
		if (this.f == A_0)
		{
			this.f = null;
		}
		if (this.c.Contains(A_0))
		{
			this.e.Add(A_0.qe());
		}
		if (this.b.Contains(A_0))
		{
			this.e.Add(A_0.qe());
		}
		if (this.d.Contains(A_0))
		{
			this.e.Add(A_0.qe());
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x0001AB64 File Offset: 0x00018D64
	public int b(int A_0)
	{
		int num = 0;
		while (num < A_0 && (this.f != null || this.a()))
		{
			if (this.b())
			{
				this.f = null;
			}
			else if (this.f != null)
			{
				this.oz(this.f);
				this.f = null;
			}
			num++;
		}
		return num;
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x0001ABCC File Offset: 0x00018DCC
	public int a(int A_0)
	{
		int num = 0;
		if (this.f == null && !this.a())
		{
			return num;
		}
		while (num < A_0 && (this.f != null || this.a()))
		{
			while (!this.b())
			{
			}
			num++;
			this.f = null;
		}
		return num;
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0001AC24 File Offset: 0x00018E24
	private bool b()
	{
		return this.f.anw();
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0001AC34 File Offset: 0x00018E34
	private bool a()
	{
		while (this.d.Count > 0 && this.c.Count < this.g)
		{
			dci dci = this.d.Dequeue();
			this.c.Enqueue(dci);
		}
		Queue<dci> queue;
		if (!this.h && this.b.Count > 0)
		{
			queue = this.b;
			this.h = true;
		}
		else
		{
			queue = this.c;
			this.h = false;
		}
		while (queue.Count > 0)
		{
			this.f = queue.Dequeue();
			if (!this.e.Contains(this.f.qe()))
			{
				this.f.anv();
				return true;
			}
			this.e.Remove(this.f.qe());
			this.f = null;
		}
		return false;
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0001AD28 File Offset: 0x00018F28
	private bool a(dci A_0)
	{
		czh.a(A_0, "client");
		return this.c.Contains(A_0) || this.d.Contains(A_0) || this.b.Contains(A_0);
	}

	// Token: 0x040004D4 RID: 1236
	private bool a = true;

	// Token: 0x040004D5 RID: 1237
	private Queue<dci> b;

	// Token: 0x040004D6 RID: 1238
	private Queue<dci> c;

	// Token: 0x040004D7 RID: 1239
	private Queue<dci> d;

	// Token: 0x040004D8 RID: 1240
	private List<Guid> e = new List<Guid>();

	// Token: 0x040004D9 RID: 1241
	private dci f;

	// Token: 0x040004DA RID: 1242
	private int g;

	// Token: 0x040004DB RID: 1243
	private bool h;
}
