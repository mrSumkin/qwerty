using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x0200134A RID: 4938
[eiz("ENA")]
[Serializable]
public sealed class cn9 : dvv, ISerializable
{
	// Token: 0x06006FC4 RID: 28612 RVA: 0x002EDC3C File Offset: 0x002EBE3C
	private cn9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 320)
		{
			this.c = (A_0.GetValue("ENA:ST", typeof(edx)) as edx);
			this.d = A_0.GetDouble("ENA:V");
			this.f = A_0.GetInt32("ENA:CL");
			if (ell.a() >= 388)
			{
				di7.ReadList<ar7>("ENA:L", ref this.e, A_0);
				return;
			}
			List<EntityAspectReference<amc, amc>> list = null;
			di7.ReadList<EntityAspectReference<amc, amc>>("ENA:L", ref list, A_0);
			this.e = new List<ar7>();
			if (list != null)
			{
				foreach (EntityAspectReference<amc, amc> entityAspectReference in list)
				{
					if (entityAspectReference.afl() != null)
					{
						this.e.Add(new ar7(entityAspectReference.afl().Value, entityAspectReference.a(), entityAspectReference.b(), entityAspectReference.c()));
					}
				}
			}
		}
	}

	// Token: 0x06006FC5 RID: 28613 RVA: 0x002EDD68 File Offset: 0x002EBF68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ENA:ST", this.c);
		info.AddValue("ENA:V", this.d);
		di7.WriteList<ar7>("ENA:L", this.e, info);
		info.AddValue("ENA:CL", this.f);
	}

	// Token: 0x06006FC6 RID: 28614 RVA: 0x002EDDC4 File Offset: 0x002EBFC4
	public cn9(edx A_0, double A_1)
	{
		this.c = A_0;
		this.d = A_1;
	}

	// Token: 0x06006FC7 RID: 28615 RVA: 0x002EDDDC File Offset: 0x002EBFDC
	protected override dc4 dt()
	{
		if (this.c == null || this.c.ao() == null || this.c.ao().Zone == null || this.d <= 0.0)
		{
			return dc4.e;
		}
		cn9.b key = new cn9.b(this.c.ao(), this.d);
		DateTime t;
		if (cn9.a.TryGetValue(key, out t) && t > DateTime.Now)
		{
			return dc4.c;
		}
		cn9.a[key] = DateTime.Now + cn9.b;
		this.b();
		if (this.e.Count == 0)
		{
			return dc4.c;
		}
		this.a();
		return dc4.b;
	}

	// Token: 0x06006FC8 RID: 28616 RVA: 0x002EDEA4 File Offset: 0x002EC0A4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.e == null)
		{
			return dc4.c;
		}
		if (this.f >= this.e.Count)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x06006FC9 RID: 28617 RVA: 0x002EDED0 File Offset: 0x002EC0D0
	private void b()
	{
		this.e = new List<ar7>();
		d02 service = bpo.GetService<d02>();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (service != null && serviceOrThrow.aqu() != null)
		{
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && !d4n.b.aa().Passive && !(d4n.b.aa() is e3q) && d4n.b.a8().Area == this.c.ao().Area && d4n.b.aa().IsInControl && !d4n.b.aa().IsInCombat && aw1.a(d4n.b.a8(), this.c.ao()) < this.d)
				{
					exw exw = eym.a(d4n.b);
					if (exw != null && exw.c() != d6n.a)
					{
						bool flag = false;
						if (exw.c() == d6n.b)
						{
							flag = true;
						}
						else if (exw.c() == d6n.c && d4n.b.aa().a(serviceOrThrow.aqu().ac(), asp.a) == h.a)
						{
							flag = true;
						}
						if (flag)
						{
							this.e.Add(new ar7(d4n.b.a8()));
						}
					}
				}
			}
		}
		if (serviceOrThrow.aqw() != null)
		{
			foreach (b0b b0b in serviceOrThrow.aqw().a().ab4(new string[]
			{
				crb.a
			}))
			{
				if (b0b.Area == this.c.ao().Area)
				{
					this.e.Add(new ar7(b0b));
				}
			}
		}
	}

	// Token: 0x06006FCA RID: 28618 RVA: 0x002EE134 File Offset: 0x002EC334
	private void a(c5x A_0)
	{
		Point a_ = A_0.aj().a();
		Point a_2 = this.c.ao().Location;
		cn9.a a = new cn9.a(A_0, this.c.ao(), this.d);
		czp czp = new czp();
		czp.g = a;
		czp.n.a = false;
		czp.f = true;
		czp.c = new ee4(this.c.ao().Area.c(), a_2);
		czp.e = new ee4(A_0.Area.c(), a_);
		czp.r = true;
		c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, this.c.ao().Playfield.PathProcessor, eso.d);
		c5w.auw(new EventHandler<EventArgs>(a.a));
		c5w.auw(new EventHandler<EventArgs>(this.a));
		c5w.auz(new EventHandler<EventArgs>(this.a));
		c5w.au2();
	}

	// Token: 0x06006FCB RID: 28619 RVA: 0x002EE238 File Offset: 0x002EC438
	private void a()
	{
		if (this.e != null)
		{
			while (this.f < this.e.Count)
			{
				c5x c5x = this.e[this.f].ao() as c5x;
				if (c5x != null && c5x.Zone != null && c5x.j == cgy.b)
				{
					this.a(c5x);
					return;
				}
				this.f++;
			}
		}
	}

	// Token: 0x06006FCC RID: 28620 RVA: 0x002EE2B8 File Offset: 0x002EC4B8
	private void a(object A_0, EventArgs A_1)
	{
		this.f++;
		this.a();
	}

	// Token: 0x04002DA0 RID: 11680
	private new static Dictionary<cn9.b, DateTime> a = new Dictionary<cn9.b, DateTime>();

	// Token: 0x04002DA1 RID: 11681
	private static readonly TimeSpan b = TimeSpan.FromSeconds(1.0);

	// Token: 0x04002DA2 RID: 11682
	private edx c;

	// Token: 0x04002DA3 RID: 11683
	private double d;

	// Token: 0x04002DA4 RID: 11684
	private List<ar7> e;

	// Token: 0x04002DA5 RID: 11685
	private int f;

	// Token: 0x0200134B RID: 4939
	private new sealed class a : e0p
	{
		// Token: 0x06006FCE RID: 28622 RVA: 0x002EE2F0 File Offset: 0x002EC4F0
		public a(c5x A_0, ak1 A_1, double A_2)
		{
			this.b = A_0;
			this.c = A_1;
			this.a = A_2;
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x002EE310 File Offset: 0x002EC510
		public eyu p3(ee4 A_0, cr6 A_1)
		{
			eyu result = default(eyu);
			result.f = true;
			if (this.b == null || this.b.Area == null)
			{
				result.b = ac7.b;
				return result;
			}
			ak1 ak = this.b.Area.b(A_0.a.X, A_0.a.Y);
			if (ak == null)
			{
				result.b = ac7.b;
				return result;
			}
			result.b = ac7.c;
			result.a = this.a(ak);
			return result;
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x002EE3A0 File Offset: 0x002EC5A0
		private float a(ak1 A_0)
		{
			if (A_0 != this.c)
			{
				if (A_0.Formation.c(131072L) || A_0.c.Values.Count == 0)
				{
					return aju.ai;
				}
				if (A_0.Formation.c(4L))
				{
					return aju.ah;
				}
			}
			return 1f;
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x002EE408 File Offset: 0x002EC608
		public void a(object A_0, EventArgs A_1)
		{
			if (this.b != null && this.b.j == cgy.b && this.b.Zone != null && this.c != null && this.c.Zone != null)
			{
				c5w c5w = A_0 as c5w;
				if (c5w != null && c5w.aun() == dv8.d && c5w.aus() != null && c5w.aut() != null)
				{
					double num = this.a - (double)((float)c5w.aut().Value / 10f);
					if (num > 0.0)
					{
						if (this.b.h.b != null)
						{
							eym.a(this.b.h.b, this.c, num, true);
						}
						crb aspect = this.b.GetAspect<crb>();
						if (aspect != null)
						{
							aspect.a(this.c, num);
						}
					}
				}
			}
		}

		// Token: 0x04002DA6 RID: 11686
		private double a;

		// Token: 0x04002DA7 RID: 11687
		private c5x b;

		// Token: 0x04002DA8 RID: 11688
		private ak1 c;
	}

	// Token: 0x0200134C RID: 4940
	private sealed class b
	{
		// Token: 0x06006FD2 RID: 28626 RVA: 0x002EE514 File Offset: 0x002EC714
		public b(ak1 A_0, double A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x002EE52C File Offset: 0x002EC72C
		public override bool Equals(object obj)
		{
			cn9.b b = obj as cn9.b;
			return b != null && this.a == b.a && this.b == b.b;
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x002EE56C File Offset: 0x002EC76C
		public override int GetHashCode()
		{
			int num = this.b.GetHashCode();
			if (this.a != null)
			{
				num += this.a.GetHashCode();
			}
			return num;
		}

		// Token: 0x04002DA9 RID: 11689
		public ak1 a;

		// Token: 0x04002DAA RID: 11690
		public double b;
	}
}
