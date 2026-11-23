using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x02001359 RID: 4953
[eiz("TTCSA")]
[Serializable]
public sealed class e1i : em1, cdf, ISerializable
{
	// Token: 0x0600703F RID: 28735 RVA: 0x002F2464 File Offset: 0x002F0664
	private e1i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TTCSA:ETR", typeof(ar7)) as ar7);
		this.b = (A_0.GetValue("TTCSA:TTR", typeof(edx)) as edx);
		this.c = A_0.GetSingle("TTCSA:R");
		this.d = (e6z)A_0.GetValue("TTCSA:DAR", typeof(e6z));
		this.e = A_0.GetInt32("TTCSA:DAI");
		this.i = (HashSet<Point>)A_0.GetValue("TTCSA:TL", typeof(HashSet<Point>));
		di7.ReadList<byte>("TTCSA:AO", ref this.j, A_0);
		this.j = A_0.GetInt32("TTCSA:CA");
		if (ell.a() >= 455)
		{
			di7.ReadList<Point>("TTCSA:DNS", ref this.f, A_0);
		}
		else
		{
			Point item = (Point)A_0.GetValue("TTCSA:DN", typeof(Point));
			this.f = new List<Point>();
			this.f.Add(item);
		}
		this.g = A_0.GetInt32("TTCSA:IF");
		this.h = (A_0.GetValue("TTCSA:IN", typeof(HashSet<Point>)) as HashSet<Point>);
	}

	// Token: 0x06007040 RID: 28736 RVA: 0x002F25D0 File Offset: 0x002F07D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TTCSA:ETR", this.a);
		info.AddValue("TTCSA:TTR", this.b);
		info.AddValue("TTCSA:R", this.c);
		info.AddValue("TTCSA:DAR", this.d);
		info.AddValue("TTCSA:DAI", this.e);
		di7.WriteList<Point>("TTCSA:DNS", this.f, info);
		info.AddValue("TTCSA:TL", this.i);
		di7.WriteList<byte>("TTCSA:AO", this.j, info);
		info.AddValue("TTCSA:CA", this.j);
		info.AddValue("TTCSA:IF", this.g);
		info.AddValue("TTCSA:IN", this.h);
	}

	// Token: 0x06007041 RID: 28737 RVA: 0x002F26A0 File Offset: 0x002F08A0
	private b0b d()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06007042 RID: 28738 RVA: 0x002F26BC File Offset: 0x002F08BC
	private ak1 c()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x06007043 RID: 28739 RVA: 0x002F26D8 File Offset: 0x002F08D8
	private aud b()
	{
		return this.d.ao();
	}

	// Token: 0x06007044 RID: 28740 RVA: 0x002F26E8 File Offset: 0x002F08E8
	public sealed override object fm()
	{
		if (this.c() != null)
		{
			return this.c();
		}
		return this.d();
	}

	// Token: 0x06007045 RID: 28741 RVA: 0x002F2704 File Offset: 0x002F0904
	public List<byte> e()
	{
		return this.j;
	}

	// Token: 0x06007046 RID: 28742 RVA: 0x002F270C File Offset: 0x002F090C
	public void a(List<byte> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06007047 RID: 28743 RVA: 0x002F2718 File Offset: 0x002F0918
	public e1i(ale A_0, object A_1, float A_2) : base(A_0)
	{
		b0b b0b = A_1 as b0b;
		ak1 ak = A_1 as ak1;
		if (b0b == null && ak == null)
		{
			dux.a(LogSeverity.Error, rz.p, new object[]
			{
				(A_1 != null) ? A_1.ToString() : null
			});
		}
		this.c = A_2;
		if (ak != null)
		{
			this.b = new edx(ak);
			return;
		}
		this.a = new ar7(b0b);
	}

	// Token: 0x06007048 RID: 28744 RVA: 0x002F27A0 File Offset: 0x002F09A0
	public List<anp> a(Action<czp> A_0)
	{
		List<anp> list = new List<anp>();
		this.k = A_0;
		if (!this.a())
		{
			base.a(null);
			return null;
		}
		this.g = 0;
		this.h = null;
		foreach (Point a_ in this.f)
		{
			anp anp = aw1.b(a_, this.b(), this.c, bcj.a(this.j), 0L);
			anp.a(new EventHandler<EventArgs>(this.b));
			anp.k();
			list.Add(anp);
		}
		return list;
	}

	// Token: 0x06007049 RID: 28745 RVA: 0x002F2860 File Offset: 0x002F0A60
	protected override bool fn()
	{
		this.j = -1;
		base.t();
		return true;
	}

	// Token: 0x0600704A RID: 28746 RVA: 0x002F2870 File Offset: 0x002F0A70
	protected sealed override void fo()
	{
		if (!this.a())
		{
			base.a(null);
			return;
		}
		this.g = 0;
		this.h = null;
		foreach (Point a_ in this.f)
		{
			anp anp = aw1.b(a_, this.b(), this.c, bcj.a(this.j), 0L);
			anp.a(new EventHandler<EventArgs>(this.c));
			anp.k();
		}
	}

	// Token: 0x0600704B RID: 28747 RVA: 0x002F2918 File Offset: 0x002F0B18
	protected override void fq()
	{
		aw1.b(base.n().a8(), this.fm(), false);
	}

	// Token: 0x0600704C RID: 28748 RVA: 0x002F293C File Offset: 0x002F0B3C
	protected sealed override void fp()
	{
		if (!this.a())
		{
			base.c(false);
			return;
		}
		if (this.e != base.n().a8().Area.c())
		{
			base.c(false);
			return;
		}
		Point a_ = base.n().a8().aj().a();
		float num = float.MaxValue;
		foreach (Point a_2 in this.f)
		{
			float num2 = bnx.a(a_, a_2) - (base.n().a8().Size.X + base.n().a8().Size.Y) / 4f;
			if (num2 < num)
			{
				num = num2;
			}
		}
		if (!aw1.a(num, this.c))
		{
			base.c(false);
			return;
		}
		this.g = 0;
		this.h = null;
		foreach (Point a_3 in this.f)
		{
			anp anp = aw1.b(a_3, this.b(), this.c, bcj.a(this.j), 0L);
			anp.a(new EventHandler<EventArgs>(this.a));
			anp.k();
		}
	}

	// Token: 0x0600704D RID: 28749 RVA: 0x002F2AC8 File Offset: 0x002F0CC8
	private bool a()
	{
		if (this.f == null)
		{
			this.f = new List<Point>();
		}
		else
		{
			this.f.Clear();
		}
		if (this.c() != null)
		{
			this.d = new e6z(this.c().Area);
			if (this.c().Area != null)
			{
				this.e = this.c().Area.c();
			}
			this.f.Add(this.c().Location);
			return true;
		}
		if (this.d() == null)
		{
			return false;
		}
		if (this.d().j == cgy.a || this.d().Area == null || this.d().l.Count == 0)
		{
			return false;
		}
		this.d = new e6z(this.d().Area);
		if (this.d().Area != null)
		{
			this.e = this.d().Area.c();
		}
		if ((this.d().Size.X > 1f || this.d().Size.Y > 1f) && this.d().l.Count > 1)
		{
			using (List<ak1>.Enumerator enumerator = this.d().l.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ak1 ak = enumerator.Current;
					this.f.Add(ak.Location);
				}
				return true;
			}
		}
		this.f.Add(this.d().aj().a());
		return true;
	}

	// Token: 0x0600704E RID: 28750 RVA: 0x002F2C9C File Offset: 0x002F0E9C
	private czp a(HashSet<Point> A_0)
	{
		this.i = new HashSet<Point>();
		if (A_0 != null)
		{
			foreach (Point point in A_0)
			{
				this.i.Add(point);
			}
		}
		czp czp = new czp();
		czp.g = base.n();
		czp.j = this;
		czp.n.a = true;
		czp.n.c = 3f;
		czp.b = czr.b;
		czp.o = double.MaxValue;
		czp.f = true;
		em1.a(czp, base.n());
		czp.e = new ee4(this.b().c(), new Point(this.f[0].X * 4, this.f[0].Y * 4));
		return czp;
	}

	// Token: 0x0600704F RID: 28751 RVA: 0x002F2DA8 File Offset: 0x002F0FA8
	[dcc("TTCSA:mPFIF")]
	private void c(object A_0, EventArgs A_1)
	{
		if (base.x() != dc4.b)
		{
			return;
		}
		anp anp = A_0 as anp;
		this.g++;
		if (this.h == null)
		{
			this.h = new HashSet<Point>();
		}
		foreach (Point point in anp.f())
		{
			this.h.Add(point);
		}
		if (this.g == this.f.Count)
		{
			czp a_ = this.a(this.h);
			wu serviceOrThrow = bpo.GetServiceOrThrow<wu>();
			eso a_2 = base.n().a8().IsPlayer ? eso.e : eso.d;
			c5w a_3 = serviceOrThrow.aki(a_, base.n().a8().Playfield.PathProcessor, a_2);
			base.a(a_3);
		}
	}

	// Token: 0x06007050 RID: 28752 RVA: 0x002F2EB0 File Offset: 0x002F10B0
	[dcc("TTCSA:mPFIF2")]
	private void b(object A_0, EventArgs A_1)
	{
		if (this.k == null && base.x() != dc4.b)
		{
			return;
		}
		anp anp = A_0 as anp;
		this.g++;
		if (this.h == null)
		{
			this.h = new HashSet<Point>();
		}
		foreach (Point point in anp.f())
		{
			this.h.Add(point);
		}
		if (this.g == this.f.Count)
		{
			czp obj = this.a(this.h);
			if (this.k != null)
			{
				this.k(obj);
			}
		}
	}

	// Token: 0x06007051 RID: 28753 RVA: 0x002F2F8C File Offset: 0x002F118C
	[dcc("TTCSA:mPVIF")]
	private void a(object A_0, EventArgs A_1)
	{
		if (base.x() != dc4.b)
		{
			return;
		}
		anp anp = A_0 as anp;
		this.g++;
		if (this.h == null)
		{
			this.h = new HashSet<Point>();
		}
		foreach (Point point in anp.f())
		{
			this.h.Add(point);
		}
		if (this.g == this.f.Count)
		{
			Point point2 = base.n().a8().aj().a();
			bool a_ = this.h.Contains(point2);
			base.c(a_);
		}
	}

	// Token: 0x06007052 RID: 28754 RVA: 0x002F3064 File Offset: 0x002F1264
	public bool fs(ee4 A_0, int A_1, cr6 A_2)
	{
		return A_0.b == this.e && ar1.a(A_0.a, this.i, null);
	}

	// Token: 0x04002DE4 RID: 11748
	private new ar7 a;

	// Token: 0x04002DE5 RID: 11749
	private edx b;

	// Token: 0x04002DE6 RID: 11750
	private new float c;

	// Token: 0x04002DE7 RID: 11751
	private e6z d;

	// Token: 0x04002DE8 RID: 11752
	private int e;

	// Token: 0x04002DE9 RID: 11753
	private List<Point> f;

	// Token: 0x04002DEA RID: 11754
	private int g;

	// Token: 0x04002DEB RID: 11755
	private new HashSet<Point> h;

	// Token: 0x04002DEC RID: 11756
	private HashSet<Point> i;

	// Token: 0x04002DED RID: 11757
	private new List<byte> j = new List<byte>();

	// Token: 0x04002DEE RID: 11758
	[NonSerialized]
	private new Action<czp> k;
}
