using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Events;
using Ouroboros.Common.RayTracing;

// Token: 0x020000FA RID: 250
public class dlx : d1f, cro, dci
{
	// Token: 0x060005C5 RID: 1477 RVA: 0x000186EC File Offset: 0x000168EC
	public a6h d()
	{
		return this.g;
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x000186F4 File Offset: 0x000168F4
	public void a(a6h A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00018700 File Offset: 0x00016900
	public float f()
	{
		return this.h;
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00018708 File Offset: 0x00016908
	public void a(float A_0)
	{
		if (A_0 < 0f || A_0 > 1f)
		{
			throw new ArgumentOutOfRangeException("value", "Greater intersection must be between 0 and 1.");
		}
		this.h = A_0;
		this.i = 1f - this.h;
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00018754 File Offset: 0x00016954
	public IEventSubscriber<a8f> ant()
	{
		return this.j;
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0001875C File Offset: 0x0001695C
	public void anu(IEventSubscriber<a8f> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00018768 File Offset: 0x00016968
	public v8 b()
	{
		return this.l;
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00018770 File Offset: 0x00016970
	public void a(v8 A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001877C File Offset: 0x0001697C
	public override bool ac8()
	{
		return this.l != null && this.l.oy();
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00018798 File Offset: 0x00016998
	public bde c()
	{
		return this.n;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x000187A0 File Offset: 0x000169A0
	public void a(bde A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x000187AC File Offset: 0x000169AC
	public dlx()
	{
		this.i = 1f - this.h;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00018808 File Offset: 0x00016A08
	public void e()
	{
		if (this.l != null && this.l.oy())
		{
			this.o = false;
			this.l.oz(this);
			base.a(FieldOfVisionState.MarkedForUpdate);
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00018840 File Offset: 0x00016A40
	public void anv()
	{
		if (this.o)
		{
			return;
		}
		this.o = true;
		base.a(FieldOfVisionState.Updating);
		this.m = new ebo(base.ai(), this.k);
		this.k = beb.a;
		this.a(this.m.b());
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00018898 File Offset: 0x00016A98
	public bool anw()
	{
		foreach (beb beb in dlx.b)
		{
			if (this.m.b(beb))
			{
				List<p2> list = this.a(this.m.c(), beb);
				this.b(list);
				this.m.d().AddRange(list);
				this.m.a(beb);
				break;
			}
		}
		if (this.m.a() == beb.a)
		{
			this.a();
			return true;
		}
		return false;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00018950 File Offset: 0x00016B50
	private void a()
	{
		this.b(this.m.b());
		this.c.AddRange(this.m.d());
		this.a(this.m.d(), false);
		this.m = null;
		base.g();
		this.o = false;
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x000189AC File Offset: 0x00016BAC
	private void b(beb A_0)
	{
		if (this.c.Count > 0)
		{
			for (int i = this.c.Count - 1; i >= 0; i--)
			{
				p2 p = this.c[i];
				if ((A_0 & p.a()) == p.a())
				{
					p.d();
					this.c.RemoveAt(i);
				}
			}
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00018A18 File Offset: 0x00016C18
	private void a(List<p2> A_0, bool A_1)
	{
		List<p2> list = A_0;
		if (list == null)
		{
			list = this.c;
		}
		if (list != null && list.Count > 0)
		{
			foreach (p2 p in list)
			{
				p.e();
				if (A_1 && this.j != null)
				{
					this.j.a(p.f(), new EventHandler<a8f>(this.a));
				}
			}
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00018AC0 File Offset: 0x00016CC0
	private void b(bool A_0)
	{
		this.a(null, A_0);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00018ACC File Offset: 0x00016CCC
	private void a(bool A_0)
	{
		if (this.c != null && this.c.Count > 0)
		{
			foreach (p2 p in this.c)
			{
				p.d();
				if (A_0 && this.j != null)
				{
					this.j.b(p.f(), new EventHandler<a8f>(this.a));
				}
			}
			this.c.Clear();
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00018B80 File Offset: 0x00016D80
	protected override void ac9()
	{
		this.b(true);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00018B8C File Offset: 0x00016D8C
	protected override void ada()
	{
		this.a(true);
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00018B98 File Offset: 0x00016D98
	protected override void adb()
	{
		List<p2> list = this.a(base.ai(), beb.g);
		this.c = list;
		this.k = beb.a;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00018BC4 File Offset: 0x00016DC4
	protected override void adc()
	{
		this.k = beb.g;
		this.e();
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00018BD8 File Offset: 0x00016DD8
	protected override void add()
	{
		if (this.l != null)
		{
			if (this.m != null)
			{
				this.a(this.m.d());
				this.m = null;
			}
			this.l.o1(this);
			base.a(FieldOfVisionState.Interupted);
			this.o = false;
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00018C30 File Offset: 0x00016E30
	private void a(beb A_0)
	{
		if (this.j == null)
		{
			return;
		}
		foreach (p2 p in this.c)
		{
			if ((A_0 & p.a()) == p.a())
			{
				this.j.b(p.f(), new EventHandler<a8f>(this.a));
			}
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00018CC4 File Offset: 0x00016EC4
	private void b(IEnumerable<p2> A_0)
	{
		if (this.j == null)
		{
			return;
		}
		foreach (p2 p in A_0)
		{
			this.j.a(p.f(), new EventHandler<a8f>(this.a));
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00018D3C File Offset: 0x00016F3C
	private void a(IEnumerable<p2> A_0)
	{
		if (this.j == null)
		{
			return;
		}
		foreach (p2 p in A_0)
		{
			this.j.b(p.f(), new EventHandler<a8f>(this.a));
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00018DB4 File Offset: 0x00016FB4
	private List<p2> a(Point A_0, beb A_1)
	{
		List<p2> list = new List<p2>();
		if ((A_1 & beb.f) == beb.f)
		{
			p2 p = new p2();
			p.a(true);
			p.a(A_0);
			p.a(1f);
			p.a(beb.f);
			this.a(p, new anl(A_0, 0f, null, this.n));
			list.Add(p);
		}
		for (int i = -1; i <= 1; i += 2)
		{
			for (int j = -1; j <= 1; j += 2)
			{
				beb beb = dlx.a(j, i);
				if ((A_1 & beb) == beb)
				{
					this.d.Clear();
					this.e.Clear();
					this.f.Clear();
					int num = 0;
					int num2 = 0;
					a1n a1n = new a1n();
					if (this.d() == a6h.b)
					{
						a1n.b = dlx.a(new Vector2((float)A_0.X + 0.5f - 0.5f * (float)j, (float)A_0.Y + 0.5f + 0.5f * (float)i), new Vector2((float)A_0.X + (base.ag().b() + 5f) * (float)j, (float)(A_0.Y - i)));
						a1n.a = dlx.a(new Vector2((float)A_0.X + 0.5f + 0.5f * (float)j, (float)A_0.Y + 0.5f - 0.5f * (float)i), new Vector2((float)A_0.X + 0.5f - 0.5f * (float)j, (float)A_0.Y + (base.ag().b() + 5f) * (float)i));
					}
					else
					{
						a1n.b = dlx.a(new Vector2((float)A_0.X + 0.5f - 0.1f * (float)j, (float)A_0.Y + 0.5f + 0.1f * (float)i), new Vector2((float)A_0.X + (base.ag().b() + 5f) * (float)j, (float)(A_0.Y - i)));
						a1n.a = dlx.a(new Vector2((float)A_0.X + 0.5f + 0.1f * (float)j, (float)A_0.Y + 0.5f - 0.1f * (float)i), new Vector2((float)A_0.X + 0.5f - 0.5f * (float)j, (float)A_0.Y + (base.ag().b() + 5f) * (float)i));
					}
					this.d.Add(a1n);
					for (;;)
					{
						num += j;
						if ((float)Math.Abs(num) > Math.Abs(base.ag().b()))
						{
							num -= j;
							num2 += i;
							if ((float)Math.Abs(num2) > Math.Abs(base.ag().b()))
							{
								break;
							}
						}
						int num3 = 0;
						while ((float)num3 <= base.ag().b())
						{
							int num4 = num - num3 * j;
							int num5 = num2 + num3 * i;
							int num6 = A_0.X + num4;
							int num7 = A_0.Y + num5;
							if (Math.Sign(num6 - A_0.X) != -j)
							{
								int num8 = num6 - A_0.X;
								int num9 = num7 - A_0.Y;
								float num10 = Convert.ToSingle(Math.Sqrt(Math.Pow((double)num8, 2.0) + Math.Pow((double)num9, 2.0)));
								if (Convert.ToInt32(num10) <= (int)base.ag().b())
								{
									Point a_ = new Point(num6, num7);
									p2 p2 = this.a(a_, num10, num8, num9, j, i);
									if (p2 != null && p2.b() && dlx.a(num4, num5, j, i))
									{
										p2.a(beb);
										list.Add(p2);
									}
								}
							}
							num3++;
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x000191B4 File Offset: 0x000173B4
	private static bool a(int A_0, int A_1, int A_2, int A_3)
	{
		if (A_2 * A_3 == 1)
		{
			if (A_1 == 0)
			{
				return false;
			}
		}
		else if (A_0 == 0)
		{
			return false;
		}
		return true;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x000191D4 File Offset: 0x000173D4
	private static beb a(Point A_0, Point A_1)
	{
		if (A_0 == A_1)
		{
			return beb.g;
		}
		beb beb = beb.a;
		if (A_0.X >= A_1.X && A_0.Y <= A_1.Y)
		{
			beb |= beb.b;
		}
		if (A_0.X <= A_1.X && A_0.Y <= A_1.Y)
		{
			beb |= beb.c;
		}
		if (A_0.X <= A_1.X && A_0.Y >= A_1.Y)
		{
			beb |= beb.d;
		}
		if (A_0.X >= A_1.X && A_0.Y >= A_1.Y)
		{
			beb |= beb.e;
		}
		return beb;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0001928C File Offset: 0x0001748C
	private static beb a(int A_0, int A_1)
	{
		if (A_0 == 1 && A_1 == -1)
		{
			return beb.b;
		}
		if (A_0 == -1 && A_1 == -1)
		{
			return beb.c;
		}
		if (A_0 == -1 && A_1 == 1)
		{
			return beb.d;
		}
		if (A_0 == 1 && A_1 == 1)
		{
			return beb.e;
		}
		return beb.a;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x000192DC File Offset: 0x000174DC
	private p2 a(Point A_0, float A_1, int A_2, int A_3, int A_4, int A_5)
	{
		p2 p = new p2();
		p.a(1f);
		anl anl = new anl();
		anl.a(new ut());
		anl.a(A_1);
		anl.a(A_0);
		bool flag = false;
		bool flag2 = true;
		using (List<ok>.Enumerator enumerator = base.ag().a().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.g5(anl))
				{
					flag2 = false;
					break;
				}
			}
		}
		int i = 0;
		while (i < this.d.Count)
		{
			a1n a1n = this.d[i];
			bool flag3 = dlx.a(a1n.a, A_0);
			bool flag4 = dlx.a(a1n.b, A_0);
			bool flag5 = this.b(a1n.a, A_0, A_4, A_5);
			bool flag6 = this.a(a1n.b, A_0, A_4, A_5);
			bool flag7 = !dlx.a(A_0, a1n.a, A_4, A_5);
			bool flag8 = !dlx.b(A_0, a1n.b, A_4, A_5);
			if (flag3 && flag4)
			{
				flag = true;
				if (!flag2)
				{
					this.d.Remove(a1n);
					break;
				}
				break;
			}
			else if (flag3)
			{
				flag = true;
				if (!flag2)
				{
					a1n.a = this.a(new Vector2(a1n.a.Position.X, a1n.a.Position.Y), A_0, true, A_4, A_5);
				}
				if (!flag5 && flag2 && A_2 != 0 && A_3 != 0)
				{
					p.a(0.5f);
					break;
				}
				break;
			}
			else if (flag4)
			{
				flag = true;
				if (!flag2)
				{
					a1n.b = this.b(new Vector2(a1n.b.Position.X, a1n.b.Position.Y), A_0, true, A_4, A_5);
				}
				if (!flag6 && flag2 && A_2 != 0 && A_3 != 0)
				{
					p.a(0.5f);
					break;
				}
				break;
			}
			else if (flag7 && flag8)
			{
				flag = true;
				if (!flag2)
				{
					a1n a1n2 = new a1n();
					a1n2.a = a1n.a;
					a1n2.b = this.b(new Vector2(a1n.b.Position.X, a1n.b.Position.Y), A_0, true, A_4, A_5);
					a1n a1n3 = new a1n();
					a1n3.a = this.a(new Vector2(a1n.a.Position.X, a1n.a.Position.Y), A_0, true, A_4, A_5);
					a1n3.b = a1n.b;
					this.d.Add(a1n2);
					this.d.Add(a1n3);
					this.d.Remove(a1n);
					break;
				}
				break;
			}
			else
			{
				i++;
			}
		}
		if ((int)A_1 <= 1 && (!base.ag().d() || flag2))
		{
			flag = true;
		}
		p.a(A_0);
		p.a(flag);
		if (flag)
		{
			this.a(p, anl);
		}
		return p;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0001963C File Offset: 0x0001783C
	private void a(p2 A_0, anl A_1)
	{
		foreach (aue aue in base.ag().c())
		{
			if (aue.q8(A_1))
			{
				object a_ = aue.rc(A_1);
				A_0.g().Add(new ig(aue, a_));
			}
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x000196BC File Offset: 0x000178BC
	private bool b(Ray A_0, Point A_1, int A_2, int A_3)
	{
		BoundingBox boundingBox = default(BoundingBox);
		if (A_2 == 1 && A_3 == -1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X, (float)A_1.Y, 0f), new Vector3((float)A_1.X + this.h, (float)A_1.Y + this.h, 1f));
		}
		if (A_2 == -1 && A_3 == -1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X + this.i, (float)A_1.Y, 0f), new Vector3((float)(A_1.X + 1), (float)A_1.Y + this.h, 1f));
		}
		if (A_2 == 1 && A_3 == 1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X, (float)A_1.Y + this.i, 0f), new Vector3((float)A_1.X + this.h, (float)(A_1.Y + 1), 1f));
		}
		if (A_2 == -1 && A_3 == 1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X + this.i, (float)A_1.Y + this.i, 0f), new Vector3((float)(A_1.X + 1), (float)(A_1.Y + 1), 1f));
		}
		return boundingBox.Intersects(A_0) != null;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0001983C File Offset: 0x00017A3C
	private bool a(Ray A_0, Point A_1, int A_2, int A_3)
	{
		BoundingBox boundingBox = default(BoundingBox);
		if (A_2 == 1 && A_3 == -1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X + this.i, (float)A_1.Y + this.i, 0f), new Vector3((float)(A_1.X + 1), (float)(A_1.Y + 1), 1f));
		}
		if (A_2 == -1 && A_3 == -1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X, (float)A_1.Y + this.i, 0f), new Vector3((float)A_1.X + this.h, (float)(A_1.Y + 1), 1f));
		}
		if (A_2 == 1 && A_3 == 1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X + this.i, (float)A_1.Y, 0f), new Vector3((float)(A_1.X + 1), (float)A_1.Y + this.h, 1f));
		}
		if (A_2 == -1 && A_3 == 1)
		{
			boundingBox = new BoundingBox(new Vector3((float)A_1.X, (float)A_1.Y, 0f), new Vector3((float)A_1.X + this.h, (float)A_1.Y + this.h, 1f));
		}
		return boundingBox.Intersects(A_0) != null;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000199BC File Offset: 0x00017BBC
	private static bool a(Ray A_0, Point A_1)
	{
		BoundingBox boundingBox = new BoundingBox(new Vector3((float)A_1.X + 0.05f, (float)A_1.Y + 0.01f, 0f), new Vector3((float)A_1.X + 0.95f, (float)A_1.Y + 0.99f, 1f));
		BoundingBox boundingBox2 = new BoundingBox(new Vector3((float)A_1.X + 0.01f, (float)A_1.Y + 0.05f, 0f), new Vector3((float)A_1.X + 0.99f, (float)A_1.Y + 0.95f, 1f));
		return boundingBox.Intersects(A_0) != null || boundingBox2.Intersects(A_0) != null;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00019A90 File Offset: 0x00017C90
	private Ray b(Vector2 A_0, Point A_1, bool A_2, int A_3, int A_4)
	{
		Ray ray = dlx.a(A_0, new Vector2((float)A_1.X + (0.5f - 0.51f * (float)A_3), (float)A_1.Y + (0.5f + (0.5f + ((A_0.Y == (float)A_1.Y + 0.5f + 0.5f * (float)A_4) ? 0.01f : 0f)) * (float)A_4)));
		if (A_2)
		{
			foreach (Point point in this.e)
			{
				if (dlx.a(ray, point))
				{
					ray = dlx.a(new Vector2((float)point.X + 0.5f + 0.5f * (float)A_3, (float)point.Y + 0.5f - 0.5f * (float)A_4), new Vector2((float)A_1.X + (0.5f - 0.51f * (float)A_3), (float)A_1.Y + (0.5f + (0.5f + (((float)point.Y == (float)A_1.Y + 0.5f + 0.5f * (float)A_4) ? 0.01f : 0f)) * (float)A_4)));
				}
			}
		}
		this.f.Add(A_1);
		return ray;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00019C10 File Offset: 0x00017E10
	private Ray a(Vector2 A_0, Point A_1, bool A_2, int A_3, int A_4)
	{
		Ray ray = dlx.a(A_0, new Vector2((float)A_1.X + 0.5f + (0.5f + ((A_0.X == (float)A_1.X + 0.5f + 0.5f * (float)A_3) ? 0.01f : 0f)) * (float)A_3, (float)A_1.Y + 0.5f - 0.51f * (float)A_4));
		if (A_2)
		{
			foreach (Point point in this.f)
			{
				if (dlx.a(ray, point))
				{
					ray = dlx.a(new Vector2((float)point.X + 0.5f - 0.5f * (float)A_3, (float)point.Y + 0.5f - 0.5f * (float)A_4), new Vector2((float)A_1.X + 0.5f + (0.5f + (((float)point.X == (float)A_1.X + 0.5f + 0.5f * (float)A_3) ? 0.01f : 0f)) * (float)A_3, (float)A_1.Y + 0.5f - 0.51f * (float)A_4));
				}
			}
		}
		this.e.Add(A_1);
		return ray;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00019D90 File Offset: 0x00017F90
	private static bool b(Point A_0, Ray A_1, int A_2, int A_3)
	{
		Ray ray = dlx.a(A_1.Position.b(), new Vector2((float)A_0.X + 0.5f - 0.45f * (float)A_2, (float)A_0.Y + 0.5f + 0.5f * (float)A_3));
		if (Math.Atan2((double)(ray.Direction.Y - A_1.Direction.Y), (double)(ray.Direction.X - A_1.Direction.X)) * (double)(-(double)A_3) >= 0.0)
		{
			return true;
		}
		Ray ray2 = dlx.a(A_1.Position.b(), new Vector2((float)A_0.X + 0.5f - 0.5f * (float)A_2, (float)A_0.Y + 0.5f + 0.45f * (float)A_3));
		return Math.Atan2((double)(ray2.Direction.Y - A_1.Direction.Y), (double)(ray2.Direction.X - A_1.Direction.X)) * (double)(-(double)A_3) >= 0.0;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00019EB4 File Offset: 0x000180B4
	private static bool a(Point A_0, Ray A_1, int A_2, int A_3)
	{
		Ray ray = dlx.a(A_1.Position.b(), new Vector2((float)A_0.X + 0.5f + 0.5f * (float)A_2, (float)A_0.Y + 0.5f - 0.45f * (float)A_3));
		if (Math.Atan2((double)(ray.Direction.Y - A_1.Direction.Y), (double)(ray.Direction.X - A_1.Direction.X)) * (double)(-(double)A_3) <= 0.0)
		{
			return true;
		}
		Ray ray2 = dlx.a(A_1.Position.b(), new Vector2((float)A_0.X + 0.5f + 0.45f * (float)A_2, (float)A_0.Y + 0.5f - 0.5f * (float)A_3));
		return Math.Atan2((double)(ray2.Direction.Y - A_1.Direction.Y), (double)(ray2.Direction.X - A_1.Direction.X)) * (double)(-(double)A_3) <= 0.0;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00019FD8 File Offset: 0x000181D8
	public static Ray a(Vector2 A_0, Vector2 A_1)
	{
		Vector2 value = A_1 - A_0;
		Vector3 direction = new Vector3(value, 0f);
		direction.Normalize();
		return new Ray(new Vector3(A_0, 0.5f), direction);
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0001A014 File Offset: 0x00018214
	private void a(object A_0, a8f A_1)
	{
		if (base.ah() != FieldOfVisionState.Destroying)
		{
			if (this.ac8())
			{
				beb beb = dlx.a(A_1.a(), base.ai());
				this.k |= beb;
				if (base.ah() != FieldOfVisionState.MarkedForUpdate)
				{
					this.e();
					return;
				}
			}
			else
			{
				base.ak();
			}
		}
	}

	// Token: 0x040004AC RID: 1196
	public const float a = 0.5f;

	// Token: 0x040004AD RID: 1197
	private static readonly List<beb> b = new List<beb>
	{
		beb.f,
		beb.b,
		beb.c,
		beb.d,
		beb.e
	};

	// Token: 0x040004AE RID: 1198
	private List<p2> c = new List<p2>();

	// Token: 0x040004AF RID: 1199
	private List<a1n> d = new List<a1n>();

	// Token: 0x040004B0 RID: 1200
	private List<Point> e = new List<Point>();

	// Token: 0x040004B1 RID: 1201
	private List<Point> f = new List<Point>();

	// Token: 0x040004B2 RID: 1202
	private new a6h g;

	// Token: 0x040004B3 RID: 1203
	private new float h = 0.5f;

	// Token: 0x040004B4 RID: 1204
	private float i;

	// Token: 0x040004B5 RID: 1205
	private IEventSubscriber<a8f> j;

	// Token: 0x040004B6 RID: 1206
	private beb k;

	// Token: 0x040004B7 RID: 1207
	private v8 l;

	// Token: 0x040004B8 RID: 1208
	private ebo m;

	// Token: 0x040004B9 RID: 1209
	private bde n;

	// Token: 0x040004BA RID: 1210
	private bool o;
}
