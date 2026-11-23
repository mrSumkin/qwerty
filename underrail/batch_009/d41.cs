using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000FF8 RID: 4088
public sealed class d41
{
	// Token: 0x0600541C RID: 21532 RVA: 0x00253C18 File Offset: 0x00251E18
	public bool? b()
	{
		return this.b;
	}

	// Token: 0x0600541D RID: 21533 RVA: 0x00253C20 File Offset: 0x00251E20
	public d41(c5x A_0, object A_1, float A_2, List<byte> A_3 = null)
	{
		this.d = A_0;
		this.e = A_1;
		this.f = A_2;
		if (A_3 != null && A_3.Count > 0)
		{
			this.h = new List<byte>(A_3);
		}
	}

	// Token: 0x0600541E RID: 21534 RVA: 0x00253C74 File Offset: 0x00251E74
	public void a()
	{
		this.a(this.d, this.e, this.f, true);
	}

	// Token: 0x0600541F RID: 21535 RVA: 0x00253C90 File Offset: 0x00251E90
	public void a(c5x A_0, object A_1, float A_2, bool A_3)
	{
		this.a = null;
		if (A_0 == null || A_1 == null || A_2 <= 0f)
		{
			this.b = new bool?(false);
			return;
		}
		this.b = null;
		this.c = Point.Zero;
		List<Point> list = new List<Point>();
		aud aud = null;
		ak1 ak = A_1 as ak1;
		if (ak != null)
		{
			aud = ak.Area;
			list.Add(ak.Location);
		}
		else
		{
			b0b b0b = A_1 as b0b;
			if (b0b != null)
			{
				if (b0b.j != cgy.b)
				{
					this.b = new bool?(false);
					return;
				}
				aud = b0b.Area;
				if ((b0b.Size.X > 1f || b0b.Size.Y > 1f) && b0b.l.Count > 1)
				{
					using (List<ak1>.Enumerator enumerator = b0b.l.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ak1 ak2 = enumerator.Current;
							list.Add(ak2.Location);
						}
						goto IL_131;
					}
				}
				list.Add(b0b.aj().a());
			}
		}
		IL_131:
		if (aud == null || aud != A_0.Area)
		{
			this.b = new bool?(false);
			return;
		}
		this.c = A_0.aj().a();
		for (int i = list.Count - 1; i >= 0; i--)
		{
			Point a_ = list[i];
			if (!aw1.a(bnx.a(this.c, a_), A_2))
			{
				list.RemoveAt(i);
			}
		}
		if (list.Count == 0)
		{
			this.b = new bool?(false);
			return;
		}
		this.i = list.Count;
		foreach (Point a_2 in list)
		{
			anp anp = aw1.b(a_2, aud, A_2, bcj.a(this.h), 0L);
			anp.a(new EventHandler<EventArgs>(this.a));
			if (A_3)
			{
				anp.k();
			}
			else
			{
				anp.j();
			}
		}
	}

	// Token: 0x06005420 RID: 21536 RVA: 0x00253EFC File Offset: 0x002520FC
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		if (this.g == null)
		{
			this.g = anp.f();
		}
		else
		{
			foreach (Point item in anp.f())
			{
				if (!this.g.Contains(item))
				{
					this.g.Add(item);
				}
			}
		}
		bool flag = anp.f().Contains(this.c);
		this.a = new bool?(this.a.GetValueOrDefault() || flag);
		int num = this.i - 1;
		this.i = num;
		if (num == 0)
		{
			this.b = new bool?(this.a.Value);
		}
	}

	// Token: 0x04002255 RID: 8789
	private bool? a;

	// Token: 0x04002256 RID: 8790
	private bool? b;

	// Token: 0x04002257 RID: 8791
	private Point c;

	// Token: 0x04002258 RID: 8792
	private c5x d;

	// Token: 0x04002259 RID: 8793
	private object e;

	// Token: 0x0400225A RID: 8794
	private float f;

	// Token: 0x0400225B RID: 8795
	private List<Point> g;

	// Token: 0x0400225C RID: 8796
	private List<byte> h = new List<byte>();

	// Token: 0x0400225D RID: 8797
	private int i;
}
