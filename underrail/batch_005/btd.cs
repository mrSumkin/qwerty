using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x020005A2 RID: 1442
public sealed class btd : abz
{
	// Token: 0x06002645 RID: 9797 RVA: 0x000D86E4 File Offset: 0x000D68E4
	public ax4 abk()
	{
		return this.c;
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x000D86F0 File Offset: 0x000D68F0
	public void a(bad A_0, d4n A_1)
	{
		if (A_1 != null && A_1.b != null && A_1.b.aa() is e3q && !A_1.b.aa().Dead && A_1.b.a8() != null && A_1.b.a8().j == cgy.b)
		{
			if (this.g != A_1.c || this.h != A_1.d || A_1.b.ao() != this.i)
			{
				this.i = A_1.b.ao();
				this.abl();
			}
			this.g = A_1.c;
			this.h = A_1.d;
			e86 e = A_0 as e86;
			if (e != null)
			{
				bsc bsc = e.ei();
				if (bsc != null)
				{
					b1l b1l = new b1l(bsc.e, bsc.d);
					ax4 ax;
					this.d.TryGetValue(b1l, out ax);
					this.c = ax;
					if (this.c == null)
					{
						if (!object.Equals(this.e, b1l))
						{
							this.e = b1l;
							this.f = bsc;
							this.a(bsc, A_1);
							return;
						}
					}
					else
					{
						this.e = null;
						this.f = null;
					}
					return;
				}
			}
		}
		this.e = null;
		this.c = null;
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x000D885C File Offset: 0x000D6A5C
	public void abl()
	{
		this.d.Clear();
		this.e = null;
		this.c = null;
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x000D8878 File Offset: 0x000D6A78
	private void a(bsc A_0, d4n A_1)
	{
		c5x c5x = A_1.b.a8();
		if (c5x == null || c5x.k.b == null)
		{
			return;
		}
		if (this.a != null && this.a.aun() != dv8.d && this.a.aun() != dv8.e)
		{
			this.a.au3();
			this.a.auy(new EventHandler<EventArgs>(this.a));
			this.a.au0(new EventHandler<EventArgs>(this.a));
		}
		if (this.b != null)
		{
			this.b.gi();
		}
		if (A_0.a != null)
		{
			this.b = A_0.a;
			this.b.gh(new Action<czp>(this.a));
			return;
		}
		this.a(null);
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x000D895C File Offset: 0x000D6B5C
	private void a(czp A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && A_0 != null)
			{
				wu serviceOrThrow2 = bpo.GetServiceOrThrow<wu>();
				this.a = serviceOrThrow2.aki(A_0, c5x.Playfield.PathProcessor, eso.d);
				this.a.auw(new EventHandler<EventArgs>(this.a));
				this.a.auz(new EventHandler<EventArgs>(this.a));
				this.a.au2();
				return;
			}
		}
		this.a(null);
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x000D8A10 File Offset: 0x000D6C10
	private void a(object A_0, EventArgs A_1)
	{
		c5w c5w = A_0 as c5w;
		List<yz> a_;
		if (c5w.aun() == dv8.d)
		{
			a_ = c5w.aus();
		}
		else
		{
			a_ = new List<yz>();
		}
		this.a(a_);
		this.a = null;
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x000D8A50 File Offset: 0x000D6C50
	private void a(List<yz> A_0)
	{
		if (this.e != null && this.f != null)
		{
			d02 service = bpo.GetService<d02>();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			float num = 0f;
			float num2 = 0f;
			double num3 = 0.0;
			float num4 = 0.4f;
			int num5 = 0;
			HashSet<r0> hashSet = new HashSet<r0>();
			if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null || serviceOrThrow.aqu().v().b() == null || service == null || !service.ahg())
			{
				return;
			}
			d4n d4n = service.ahu(serviceOrThrow.aqu().v());
			if (d4n != null)
			{
				if (A_0 != null && A_0.Count > 0)
				{
					HashSet<r0> hashSet2 = new HashSet<r0>();
					for (int i = 0; i < A_0.Count; i++)
					{
						e28 e = A_0[i] as e28;
						if (e != null)
						{
							Point point = e.a.a.a();
							r0 r = new r0(e.a.b, new Vector2((float)(point.X / 4), (float)(point.Y / 4)));
							if (!hashSet2.Contains(r))
							{
								aud aud = serviceOrThrow.aqu().v().b().Zone.b(r.b);
								if (aud != null)
								{
									ak1 ak = aud.a(r.a.a());
									if (ak != null)
									{
										c5x c5x = Enumerable.FirstOrDefault<c5x>(Enumerable.Where<c5x>(Enumerable.OfType<c5x>(ak.c.Values), new Func<c5x, bool>(btd.a.a.a)));
										if (c5x != null)
										{
											hashSet.Add(r);
											num5++;
											cnb cnb = c5x.s.b as cnb;
											if (cnb.b() != null)
											{
												c5x c5x2 = new ar7(cnb.b().Value, aud).ao() as c5x;
												if (c5x2 != null)
												{
													r0 r2 = new r0(r.b, new Vector2(c5x2.Location.X, c5x2.Location.Y));
													hashSet2.Add(r2);
												}
											}
										}
									}
								}
								hashSet2.Add(r);
							}
						}
					}
				}
				num = (float)d4n.d * num4;
				num3 = d4n.c;
				num2 = (float)(d4n.d + Math.Max(0.0, d4n.c - (double)(num5 * d0u.a()[d98.c]))) * num4;
			}
			ax4 ax = new ax4();
			float num6 = 0f;
			a5j? a5j = new a5j?(this.a(0.0001f, num, num2));
			Vector2 vector = serviceOrThrow.aqu().v().b().Location.b() * 4f;
			HashSet<r0> hashSet3 = new HashSet<r0>();
			bool flag = true;
			Point point2;
			Point point3;
			serviceOrThrow.aqu().v().b().b(out point2, out point3);
			if (A_0 != null && A_0.Count > 0 && (A_0.Count != 1 || !(point2 == A_0[0].a.a.a())))
			{
				ax.a = new List<eos>();
				for (int j = 0; j < A_0.Count; j++)
				{
					yz yz = A_0[j];
					e28 e2 = yz as e28;
					if (e2 != null)
					{
						Point point4 = e2.a.a.a();
						r0 r3 = new r0(e2.a.b, new Vector2((float)(point4.X / 4), (float)(point4.Y / 4)));
						if (hashSet.Contains(r3) && !hashSet3.Contains(r3))
						{
							hashSet3.Add(r3);
							num3 -= (double)d0u.a()[d98.c];
							serviceOrThrow.aqu().v().b().Zone.b(r3.b);
							if (num3 < 0.0)
							{
								flag = false;
								a5j = new a5j?(a5j.c);
							}
						}
					}
					else
					{
						float num7 = (yz.a.a - vector).Length();
						a5j a5j2;
						if (flag)
						{
							a5j2 = this.a(num6 + num7, num, num2);
						}
						else
						{
							a5j2 = a5j.c;
						}
						if (a5j == null)
						{
							eos eos = new eos(yz.a.a);
							eos.b = a5j2;
							ax.a.Add(eos);
						}
						else if (a5j2 == a5j.Value)
						{
							eos eos2 = new eos(yz.a.a);
							eos2.b = a5j2;
							ax.a.Add(eos2);
						}
						else
						{
							List<eos> collection = this.a(yz.a.a, vector, num, num2, num6, num7, a5j.Value, a5j2);
							ax.a.AddRange(collection);
						}
						a5j = new a5j?(a5j2);
						num6 += num7;
						vector = yz.a.a;
						aud aud2 = serviceOrThrow.aqu().v().b().Zone.b(yz.a.b);
						if (aud2 != null)
						{
							ak1 ak2 = aud2.b((int)yz.a.a.X / 4, (int)yz.a.a.Y / 4);
							if (ak2 != null && !ak2.a(serviceOrThrow.aqu().v().a().d))
							{
								break;
							}
						}
					}
				}
			}
			ax.c = (int)Math.Ceiling((double)(num6 / num4));
			ax.b = this.f.b + num5 * d0u.a()[d98.c];
			this.d[this.e] = ax;
		}
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x000D908C File Offset: 0x000D728C
	private List<eos> a(Vector2 A_0, Vector2 A_1, float A_2, float A_3, float A_4, float A_5, a5j A_6, a5j A_7)
	{
		List<eos> list = new List<eos>();
		Vector2 value = A_0 - A_1;
		Vector2 value2 = A_1;
		float num = 0f;
		for (a5j a5j = A_6; a5j < A_7; a5j++)
		{
			num = (this.a(a5j, A_2, A_3) - A_4) / A_5 - num;
			Vector2 vector = value2 + value * num;
			list.Add(new eos(vector, a5j));
			value2 = vector;
		}
		list.Add(new eos(A_0, A_7));
		return list;
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x000D9108 File Offset: 0x000D7308
	private float a(a5j A_0, float A_1, float A_2)
	{
		if (A_0 == a5j.a)
		{
			return A_1;
		}
		if (A_0 == a5j.b)
		{
			return A_2;
		}
		return float.MaxValue;
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x000D9120 File Offset: 0x000D7320
	private a5j a(float A_0, float A_1, float A_2)
	{
		if (A_0 > A_2)
		{
			return a5j.c;
		}
		if (A_0 > A_1)
		{
			return a5j.b;
		}
		return a5j.a;
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x000D9138 File Offset: 0x000D7338
	private static int a(List<float> A_0, float A_1)
	{
		int num = 0;
		foreach (float num2 in A_0)
		{
			if (A_1 < num2)
			{
				break;
			}
			num++;
		}
		return num;
	}

	// Token: 0x040015C6 RID: 5574
	private c5w a;

	// Token: 0x040015C7 RID: 5575
	private ds3 b;

	// Token: 0x040015C8 RID: 5576
	private ax4 c;

	// Token: 0x040015C9 RID: 5577
	private Dictionary<b1l, ax4> d = new Dictionary<b1l, ax4>();

	// Token: 0x040015CA RID: 5578
	private b1l e;

	// Token: 0x040015CB RID: 5579
	private bsc f;

	// Token: 0x040015CC RID: 5580
	private double g;

	// Token: 0x040015CD RID: 5581
	private double h;

	// Token: 0x040015CE RID: 5582
	private Guid i;

	// Token: 0x020005A4 RID: 1444
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x000D91C0 File Offset: 0x000D73C0
		internal bool a(c5x A_0)
		{
			return A_0.s.b is cnb;
		}

		// Token: 0x040015CF RID: 5583
		public static readonly btd.a a = new btd.a();

		// Token: 0x040015D0 RID: 5584
		public static Func<c5x, bool> b;
	}
}
