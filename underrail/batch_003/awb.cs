using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200143A RID: 5178
[eiz("CEA1")]
[Serializable]
public sealed class awb : b1z, ISerializable
{
	// Token: 0x0600744E RID: 29774 RVA: 0x00315464 File Offset: 0x00313664
	private awb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CEA1:ES", typeof(cci)) as cci);
		this.b = (edx)A_0.GetValue("CEA1:TR", typeof(edx));
		this.c = A_0.GetSingle("CEA1:R");
		this.d = A_0.GetSingle("CEA1:SLF");
		this.e = A_0.GetSingle("CEA1:ELF");
		this.f = A_0.GetSingle("CEA1:LFS");
		this.g = A_0.GetSingle("CEA1:LR");
		this.h = A_0.GetDouble("CEA1:LA");
		this.i = (w4)A_0.GetValue("CEA1:S", typeof(w4));
		di7.ReadList<List<Point>>("CEA1:AN", ref this.j, A_0);
		this.k = A_0.GetDouble("CEA1:NPD");
		this.l = A_0.GetDouble("CEA1:NC");
		this.m = A_0.GetInt32("CEA1:NP");
		this.n = (ar7)A_0.GetValue("CEA1:LHR", typeof(ar7));
		this.o = (ae8?)A_0.GetValue("CEA1:L", typeof(ae8?));
		this.q = A_0.GetString("CEA1:SFX");
		this.r = A_0.GetBoolean("CEA1:V");
		if (ell.a() >= 600)
		{
			this.s = A_0.GetBoolean("CEA1:SCB");
		}
		if (ell.a() >= 640)
		{
			this.t = A_0.GetBoolean("CEA1:LB");
		}
	}

	// Token: 0x0600744F RID: 29775 RVA: 0x00315644 File Offset: 0x00313844
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEA1:ES", this.a);
		info.AddValue("CEA1:TR", this.b);
		info.AddValue("CEA1:R", this.c);
		info.AddValue("CEA1:SLF", this.d);
		info.AddValue("CEA1:ELF", this.e);
		info.AddValue("CEA1:LFS", this.f);
		info.AddValue("CEA1:LR", this.g);
		info.AddValue("CEA1:LA", this.h);
		info.AddValue("CEA1:S", this.i);
		di7.WriteList<List<Point>>("CEA1:AN", this.j, info);
		info.AddValue("CEA1:NPD", this.k);
		info.AddValue("CEA1:NC", this.l);
		info.AddValue("CEA1:NP", this.m);
		info.AddValue("CEA1:LHR", this.n);
		info.AddValue("CEA1:L", this.o);
		info.AddValue("CEA1:SFX", this.q);
		info.AddValue("CEA1:V", this.r);
		info.AddValue("CEA1:SCB", this.s);
		info.AddValue("CEA1:LB", this.t);
	}

	// Token: 0x06007450 RID: 29776 RVA: 0x003157A8 File Offset: 0x003139A8
	public float l()
	{
		return this.d;
	}

	// Token: 0x06007451 RID: 29777 RVA: 0x003157B0 File Offset: 0x003139B0
	public void c(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007452 RID: 29778 RVA: 0x003157BC File Offset: 0x003139BC
	public float n()
	{
		return this.e;
	}

	// Token: 0x06007453 RID: 29779 RVA: 0x003157C4 File Offset: 0x003139C4
	public void b(float A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007454 RID: 29780 RVA: 0x003157D0 File Offset: 0x003139D0
	public float o()
	{
		return this.g;
	}

	// Token: 0x06007455 RID: 29781 RVA: 0x003157D8 File Offset: 0x003139D8
	public void a(float A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06007456 RID: 29782 RVA: 0x003157E4 File Offset: 0x003139E4
	public double m()
	{
		return this.h;
	}

	// Token: 0x06007457 RID: 29783 RVA: 0x003157EC File Offset: 0x003139EC
	public void c(double A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06007458 RID: 29784 RVA: 0x003157F8 File Offset: 0x003139F8
	private ah7 h()
	{
		if (this.n != null)
		{
			if (this.p == null)
			{
				bsf bsf = Enumerable.FirstOrDefault<ejt>(this.n.ao().RaysEmitters) as bsf;
				if (bsf != null)
				{
					this.p = bsf.Definition;
				}
			}
			return this.p;
		}
		return null;
	}

	// Token: 0x06007459 RID: 29785 RVA: 0x00315850 File Offset: 0x00313A50
	public double p()
	{
		return this.k;
	}

	// Token: 0x0600745A RID: 29786 RVA: 0x00315858 File Offset: 0x00313A58
	public void b(double A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600745B RID: 29787 RVA: 0x00315864 File Offset: 0x00313A64
	public string i()
	{
		return this.q;
	}

	// Token: 0x0600745C RID: 29788 RVA: 0x0031586C File Offset: 0x00313A6C
	public void a(string A_0)
	{
		this.q = A_0;
	}

	// Token: 0x0600745D RID: 29789 RVA: 0x00315878 File Offset: 0x00313A78
	public awb(ak1 A_0, cci A_1, ae8? A_2, float A_3, string A_4 = null, float? A_5 = null, bool A_6 = false)
	{
		this.b = new edx(A_0);
		this.a = A_1;
		this.o = A_2;
		this.c = A_3;
		this.g = ((A_5 != null) ? A_5.Value : (A_3 + 3f));
		this.d = 1f / (this.g / 2f);
		this.e = 1f / (this.g * 3f);
		this.q = A_4;
		this.t = A_6;
	}

	// Token: 0x0600745E RID: 29790 RVA: 0x00315934 File Offset: 0x00313B34
	public awb(ak1 A_0, cci A_1, blv A_2, float A_3, string A_4 = null) : this(A_0, A_1, null, A_3, A_4, null, false)
	{
		if (A_2 != null)
		{
			this.o = new ae8?(A_2.a.Light);
			this.d = A_2.b;
			this.e = A_2.c;
			this.g = A_2.d;
		}
	}

	// Token: 0x0600745F RID: 29791 RVA: 0x003159A0 File Offset: 0x00313BA0
	protected override dc4 dt()
	{
		this.i = w4.a;
		this.n = null;
		this.g();
		this.d();
		return dc4.b;
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x003159C0 File Offset: 0x00313BC0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b == null || this.b.ao() == null || this.b.ao().Area == null)
		{
			return dc4.e;
		}
		if (this.i == w4.a)
		{
			this.f();
		}
		else if (this.i == w4.c)
		{
			this.a(A_1.TotalMilliseconds);
		}
		else
		{
			if (this.i == w4.e)
			{
				return dc4.e;
			}
			if (this.i == w4.d)
			{
				return dc4.c;
			}
		}
		return dc4.b;
	}

	// Token: 0x06007461 RID: 29793 RVA: 0x00315A50 File Offset: 0x00313C50
	protected override void j4()
	{
		base.j4();
	}

	// Token: 0x06007462 RID: 29794 RVA: 0x00315A58 File Offset: 0x00313C58
	private void g()
	{
		if (!string.IsNullOrEmpty(this.q) && this.b.ao() != null && this.b.ao().Area != null)
		{
			c5x c5x = aur.a(this.b.ao().Area, new Vector3((float)this.b.ao().Location.X, (float)this.b.ao().Location.Y, 0f));
			c5x.c().a("explosion", this.q, 1f, c9z.a, false, false);
			c7 a_ = new c7(c5x, true, true, true, false);
			c5x.Zone.ActionManager.g9(a_, atp.a);
		}
	}

	// Token: 0x06007463 RID: 29795 RVA: 0x00315B20 File Offset: 0x00313D20
	private void f()
	{
		if (this.b.ao() == null || this.b.ao().Zone == null)
		{
			this.i = w4.e;
			return;
		}
		if (this.a == null)
		{
			this.j = new List<List<Point>>();
			this.e();
			return;
		}
		if (this.s && !aw1.e(this.b.ao()))
		{
			this.j = new List<List<Point>>();
			this.j.Add(new List<Point>());
			this.j[0].Add(this.b.ao().Location);
			this.e();
			return;
		}
		anp anp;
		if (this.t)
		{
			anp = aw1.b(new Point(this.b.ao().Location.X, this.b.ao().Location.Y), this.b.ao().Area, this.c, 0L, 0L);
		}
		else
		{
			anp = aw1.a(new Point(this.b.ao().Location.X, this.b.ao().Location.Y), this.b.ao().Area, this.c, 0L, 0L);
		}
		anp.c(false);
		if (this.r)
		{
			anp.a(8L);
		}
		anp.a(new EventHandler<EventArgs>(this.a));
		anp.k();
		this.i = w4.b;
	}

	// Token: 0x06007464 RID: 29796 RVA: 0x00315CC4 File Offset: 0x00313EC4
	[dcc("CEA1:mOFCC")]
	private void a(object A_0, EventArgs A_1)
	{
		this.j = new List<List<Point>>();
		int num = 0;
		while ((float)num <= this.c)
		{
			this.j.Add(new List<Point>());
			num++;
		}
		anp anp = A_0 as anp;
		if (this.b != null && this.b.ao() != null && anp != null && anp.f() != null)
		{
			foreach (Point point in anp.f())
			{
				int index = (int)bnx.a(this.b.ao().Location, point);
				this.j[index].Add(point);
			}
			this.e();
			return;
		}
		this.i = w4.e;
	}

	// Token: 0x06007465 RID: 29797 RVA: 0x00315DB4 File Offset: 0x00313FB4
	private void e()
	{
		this.m = 0;
		this.l = (double)dz6.b((int)this.k);
		this.c();
		this.i = w4.c;
	}

	// Token: 0x06007466 RID: 29798 RVA: 0x00315DE0 File Offset: 0x00313FE0
	private void d()
	{
		if (this.o != null)
		{
			ejt ejt = new ah7("explosionLantern", null)
			{
				Light = this.o.Value,
				LightFadeRate = this.d,
				Range = this.g
			}.g();
			c5x c5x = new c5x();
			c5x.Layer = aju.x;
			c5x.Location = new Vector3((float)this.b.ao().Location.X, (float)this.b.ao().Location.Y, 0f);
			this.b.ao().Area.a(c5x);
			ejt.be(c5x);
			this.n = new ar7(c5x);
		}
	}

	// Token: 0x06007467 RID: 29799 RVA: 0x00315EAC File Offset: 0x003140AC
	private void c()
	{
		if (this.h() != null)
		{
			this.f = (float)dz6.a((double)((this.e - this.d) / (float)(this.h + (double)this.j.Count * this.k)));
		}
	}

	// Token: 0x06007468 RID: 29800 RVA: 0x00315EFC File Offset: 0x003140FC
	private void b()
	{
		if (this.n != null && this.n.ao() != null)
		{
			this.n.ao().w();
			this.n.ao().an();
			this.n = null;
		}
	}

	// Token: 0x06007469 RID: 29801 RVA: 0x00315F4C File Offset: 0x0031414C
	private void a(double A_0)
	{
		if (this.h() != null)
		{
			if (this.h().LightFadeRate > this.e)
			{
				this.h().LightFadeRate += (float)(A_0 * (double)this.f);
				this.h().d();
			}
			else
			{
				this.b();
			}
		}
		if (this.m < this.j.Count && (this.l += A_0) >= (double)dz6.b((int)this.k))
		{
			this.a();
			this.l = 0.0;
			this.m++;
		}
		if (this.m >= this.j.Count && this.h() == null)
		{
			this.i = w4.d;
		}
	}

	// Token: 0x0600746A RID: 29802 RVA: 0x00316030 File Offset: 0x00314230
	private void a()
	{
		if (this.a != null)
		{
			dib dib = this.a as dib;
			if (dib != null && dib.avb() == null)
			{
				dib.avc(Enumerable.ToArray<Point>(Enumerable.SelectMany<List<Point>, Point>(this.j, new Func<List<Point>, IEnumerable<Point>>(awb.a.a.a))));
			}
			aud aud = this.b.ao().Area;
			foreach (Point point in this.j[this.m])
			{
				if (point.X >= 0 && point.Y >= 0 && point.X < aud.Size.c && point.Y < aud.Size.d)
				{
					this.a.cq(aud, point, (float)this.m);
				}
			}
		}
	}

	// Token: 0x04002F78 RID: 12152
	private new cci a;

	// Token: 0x04002F79 RID: 12153
	private edx b;

	// Token: 0x04002F7A RID: 12154
	private float c;

	// Token: 0x04002F7B RID: 12155
	private float d;

	// Token: 0x04002F7C RID: 12156
	private float e;

	// Token: 0x04002F7D RID: 12157
	private float f;

	// Token: 0x04002F7E RID: 12158
	private float g;

	// Token: 0x04002F7F RID: 12159
	private double h = 350.0;

	// Token: 0x04002F80 RID: 12160
	private w4 i;

	// Token: 0x04002F81 RID: 12161
	private new List<List<Point>> j;

	// Token: 0x04002F82 RID: 12162
	private new double k = 100.0;

	// Token: 0x04002F83 RID: 12163
	private double l;

	// Token: 0x04002F84 RID: 12164
	private int m;

	// Token: 0x04002F85 RID: 12165
	private new ar7 n;

	// Token: 0x04002F86 RID: 12166
	private ae8? o;

	// Token: 0x04002F87 RID: 12167
	[NonSerialized]
	private ah7 p;

	// Token: 0x04002F88 RID: 12168
	private string q;

	// Token: 0x04002F89 RID: 12169
	public bool r;

	// Token: 0x04002F8A RID: 12170
	public bool s;

	// Token: 0x04002F8B RID: 12171
	public bool t;

	// Token: 0x0200143B RID: 5179
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600746D RID: 29805 RVA: 0x0031616C File Offset: 0x0031436C
		internal IEnumerable<Point> a(List<Point> A_0)
		{
			return A_0;
		}

		// Token: 0x04002F8C RID: 12172
		public static readonly awb.a a = new awb.a();

		// Token: 0x04002F8D RID: 12173
		public static Func<List<Point>, IEnumerable<Point>> b;
	}
}
