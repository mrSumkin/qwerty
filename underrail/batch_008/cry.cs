using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200126A RID: 4714
[eiz("GSE")]
[Serializable]
public abstract class cry : Aspect<c5x>, ISerializable, chb, c98, bp1
{
	// Token: 0x06006631 RID: 26161 RVA: 0x002B7370 File Offset: 0x002B5570
	protected cry(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("GSE:L");
		this.b = A_0.GetString("GSE:O");
		this.c = (A_0.GetValue("GSE:B", typeof(Guid?)) as Guid?);
		this.d = A_0.GetDouble("GSE:C");
		this.e = A_0.GetDouble("GSE:S");
		this.f = A_0.GetBoolean("GSE:D");
		if (ell.a() >= 541)
		{
			this.g = A_0.GetBoolean("GSE:T");
		}
	}

	// Token: 0x06006632 RID: 26162 RVA: 0x002B7430 File Offset: 0x002B5630
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GSE:L", this.a);
		info.AddValue("GSE:O", this.b);
		info.AddValue("GSE:B", this.c);
		info.AddValue("GSE:C", this.d);
		info.AddValue("GSE:S", this.e);
		info.AddValue("GSE:D", this.f);
		info.AddValue("GSE:T", this.g);
	}

	// Token: 0x06006633 RID: 26163 RVA: 0x002B74C4 File Offset: 0x002B56C4
	public bool g()
	{
		return this.f;
	}

	// Token: 0x06006634 RID: 26164
	public abstract string gv();

	// Token: 0x06006635 RID: 26165
	public abstract bool gw();

	// Token: 0x06006636 RID: 26166 RVA: 0x002B74CC File Offset: 0x002B56CC
	protected string d()
	{
		return this.b;
	}

	// Token: 0x06006637 RID: 26167 RVA: 0x002B74D4 File Offset: 0x002B56D4
	protected virtual bool ur()
	{
		return false;
	}

	// Token: 0x06006638 RID: 26168 RVA: 0x002B74D8 File Offset: 0x002B56D8
	public bool h()
	{
		return this.g;
	}

	// Token: 0x06006639 RID: 26169 RVA: 0x002B74E0 File Offset: 0x002B56E0
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600663A RID: 26170 RVA: 0x002B74EC File Offset: 0x002B56EC
	public cry(c5x A_0, string A_1, Guid? A_2) : base(A_0)
	{
		this.b = A_1;
		this.c = A_2;
		this.d = (double)d0u.b;
		this.e = (double)(d0u.b / 5);
		this.a();
	}

	// Token: 0x0600663B RID: 26171 RVA: 0x002B7540 File Offset: 0x002B5740
	public void a(double A_0)
	{
		if (!this.f)
		{
			this.a += A_0;
			this.b();
		}
	}

	// Token: 0x0600663C RID: 26172 RVA: 0x002B7564 File Offset: 0x002B5764
	public void b(double A_0)
	{
		if (!this.f)
		{
			this.a -= A_0;
			this.b();
		}
	}

	// Token: 0x0600663D RID: 26173 RVA: 0x002B758C File Offset: 0x002B578C
	public void e()
	{
		eir.d(base.a8().Zone);
		ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (this.ur() || (c5x.h.b != null && c5x.aj().a() == ak.Location))
				{
					this.gy(c5x);
				}
			}
		}
		if (!this.g)
		{
			double a_ = (bpv.c * 0.66 + cuo.a.NextDouble() * bpv.c * 0.33) * this.q4();
			this.b(a_);
		}
	}

	// Token: 0x0600663E RID: 26174 RVA: 0x002B7694 File Offset: 0x002B5894
	public virtual double q4()
	{
		return 1.0;
	}

	// Token: 0x0600663F RID: 26175 RVA: 0x002B76A0 File Offset: 0x002B58A0
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.d -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.d += (double)d0u.b;
				this.e();
			}
			if (!this.g && (this.e -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.e += (double)(d0u.b / 5);
				this.a(false, null);
				return;
			}
		}
		else
		{
			this.d = (double)d0u.b;
			this.e = (double)(d0u.b / 5);
			this.a();
		}
	}

	// Token: 0x06006640 RID: 26176 RVA: 0x002B776C File Offset: 0x002B596C
	public void a(bool A_0 = false, HashSet<Guid> A_1 = null)
	{
		p7 p = cx2.a(this.gv());
		if (p == null)
		{
			return;
		}
		if (A_1 != null)
		{
			A_1.Add(base.a8().qe());
		}
		if (this.a > 1.5)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				List<ak1> list = new List<ak1>();
				ak1 ak2 = ak.Area.b(ak.Location.X, ak.Location.Y - 1);
				ak1 ak3 = ak.Area.b(ak.Location.X, ak.Location.Y + 1);
				ak1 ak4 = ak.Area.b(ak.Location.X - 1, ak.Location.Y);
				ak1 ak5 = ak.Area.b(ak.Location.X + 1, ak.Location.Y);
				foreach (ak1 ak6 in new ak1[]
				{
					ak2,
					ak3,
					ak4,
					ak5
				})
				{
					if (ak6 != null && !ak6.Formation.b(4L) && p.aem(ak6))
					{
						list.Add(ak6);
					}
				}
				double num = Math.Min(bpv.b / 5.0, (this.a - 1.0) / (double)list.Count);
				while (list.Count > 0)
				{
					int index = cuo.a.Next(list.Count);
					ak1 ak7 = list[index];
					list.RemoveAt(index);
					c5x c5x = bpv.a(ak7, this.gv());
					if (c5x != null)
					{
						cry aspect = c5x.GetAspect<cry>();
						if (aspect != null && !aspect.g() && aspect.a + num <= this.a - num)
						{
							this.b(num);
							aspect.a(num);
							if (A_0 && A_1 != null && !A_1.Contains(c5x.qe()))
							{
								aspect.a(true, A_1);
								double a_ = (bpv.c * 0.66 + cuo.a.NextDouble() * bpv.c * 0.33) * 0.35;
								aspect.b(a_);
							}
						}
					}
					else if (bpv.a(this.gv(), num, ak7, this.b, false, this.g, new double?(1000.0)) != null)
					{
						this.b(num);
					}
					if (this.a < 1.0)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006641 RID: 26177 RVA: 0x002B7A48 File Offset: 0x002B5C48
	public void c()
	{
		this.e();
		if (!this.g)
		{
			for (int i = 0; i < 5; i++)
			{
				this.a(false, null);
			}
		}
	}

	// Token: 0x06006642 RID: 26178 RVA: 0x002B7A80 File Offset: 0x002B5C80
	public int f()
	{
		return d05.a(1, (int)this.a + 1, 4);
	}

	// Token: 0x06006643 RID: 26179
	public abstract void gx(c5x A_0);

	// Token: 0x06006644 RID: 26180 RVA: 0x002B7A94 File Offset: 0x002B5C94
	public void mx()
	{
		this.d = (double)d0u.b;
		this.e = (double)(d0u.b / 5);
		this.a();
	}

	// Token: 0x06006645 RID: 26181 RVA: 0x002B7AB8 File Offset: 0x002B5CB8
	public void my()
	{
	}

	// Token: 0x06006646 RID: 26182
	protected abstract void gy(c5x A_0);

	// Token: 0x06006647 RID: 26183 RVA: 0x002B7ABC File Offset: 0x002B5CBC
	private bool b()
	{
		if (this.a > bpv.a)
		{
			this.a = bpv.a;
		}
		if (this.a <= 0.0 && base.a8().Zone != null)
		{
			this.a(0);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				List<ya> list = ak.a(typeof(djd));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						djd djd = ya as djd;
						if (djd != null && djd.b() != null && djd.b().ao() == this)
						{
							djd.o();
						}
					}
				}
			}
			if (base.a8().i.b != null)
			{
				base.a8().i.b.a(true, false);
			}
			qy qy = new qy();
			List<auv> list2 = qy.ad();
			ad6 ad = new ad6(base.a8());
			ad.b((double)base.a8().ae.GetValueOrDefault(1f));
			ad.c(0.0);
			list2.Add(ad);
			qy.ad().Add(new c7(base.a8(), true, true, true, false));
			base.a8().Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			if (this.c != null)
			{
				c5x c5x = new ar7(this.c.Value, base.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					if (c5x.i.b != null)
					{
						c5x.i.b.a(true, false);
					}
					qy qy2 = new qy();
					List<auv> list3 = qy2.ad();
					ad6 ad2 = new ad6(c5x);
					ad2.b((double)c5x.ae.GetValueOrDefault(1f));
					ad2.c(0.0);
					list3.Add(ad2);
					qy2.ad().Add(new c7(c5x, true, true, true, false));
					base.a8().Zone.ActionManager.g9(qy2, atp.a);
					dz6.a(qy2);
				}
			}
			this.f = true;
			return true;
		}
		int a_ = (int)Math.Min(3.0, this.a);
		this.a(a_);
		return false;
	}

	// Token: 0x06006648 RID: 26184 RVA: 0x002B7D6C File Offset: 0x002B5F6C
	private void a(int A_0)
	{
		this.a(A_0, base.a8());
		c5x c5x = new ar7(this.c.Value, base.a8().Area).ao() as c5x;
		if (c5x != null)
		{
			this.a(A_0, c5x);
		}
	}

	// Token: 0x06006649 RID: 26185 RVA: 0x002B7DBC File Offset: 0x002B5FBC
	private void a(int A_0, c5x A_1)
	{
		if (A_1.o.b != null)
		{
			this.a(A_0, A_1.o.b);
			return;
		}
		if (A_1.p.b != null)
		{
			p7 p = cx2.a(this.gv());
			for (int i = 0; i < A_1.p.b.a.Count; i++)
			{
				if (i == 0 || p.afx())
				{
					cd0 a_ = A_1.p.b.a[i];
					this.a(A_0, a_);
				}
			}
		}
	}

	// Token: 0x0600664A RID: 26186 RVA: 0x002B7E5C File Offset: 0x002B605C
	private void a(int A_0, cd0 A_1)
	{
		p7 p = cx2.a(this.gv());
		if (p != null)
		{
			A_1.d = new float?(p.mo() + (float)A_0 * p.mp());
		}
	}

	// Token: 0x0600664B RID: 26187 RVA: 0x002B7E98 File Offset: 0x002B6098
	private void a()
	{
		this.d += (double)cuo.a.Next((int)this.d / 2);
		this.e += (double)cuo.a.Next((int)this.e / 2);
	}

	// Token: 0x04002A73 RID: 10867
	private double a = -0.1;

	// Token: 0x04002A74 RID: 10868
	private string b;

	// Token: 0x04002A75 RID: 10869
	private Guid? c;

	// Token: 0x04002A76 RID: 10870
	private double d;

	// Token: 0x04002A77 RID: 10871
	private double e;

	// Token: 0x04002A78 RID: 10872
	private bool f;

	// Token: 0x04002A79 RID: 10873
	private bool g;
}
