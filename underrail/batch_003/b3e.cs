using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020000FE RID: 254
public class b3e : d1f
{
	// Token: 0x06000602 RID: 1538 RVA: 0x0001A5BC File Offset: 0x000187BC
	public euo a()
	{
		return this.a;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0001A5C4 File Offset: 0x000187C4
	public void b(euo A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0001A5D0 File Offset: 0x000187D0
	public override bool ac8()
	{
		return false;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0001A5DC File Offset: 0x000187DC
	protected override void ac9()
	{
		if (this.b != null && this.b.Count > 0)
		{
			foreach (p2 p in this.b)
			{
				p.e();
			}
		}
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0001A650 File Offset: 0x00018850
	protected override void ada()
	{
		if (this.b != null && this.b.Count > 0)
		{
			foreach (p2 p in this.b)
			{
				p.d();
			}
		}
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0001A6C4 File Offset: 0x000188C4
	protected override void adb()
	{
		List<p2> list = new List<p2>();
		Rectangle rectangle = base.h();
		bde a_ = new bde();
		for (int i = rectangle.Top; i <= rectangle.Bottom; i++)
		{
			for (int j = rectangle.Left; j <= rectangle.Right; j++)
			{
				int num = j - base.ai().X;
				int num2 = i - base.ai().Y;
				if (Convert.ToInt32(Math.Sqrt(Math.Pow((double)num, 2.0) + Math.Pow((double)num2, 2.0))) <= (int)base.ag().b())
				{
					Vector2 zero = Vector2.Zero;
					p2 p = null;
					float num3;
					if (Math.Sign(num) == 0)
					{
						num3 = 0.5f;
					}
					else if (Math.Sign(num) == 1)
					{
						num3 = 0f;
					}
					else
					{
						num3 = 0.99f;
					}
					float num4;
					if (Math.Sign(num2) == 0)
					{
						num4 = 0.5f;
					}
					else if (Math.Sign(num2) == 1)
					{
						num4 = 0f;
					}
					else
					{
						num4 = 0.99f;
					}
					Vector2 a_2 = new Vector2((float)base.ai().X + 0.5f, (float)base.ai().Y + 0.5f);
					euo a_3 = euo.a;
					if ((this.a() & euo.a) == euo.a)
					{
						zero = new Vector2((float)j + 0.5f, (float)i + 0.5f);
						p = exm.a(base.ag(), a_2, zero).a(a_);
					}
					if ((p == null || !p.b()) && (this.a() & euo.c) == euo.c)
					{
						a_3 = euo.c;
						zero = new Vector2((float)j + num3, (float)i + num4);
						p = exm.a(base.ag(), a_2, zero).a(a_);
					}
					if ((p == null || !p.b()) && (this.a() & euo.b) == euo.b)
					{
						a_3 = euo.b;
						zero = new Vector2((float)j + 0.5f, (float)i + num4);
						p = exm.a(base.ag(), a_2, zero).a(a_);
						if (p == null || !p.b())
						{
							zero = new Vector2((float)j + num3, (float)i + 0.5f);
							p = exm.a(base.ag(), a_2, zero).a(a_);
						}
					}
					if (p != null && p.b())
					{
						p.a(b3e.a(a_3));
						list.Add(p);
					}
				}
			}
		}
		this.b = list;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0001A980 File Offset: 0x00018B80
	protected override void adc()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0001A988 File Offset: 0x00018B88
	protected override void add()
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0001A98C File Offset: 0x00018B8C
	private static float a(euo A_0)
	{
		switch (A_0)
		{
		case euo.a:
			return 1f;
		case euo.b:
		case euo.c:
			return 0.5f;
		}
		return 0f;
	}

	// Token: 0x040004CD RID: 1229
	private euo a;

	// Token: 0x040004CE RID: 1230
	private List<p2> b;
}
