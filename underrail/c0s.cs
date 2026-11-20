using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x02001306 RID: 4870
[eiz("TEA1")]
[Serializable]
public sealed class c0s : Aspect<c5x>, c98, bp1, bjh, ISerializable
{
	// Token: 0x06006CD1 RID: 27857 RVA: 0x002D88C0 File Offset: 0x002D6AC0
	private c0s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		int? num = null;
		if (ell.a() != 0)
		{
			this.a = (Color?)A_0.GetValue("TEA1:ODC", typeof(Color?));
			di7.ReadList<ecs>("TEA1:QM", ref this.c, A_0);
			this.d = (ecs)A_0.GetValue("TEA1:CM", typeof(ecs));
			this.e = (emw)A_0.GetValue("TEA1:CMO", typeof(emw));
			this.f = A_0.GetDouble("TEA1:CMRT");
			this.h = (dsu)A_0.GetValue("TEA1:TM", typeof(dsu));
			if (ell.a() >= 303)
			{
				this.i = (A_0.GetValue("TEA1:CTO", typeof(Point?)) as Point?);
			}
			else
			{
				num = (int?)A_0.GetValue("TEA1:CTVO", typeof(int?));
			}
			if (ell.a() >= 587)
			{
				this.b = (Color?)A_0.GetValue("TEA1:OEC", typeof(Color?));
			}
		}
		else
		{
			this.a = (A_0.GetValue("TEA:ODC", typeof(Color?)) as Color?);
			this.d = (A_0.GetValue("TEA:CM", typeof(ecs)) as ecs);
			this.f = A_0.GetDouble("TEA:CMRT");
			this.e = (emw)A_0.GetValue("TEA:CMO", typeof(emw));
			di7.ReadList<ecs>("TEA:QM", ref this.c, A_0);
			try
			{
				this.h = (dsu)A_0.GetValue("TEA:TM", typeof(dsu));
				num = (int?)A_0.GetValue("TEA1:CTVO", typeof(int?));
			}
			catch
			{
			}
		}
		if (num != null)
		{
			this.i = new Point?(new Point(0, num.Value));
		}
	}

	// Token: 0x06006CD2 RID: 27858 RVA: 0x002D8B20 File Offset: 0x002D6D20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TEA1:ODC", this.a);
		info.AddValue("TEA1:OEC", this.b);
		di7.WriteList<ecs>("TEA1:QM", this.c, info);
		info.AddValue("TEA1:CM", this.d);
		info.AddValue("TEA1:CMO", this.e);
		info.AddValue("TEA1:CMRT", this.f);
		info.AddValue("TEA1:TM", this.h);
		info.AddValue("TEA1:CTO", this.i);
	}

	// Token: 0x06006CD3 RID: 27859 RVA: 0x002D8BD8 File Offset: 0x002D6DD8
	public Color? j()
	{
		return this.a;
	}

	// Token: 0x06006CD4 RID: 27860 RVA: 0x002D8BE0 File Offset: 0x002D6DE0
	public void b(Color? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x002D8BEC File Offset: 0x002D6DEC
	public Color? k()
	{
		return this.b;
	}

	// Token: 0x06006CD6 RID: 27862 RVA: 0x002D8BF4 File Offset: 0x002D6DF4
	public void a(Color? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006CD7 RID: 27863 RVA: 0x002D8C00 File Offset: 0x002D6E00
	public dn3 g()
	{
		return this.g;
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x002D8C08 File Offset: 0x002D6E08
	public emw e()
	{
		return this.e;
	}

	// Token: 0x06006CD9 RID: 27865 RVA: 0x002D8C10 File Offset: 0x002D6E10
	public dsu i()
	{
		return this.h;
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x002D8C18 File Offset: 0x002D6E18
	public void a(dsu A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006CDB RID: 27867 RVA: 0x002D8C24 File Offset: 0x002D6E24
	public Point? f()
	{
		return this.i;
	}

	// Token: 0x06006CDC RID: 27868 RVA: 0x002D8C2C File Offset: 0x002D6E2C
	public void a(Point? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006CDD RID: 27869 RVA: 0x002D8C38 File Offset: 0x002D6E38
	public bool h()
	{
		return this.d != null || this.c.Count > 0;
	}

	// Token: 0x06006CDE RID: 27870 RVA: 0x002D8C58 File Offset: 0x002D6E58
	public c0s(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006CDF RID: 27871 RVA: 0x002D8C70 File Offset: 0x002D6E70
	public void r7(eds A_0)
	{
		if (this.d != null)
		{
			if (ciz.a(this.d))
			{
				this.g = this.d.b();
			}
			if ((this.f -= A_0.b.TotalMilliseconds) < 0.0)
			{
				this.a();
			}
		}
		if (this.d == null && this.c.Count > 0)
		{
			this.d();
		}
	}

	// Token: 0x06006CE0 RID: 27872 RVA: 0x002D8CFC File Offset: 0x002D6EFC
	public void mx()
	{
		if (this.d != null)
		{
			this.g = this.d.b();
		}
		base.a8().f = true;
	}

	// Token: 0x06006CE1 RID: 27873 RVA: 0x002D8D28 File Offset: 0x002D6F28
	public void my()
	{
		base.a8().f = false;
	}

	// Token: 0x06006CE2 RID: 27874 RVA: 0x002D8D38 File Offset: 0x002D6F38
	public void aiw()
	{
		this.a();
	}

	// Token: 0x06006CE3 RID: 27875 RVA: 0x002D8D44 File Offset: 0x002D6F44
	private void d()
	{
		this.d = this.c[0];
		ciz.a(this.d);
		this.g = this.d.b();
		this.e = this.b();
		this.c.RemoveAt(0);
		this.f = ciz.b(this.d);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && base.a8().c(serviceOrThrow.aqu().v().a().d))
		{
			if (this.h == dsu.a)
			{
				a7v.a(null, base.a8().y8(), this.a(this.d));
				return;
			}
			a7v.a(new h0(this.d.a(), null));
		}
	}

	// Token: 0x06006CE4 RID: 27876 RVA: 0x002D8E40 File Offset: 0x002D7040
	private ecs a(ecs A_0)
	{
		ecs ecs = new ecs();
		if (A_0 != null && A_0.a.Count > 0)
		{
			if (A_0.a.Count == 1)
			{
				return A_0;
			}
			dl6 dl = new dl6();
			bool flag = true;
			foreach (dl6 dl2 in A_0.a)
			{
				bool flag2 = true;
				foreach (bph bph in dl2.a)
				{
					bph bph2 = new bph(bph.a.a(), bph.b, null);
					dl.a.Add(bph2);
					if (!flag && flag2)
					{
						bph2.b = " " + bph2.b;
					}
					flag2 = false;
				}
				flag = false;
			}
			ecs.a.Add(dl);
		}
		return ecs;
	}

	// Token: 0x06006CE5 RID: 27877 RVA: 0x002D8F70 File Offset: 0x002D7170
	private emw b()
	{
		if (base.a8().VisualDirection > HorizontalDirection.Southeast)
		{
			return emw.a;
		}
		return emw.b;
	}

	// Token: 0x06006CE6 RID: 27878 RVA: 0x002D8F88 File Offset: 0x002D7188
	private void a()
	{
		this.d = null;
		this.g = null;
		this.f = 0.0;
	}

	// Token: 0x06006CE7 RID: 27879 RVA: 0x002D8FAC File Offset: 0x002D71AC
	public bool a(string A_0, bool A_1, Color? A_2 = null, Color? A_3 = null)
	{
		bool result = A_1 || (this.c.Count == 0 && this.d == null);
		if (A_1)
		{
			this.l();
		}
		this.c.AddRange(ciz.a(A_0, this.h, (A_2 != null) ? A_2 : this.a, (A_3 != null) ? A_3 : this.b));
		return result;
	}

	// Token: 0x06006CE8 RID: 27880 RVA: 0x002D9038 File Offset: 0x002D7238
	public void l()
	{
		this.a();
		this.c.Clear();
	}

	// Token: 0x04002C9D RID: 11421
	private Color? a;

	// Token: 0x04002C9E RID: 11422
	private Color? b;

	// Token: 0x04002C9F RID: 11423
	private List<ecs> c = new List<ecs>();

	// Token: 0x04002CA0 RID: 11424
	private ecs d;

	// Token: 0x04002CA1 RID: 11425
	private emw e;

	// Token: 0x04002CA2 RID: 11426
	private double f;

	// Token: 0x04002CA3 RID: 11427
	[NonSerialized]
	private dn3 g;

	// Token: 0x04002CA4 RID: 11428
	private dsu h;

	// Token: 0x04002CA5 RID: 11429
	private Point? i;
}
