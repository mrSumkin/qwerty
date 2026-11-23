using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x0200134F RID: 4943
[eiz("TCTA")]
[Serializable]
public sealed class es3 : b1z, ISerializable, cdf, e0p
{
	// Token: 0x06006FDD RID: 28637 RVA: 0x002EEF5C File Offset: 0x002ED15C
	private es3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TCTA:S", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.b = (A_0.GetValue("TCTA:T", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.c = (A_0.GetValue("TCTA:R", typeof(EntityAspectReference<ale, ale>)) as EntityAspectReference<ale, ale>);
		this.d = (es3.a)A_0.GetValue("TCTA:P", typeof(es3.a));
		this.e = A_0.GetInt32("TCTA:A");
		this.f = (A_0.GetValue("TCTA:L", typeof(HashSet<Point>)) as HashSet<Point>);
		this.g = (Point)A_0.GetValue("TCTA:D", typeof(Point));
		this.h = A_0.GetInt32("TCTA:I");
		this.i = (A_0.GetValue("TCTA:M", typeof(HashSet<Guid>)) as HashSet<Guid>);
	}

	// Token: 0x06006FDE RID: 28638 RVA: 0x002EF074 File Offset: 0x002ED274
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCTA:S", this.a);
		info.AddValue("TCTA:T", this.b);
		info.AddValue("TCTA:R", this.c);
		info.AddValue("TCTA:P", this.d);
		info.AddValue("TCTA:A", this.e);
		info.AddValue("TCTA:L", this.f);
		info.AddValue("TCTA:D", this.g);
		info.AddValue("TCTA:I", this.h);
		info.AddValue("TCTA:M", this.i);
	}

	// Token: 0x06006FDF RID: 28639 RVA: 0x002EF12C File Offset: 0x002ED32C
	public es3(amc A_0)
	{
		czh.a(A_0, "subject");
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = (A_0.a8().t.b.y6()[cy1.b] as EntityAspectReference<amc, amc>);
		this.c = new EntityAspectReference<ale, ale>(A_0.a8().k.b);
	}

	// Token: 0x06006FE0 RID: 28640 RVA: 0x002EF19C File Offset: 0x002ED39C
	public bool fs(ee4 A_0, int A_1, cr6 A_2)
	{
		return A_0.b == this.h && ar1.a(A_0.a, this.f, null);
	}

	// Token: 0x06006FE1 RID: 28641 RVA: 0x002EF1D8 File Offset: 0x002ED3D8
	public eyu p3(ee4 A_0, cr6 A_1)
	{
		return this.c.ao().a(A_0, A_1, null, this.i);
	}

	// Token: 0x06006FE2 RID: 28642 RVA: 0x002EF1F8 File Offset: 0x002ED3F8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		if (this.b == null || this.b.ao() == null || this.b.ao().aa().Dead)
		{
			return dc4.e;
		}
		if (this.c == null || this.c.ao() == null)
		{
			return dc4.e;
		}
		if (this.d == es3.a.a)
		{
			this.c();
			this.b();
		}
		else if (this.d != es3.a.b && this.d != es3.a.c && this.d == es3.a.d)
		{
			return dc4.e;
		}
		return dc4.c;
	}

	// Token: 0x06006FE3 RID: 28643 RVA: 0x002EF2BC File Offset: 0x002ED4BC
	private void c()
	{
		if (this.a.ao().a8().t.b.ad().GetPrimitivePropertyValue<bool>("Caster", new bool?(false)).Value)
		{
			this.e = 5;
			return;
		}
		this.e = (int)this.a.ao().aa().Offense.u().TypedDefinition.ad();
	}

	// Token: 0x06006FE4 RID: 28644 RVA: 0x002EF338 File Offset: 0x002ED538
	private void b()
	{
		this.d = es3.a.b;
		this.g = this.b.ao().a8().aj().a();
		this.h = this.b.ao().a8().Area.c();
		anp anp = aw1.b(this.g, this.b.ao().a8().Area, (float)this.e, 0L, 0L);
		anp.a(new EventHandler<EventArgs>(this.c));
		anp.k();
	}

	// Token: 0x06006FE5 RID: 28645 RVA: 0x002EF3D0 File Offset: 0x002ED5D0
	[dcc("TCTA:mPFIF")]
	private void c(object A_0, EventArgs A_1)
	{
		if (this.c != null && this.c.ao() != null && this.c.ao().a8() != null && this.c.ao().a8().Zone != null)
		{
			anp a_ = A_0 as anp;
			czp a_2 = this.a(a_);
			c5w a_3 = bpo.GetServiceOrThrow<wu>().aki(a_2, this.c.ao().a8().Playfield.PathProcessor, eso.d);
			this.b(a_3);
		}
	}

	// Token: 0x06006FE6 RID: 28646 RVA: 0x002EF468 File Offset: 0x002ED668
	private void b(c5w A_0)
	{
		A_0.auw(new EventHandler<EventArgs>(this.a));
		A_0.auz(new EventHandler<EventArgs>(this.b));
		A_0.au2();
	}

	// Token: 0x06006FE7 RID: 28647 RVA: 0x002EF494 File Offset: 0x002ED694
	private czp a(anp A_0)
	{
		this.f = new HashSet<Point>();
		if (A_0.f() != null)
		{
			foreach (Point point in A_0.f())
			{
				this.f.Add(point);
			}
		}
		this.a();
		czp czp = new czp();
		czp.g = this;
		czp.j = this;
		czp.n.a = false;
		czp.n.c = 3f;
		czp.b = czr.b;
		czp.o = double.MaxValue;
		czp.f = true;
		em1.a(czp, this.c.ao());
		czp.e = new ee4(this.h, new Point(this.g.X * 4, this.g.Y * 4));
		return czp;
	}

	// Token: 0x06006FE8 RID: 28648 RVA: 0x002EF59C File Offset: 0x002ED79C
	private void a()
	{
		this.i = new HashSet<Guid>();
		foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
		{
			if (d4n.b.a8().Area == this.a.ao().a8().Area && (d4n.b == this.a.ao() || d4n.b.a(this.a.ao()) != global::h.a))
			{
				this.i.Add(d4n.b.a8().qe());
			}
		}
	}

	// Token: 0x06006FE9 RID: 28649 RVA: 0x002EF678 File Offset: 0x002ED878
	private void b(object A_0, EventArgs A_1)
	{
		this.d = es3.a.d;
	}

	// Token: 0x06006FEA RID: 28650 RVA: 0x002EF684 File Offset: 0x002ED884
	private void a(object A_0, EventArgs A_1)
	{
		if (this.d != es3.a.d && this.d != es3.a.e)
		{
			this.a(A_0 as c5w);
		}
	}

	// Token: 0x06006FEB RID: 28651 RVA: 0x002EF6AC File Offset: 0x002ED8AC
	private void a(c5w A_0)
	{
		if (this.a == null || this.a.ao() == null || this.b == null || this.b.ao() == null || this.b.ao().aa().Dead || this.c == null || this.c.ao() == null || this.a.ao().a8().Area == null)
		{
			this.d = es3.a.d;
			return;
		}
		int num = this.a.ao().a8().Area.c();
		HashSet<c5x> hashSet = new HashSet<c5x>();
		if (A_0 != null && A_0.aus() != null)
		{
			for (int i = 1; i < A_0.aus().Count; i++)
			{
				yz yz = A_0.aus()[i];
				if (yz.a.b != num)
				{
					break;
				}
				if (yz is bne)
				{
					Vector2 vector = new Vector2(yz.a.a.X / 4f, yz.a.a.Y / 4f);
					foreach (b0b b0b in this.a.ao().a8().Area.b((int)vector.X, (int)vector.Y).c.Values)
					{
						c5x c5x = (c5x)b0b;
						if (c5x != this.a.ao().a8() && this.i.Contains(c5x.qe()) && !hashSet.Contains(c5x) && c5x.t.b != null)
						{
							hashSet.Add(c5x);
						}
					}
				}
				if (hashSet.Count > 0)
				{
					using (HashSet<c5x>.Enumerator enumerator2 = hashSet.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							c5x c5x2 = enumerator2.Current;
							if (c5x2.t.b != null)
							{
								c5x2.t.b.a(this.a.ao().a8().t.b);
							}
						}
						break;
					}
				}
			}
		}
		this.d = es3.a.e;
	}

	// Token: 0x04002DAD RID: 11693
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002DAE RID: 11694
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002DAF RID: 11695
	private EntityAspectReference<ale, ale> c;

	// Token: 0x04002DB0 RID: 11696
	private es3.a d;

	// Token: 0x04002DB1 RID: 11697
	private int e;

	// Token: 0x04002DB2 RID: 11698
	private HashSet<Point> f;

	// Token: 0x04002DB3 RID: 11699
	private Point g;

	// Token: 0x04002DB4 RID: 11700
	private int h;

	// Token: 0x04002DB5 RID: 11701
	private HashSet<Guid> i;

	// Token: 0x02001350 RID: 4944
	[eiz("eTCTAa")]
	[Serializable]
	private new enum a
	{
		// Token: 0x04002DB7 RID: 11703
		a,
		// Token: 0x04002DB8 RID: 11704
		b,
		// Token: 0x04002DB9 RID: 11705
		c,
		// Token: 0x04002DBA RID: 11706
		d,
		// Token: 0x04002DBB RID: 11707
		e
	}
}
