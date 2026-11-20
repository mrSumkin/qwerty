using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001274 RID: 4724
[eiz("WSEA")]
[Serializable]
public sealed class a2r : Aspect<c5x>, ISerializable, chb, c98
{
	// Token: 0x06006687 RID: 26247 RVA: 0x002B95DC File Offset: 0x002B77DC
	private a2r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetSingle("WSEA:R");
		this.b = A_0.GetDouble("WSEA:C");
		this.d = A_0.GetBoolean("WSEA:E");
		this.e = (A_0.GetValue("WSEA:A", typeof(List<Point>)) as List<Point>);
		this.f = (Point)A_0.GetValue("WSEA:L", typeof(Point));
		this.g = A_0.GetString("WSEA:N");
		this.h = (float)A_0.GetInt32("WSEA:Z");
	}

	// Token: 0x06006688 RID: 26248 RVA: 0x002B9690 File Offset: 0x002B7890
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WSEA:R", this.c);
		info.AddValue("WSEA:C", this.b);
		info.AddValue("WSEA:E", this.d);
		info.AddValue("WSEA:A", this.e);
		info.AddValue("WSEA:L", this.f);
		info.AddValue("WSEA:N", this.g);
		info.AddValue("WSEA:Z", this.h);
	}

	// Token: 0x06006689 RID: 26249 RVA: 0x002B9724 File Offset: 0x002B7924
	public float g()
	{
		return this.c;
	}

	// Token: 0x0600668A RID: 26250 RVA: 0x002B972C File Offset: 0x002B792C
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600668B RID: 26251 RVA: 0x002B9738 File Offset: 0x002B7938
	public bool h()
	{
		return this.d;
	}

	// Token: 0x0600668C RID: 26252 RVA: 0x002B9740 File Offset: 0x002B7940
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600668D RID: 26253 RVA: 0x002B974C File Offset: 0x002B794C
	public a2r(c5x A_0) : this(A_0, 3)
	{
	}

	// Token: 0x0600668E RID: 26254 RVA: 0x002B9758 File Offset: 0x002B7958
	public a2r(c5x A_0, int A_1) : base(A_0)
	{
		this.b = 0.0;
		this.a((float)A_1);
		this.a();
	}

	// Token: 0x0600668F RID: 26255 RVA: 0x002B9788 File Offset: 0x002B7988
	public void r7(eds A_0)
	{
		this.f();
		if (this.d && !this.i)
		{
			ak1 ak = base.a8().Area.a(base.a8().aj().a());
			if (ak != null)
			{
				string text = this.d();
				this.a(ak, this.a(ak, text), text);
				bpv.a(ak, 1000.0);
			}
			if (!dz6.e())
			{
				if ((this.b -= A_0.b.TotalMilliseconds) <= 0.0)
				{
					this.b += (double)d0u.b;
					this.e();
					return;
				}
			}
			else
			{
				this.b = (double)d0u.b;
				this.a();
			}
		}
	}

	// Token: 0x06006690 RID: 26256 RVA: 0x002B9860 File Offset: 0x002B7A60
	private void f()
	{
		if (this.e == null || base.a8().aj().a() != this.f || base.a8().Area.y8() != this.g || this.h != this.c)
		{
			this.b();
		}
	}

	// Token: 0x06006691 RID: 26257 RVA: 0x002B98D0 File Offset: 0x002B7AD0
	public void c()
	{
		if (this.d && !this.i)
		{
			this.e();
		}
	}

	// Token: 0x06006692 RID: 26258 RVA: 0x002B98F4 File Offset: 0x002B7AF4
	private void e()
	{
		if (this.e != null)
		{
			string text = this.d();
			HashSet<c5x> hashSet = new HashSet<c5x>();
			foreach (Point point in this.e)
			{
				ak1 ak = base.a8().Area.a(point);
				if (ak != null)
				{
					c5x a_ = null;
					double num = d05.a(this.f, point);
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
					{
						c5x c5x = (c5x)b0b;
						if (!hashSet.Contains(c5x))
						{
							hashSet.Add(c5x);
							if (c5x.a(text))
							{
								a_ = c5x;
							}
							if (c5x.h.b != null)
							{
								if (!c5x.h.b.aa().Passive)
								{
									efk efk = c5x.h.b.aa();
									bool flag = efk.StatusEffects.a(a0s.i);
									bool flag2 = efk is e3q && !flag;
									efk.StatusEffects.a(new a0s(), false, false, !flag2);
								}
								this.DecreaseStacks<b31>(c5x.h.b.aa(), 10);
								this.DecreaseStacks<b34>(c5x.h.b.aa(), 3);
								this.DecreaseStacks<e6y>(c5x.h.b.aa(), 3);
								this.DecreaseDuration<a2>(c5x.h.b.aa(), 1);
							}
						}
					}
					if (num <= 1.9)
					{
						this.a(ak, a_, text);
					}
					double num2 = 1.2 - num / (double)this.g();
					bpv.a(ak, 2.0 * num2);
				}
			}
		}
	}

	// Token: 0x06006693 RID: 26259 RVA: 0x002B9B44 File Offset: 0x002B7D44
	private void DecreaseStacks<T>(efk target, int stacks) where T : els
	{
		T t = Enumerable.FirstOrDefault<T>(target.StatusEffects.Get<T>());
		if (t != null)
		{
			if (t.Stacks <= stacks)
			{
				target.StatusEffects.d(t);
				return;
			}
			ref T ptr = ref t;
			ptr.Stacks -= stacks;
		}
	}

	// Token: 0x06006694 RID: 26260 RVA: 0x002B9BB4 File Offset: 0x002B7DB4
	private void DecreaseDuration<T>(efk target, int turns) where T : els
	{
		T t = Enumerable.FirstOrDefault<T>(target.StatusEffects.Get<T>());
		if (t != null)
		{
			if (t.TimeLeft <= (double)(turns * d0u.b))
			{
				target.StatusEffects.d(t);
				return;
			}
			ref T ptr = ref t;
			ptr.TimeLeft -= (double)(turns * d0u.b);
		}
	}

	// Token: 0x06006695 RID: 26261 RVA: 0x002B9C30 File Offset: 0x002B7E30
	private string d()
	{
		return "WarmthSource_" + base.a8().qe().ToString() + "_Heat";
	}

	// Token: 0x06006696 RID: 26262 RVA: 0x002B9C68 File Offset: 0x002B7E68
	private c5x a(ak1 A_0, string A_1)
	{
		if (A_0 != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.c.Values))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.a(A_1))
				{
					return c5x;
				}
			}
		}
		return null;
	}

	// Token: 0x06006697 RID: 26263 RVA: 0x002B9CE8 File Offset: 0x002B7EE8
	private void a(ak1 A_0, c5x A_1, string A_2)
	{
		if (A_1 == null)
		{
			A_1 = new c5x();
			A_1.aa = true;
			A_1.Layer = aju.x;
			A_1.Size = new Vector3(1f, 1f, 1f);
			A_1.Location = A_0.Location.a();
			A_1.TileFormationModifiers.s3(25);
			A_1.b(A_2);
			cm aspect = new cm(A_1, 6000, false);
			A_1.SetAspect<cm>(aspect);
			base.a8().Area.a(A_1);
			return;
		}
		cm cm = A_1.GetAspect<cm>();
		if (cm == null)
		{
			cm = new cm(A_1, 6000, false);
			A_1.SetAspect<cm>(cm);
			return;
		}
		cm.a(6000);
	}

	// Token: 0x06006698 RID: 26264 RVA: 0x002B9DA8 File Offset: 0x002B7FA8
	private void b()
	{
		this.i = true;
		anp anp = new anp(base.a8().aj().a(), base.a8().Area, this.c, bcj.a(new long[]
		{
			4L
		}), false, 0L);
		anp.a(new EventHandler<EventArgs>(this.a));
		anp.k();
	}

	// Token: 0x06006699 RID: 26265 RVA: 0x002B9E0C File Offset: 0x002B800C
	private void a()
	{
		this.b += (double)cuo.a.Next(d0u.b / 5);
	}

	// Token: 0x0600669A RID: 26266 RVA: 0x002B9E30 File Offset: 0x002B8030
	[dcc("WSEA:mIF")]
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		this.e = new List<Point>();
		if (anp != null)
		{
			this.f = anp.h();
			if (anp.d() != null)
			{
				this.g = anp.d().y8();
			}
			else
			{
				this.g = base.a8().Area.y8();
			}
			if (anp.f() != null)
			{
				this.e = new List<Point>(anp.f());
			}
			else
			{
				this.e = null;
			}
			this.h = anp.l();
		}
		else
		{
			this.f = base.a8().aj().a();
			this.g = base.a8().Area.y8();
			this.h = this.c;
		}
		this.i = false;
	}

	// Token: 0x04002A8D RID: 10893
	private const int a = 3;

	// Token: 0x04002A8E RID: 10894
	private double b;

	// Token: 0x04002A8F RID: 10895
	private float c;

	// Token: 0x04002A90 RID: 10896
	private bool d = true;

	// Token: 0x04002A91 RID: 10897
	private List<Point> e;

	// Token: 0x04002A92 RID: 10898
	private Point f;

	// Token: 0x04002A93 RID: 10899
	private string g;

	// Token: 0x04002A94 RID: 10900
	private float h;

	// Token: 0x04002A95 RID: 10901
	[NonSerialized]
	private bool i;
}
