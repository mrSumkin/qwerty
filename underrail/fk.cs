using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200135A RID: 4954
[eiz("TTMA")]
[Serializable]
public sealed class fk : em1, cdf, ISerializable
{
	// Token: 0x06007053 RID: 28755 RVA: 0x002F30A0 File Offset: 0x002F12A0
	private fk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TTMA:TER", typeof(ar7)) as ar7);
		this.b = (A_0.GetValue("TTMA:TTR", typeof(edx)) as edx);
		this.c = A_0.GetInt32("TTMA:DA");
		this.d = (Point)A_0.GetValue("TTMA:PL", typeof(Point));
		this.e = (HashSet<Point>)A_0.GetValue("TTMA:AL", typeof(HashSet<Point>));
		di7.ReadList<HorizontalDirection>("TTMA:AD", ref this.f, A_0);
		this.j = A_0.GetInt32("TTMA:CA");
		this.g = A_0.GetBoolean("TTMA:PPL");
		this.h = A_0.GetBoolean("TTMA:FTC");
		this.i = A_0.GetDouble("TTMA:T");
		if (ell.a() >= 518)
		{
			this.j = A_0.GetInt32("TTMA:R");
		}
	}

	// Token: 0x06007054 RID: 28756 RVA: 0x002F31D4 File Offset: 0x002F13D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TTMA:TER", this.a);
		info.AddValue("TTMA:TTR", this.b);
		info.AddValue("TTMA:DA", this.c);
		info.AddValue("TTMA:PL", this.d);
		info.AddValue("TTMA:AL", this.e);
		di7.WriteList<HorizontalDirection>("TTMA:AD", this.f, info);
		info.AddValue("TTMA:CA", this.j);
		info.AddValue("TTMA:PPL", this.g);
		info.AddValue("TTMA:FTC", this.h);
		info.AddValue("TTMA:T", this.i);
		info.AddValue("TTMA:R", this.j);
	}

	// Token: 0x06007055 RID: 28757 RVA: 0x002F32AC File Offset: 0x002F14AC
	public sealed override object fm()
	{
		object obj = this.c();
		if (obj == null)
		{
			obj = this.b();
		}
		return obj;
	}

	// Token: 0x06007056 RID: 28758 RVA: 0x002F32D0 File Offset: 0x002F14D0
	public bool f()
	{
		return this.h;
	}

	// Token: 0x06007057 RID: 28759 RVA: 0x002F32D8 File Offset: 0x002F14D8
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06007058 RID: 28760 RVA: 0x002F32E4 File Offset: 0x002F14E4
	private b0b c()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06007059 RID: 28761 RVA: 0x002F3300 File Offset: 0x002F1500
	private ak1 b()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x0600705A RID: 28762 RVA: 0x002F331C File Offset: 0x002F151C
	public double e()
	{
		return this.i;
	}

	// Token: 0x0600705B RID: 28763 RVA: 0x002F3324 File Offset: 0x002F1524
	public void a(double A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600705C RID: 28764 RVA: 0x002F3330 File Offset: 0x002F1530
	public int d()
	{
		return this.j;
	}

	// Token: 0x0600705D RID: 28765 RVA: 0x002F3338 File Offset: 0x002F1538
	public void a(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600705E RID: 28766 RVA: 0x002F3344 File Offset: 0x002F1544
	public fk(ale A_0, object A_1, List<HorizontalDirection> A_2, bool A_3 = false, int A_4 = 0) : base(A_0)
	{
		b0b b0b = A_1 as b0b;
		if (b0b != null)
		{
			this.a = new ar7(b0b);
		}
		else
		{
			ak1 a_ = A_1 as ak1;
			this.b = new edx(a_);
		}
		this.f = A_2;
		this.g = (A_3 && A_2 != null && A_2.Count > 0);
		this.j = A_4;
	}

	// Token: 0x0600705F RID: 28767 RVA: 0x002F33D0 File Offset: 0x002F15D0
	public czp g()
	{
		czp czp = new czp();
		czp.g = base.n();
		czp.j = this;
		czp.n.a = true;
		czp.n.c = 3f;
		czp.b = (this.g ? czr.b : czr.c);
		czp.f = true;
		czp.o = this.i;
		em1.a(czp, base.n());
		this.a();
		czp.e = new ee4(this.c, this.d);
		return czp;
	}

	// Token: 0x06007060 RID: 28768 RVA: 0x002F3468 File Offset: 0x002F1668
	protected override bool fn()
	{
		this.j = -1;
		base.t();
		return true;
	}

	// Token: 0x06007061 RID: 28769 RVA: 0x002F347C File Offset: 0x002F167C
	protected sealed override void fo()
	{
		if (this.fm() == null)
		{
			base.a(null);
			return;
		}
		czp a_ = this.g();
		wu serviceOrThrow = bpo.GetServiceOrThrow<wu>();
		eso a_2 = base.n().a8().IsPlayer ? eso.e : eso.d;
		c5w a_3 = serviceOrThrow.aki(a_, base.n().a8().Playfield.PathProcessor, a_2);
		base.a(a_3);
	}

	// Token: 0x06007062 RID: 28770 RVA: 0x002F34F4 File Offset: 0x002F16F4
	protected sealed override void fp()
	{
		this.a();
		bool a_ = false;
		if (base.n().a8().Area.c() == this.c)
		{
			Point a_2;
			Point point;
			base.n().a8().b(out a_2, out point);
			if (a_2 == this.d)
			{
				a_ = !this.g;
			}
			else
			{
				a_ = this.fs(new ee4(base.n().a8().Area.c(), a_2), 0, null);
			}
		}
		base.c(a_);
	}

	// Token: 0x06007063 RID: 28771 RVA: 0x002F3588 File Offset: 0x002F1788
	protected override void fq()
	{
		if (this.h || this.c() == null)
		{
			aw1.b(base.n().a8(), this.fm(), false);
			return;
		}
		if (this.f != null && this.f.Count == 1)
		{
			base.n().a8().VisualDirection = (this.f[0] + 4) % (HorizontalDirection)8;
			return;
		}
		aw1.a(base.n().a8(), this.c());
	}

	// Token: 0x06007064 RID: 28772 RVA: 0x002F3618 File Offset: 0x002F1818
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if ((this.c() == null && this.b() == null) || (this.c() != null && (this.c().Playfield == null || this.c().j != cgy.b)) || (this.b() != null && this.b().Area == null))
		{
			return dc4.e;
		}
		return base.fr(A_0, A_1);
	}

	// Token: 0x06007065 RID: 28773 RVA: 0x002F368C File Offset: 0x002F188C
	private void a()
	{
		cun.b(base.n().a8(), this.fm(), this.f, out this.d, out this.e, out this.c, this.j);
	}

	// Token: 0x06007066 RID: 28774 RVA: 0x002F36D0 File Offset: 0x002F18D0
	public bool fs(ee4 A_0, int A_1, cr6 A_2)
	{
		return A_0.b == this.c && this.e.Contains(A_0.a);
	}

	// Token: 0x04002DEF RID: 11759
	private new ar7 a;

	// Token: 0x04002DF0 RID: 11760
	private edx b;

	// Token: 0x04002DF1 RID: 11761
	private new int c;

	// Token: 0x04002DF2 RID: 11762
	private Point d;

	// Token: 0x04002DF3 RID: 11763
	private HashSet<Point> e;

	// Token: 0x04002DF4 RID: 11764
	private List<HorizontalDirection> f;

	// Token: 0x04002DF5 RID: 11765
	private bool g;

	// Token: 0x04002DF6 RID: 11766
	private new bool h = true;

	// Token: 0x04002DF7 RID: 11767
	private double i = double.MaxValue;

	// Token: 0x04002DF8 RID: 11768
	private new int j;
}
