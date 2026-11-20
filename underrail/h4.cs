using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012AA RID: 4778
[eiz("WFCEA")]
[Serializable]
public sealed class h4 : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x060068AD RID: 26797 RVA: 0x002C3DC4 File Offset: 0x002C1FC4
	private h4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("WFCEA:E", ref this.b, A_0);
		this.d = (Vector3)A_0.GetValue("WFCEA:M", typeof(Vector3));
		this.e = A_0.GetSingle("WFCEA:T");
		this.f = A_0.GetSingle("WFCEA:S");
		this.g = A_0.GetInt32("WFCEA:I");
		this.h = A_0.GetBoolean("WFCEA:U");
		this.i = A_0.GetDouble("WFCEA:C");
		if (ell.a() >= 414)
		{
			this.a = A_0.GetBoolean("WFCEA:N");
			this.j = (A_0.GetValue("WFCEA:FI", typeof(int?)) as int?);
			this.k = (A_0.GetValue("WFCEA:TF", typeof(int?)) as int?);
			this.l = (A_0.GetValue("WFCEA:FO", typeof(int?)) as int?);
		}
		else
		{
			this.a = true;
		}
		if (ell.a() >= 415)
		{
			this.m = A_0.GetBoolean("WFCEA:IE");
		}
		else
		{
			this.m = true;
		}
		if (ell.a() >= 486)
		{
			di7.ReadList<string>("WFCEA:IE", ref this.c, A_0);
		}
		else
		{
			this.c = new List<string>();
		}
		if (ell.a() >= 489)
		{
			this.n = (A_0.GetValue("WFCEA:PT", typeof(bjp)) as bjp);
			this.o = (A_0.GetValue("WFCEA:RT", typeof(bjp)) as bjp);
		}
	}

	// Token: 0x060068AE RID: 26798 RVA: 0x002C3FE8 File Offset: 0x002C21E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("WFCEA:E", this.b, info);
		di7.WriteList<string>("WFCEA:IE", this.c, info);
		info.AddValue("WFCEA:M", this.d);
		info.AddValue("WFCEA:T", this.e);
		info.AddValue("WFCEA:S", this.f);
		info.AddValue("WFCEA:I", this.g);
		info.AddValue("WFCEA:U", this.h);
		info.AddValue("WFCEA:C", this.i);
		info.AddValue("WFCEA:N", this.a);
		info.AddValue("WFCEA:FI", this.j);
		info.AddValue("WFCEA:TF", this.k);
		info.AddValue("WFCEA:FO", this.l);
		info.AddValue("WFCEA:IE", this.m);
		info.AddValue("WFCEA:PT", this.n);
		info.AddValue("WFCEA:RT", this.o);
	}

	// Token: 0x060068AF RID: 26799 RVA: 0x002C4110 File Offset: 0x002C2310
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060068B0 RID: 26800 RVA: 0x002C4118 File Offset: 0x002C2318
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060068B1 RID: 26801 RVA: 0x002C4124 File Offset: 0x002C2324
	public List<string> i()
	{
		return this.b;
	}

	// Token: 0x060068B2 RID: 26802 RVA: 0x002C412C File Offset: 0x002C232C
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060068B3 RID: 26803 RVA: 0x002C4138 File Offset: 0x002C2338
	public List<string> n()
	{
		return this.c;
	}

	// Token: 0x060068B4 RID: 26804 RVA: 0x002C4140 File Offset: 0x002C2340
	public void b(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060068B5 RID: 26805 RVA: 0x002C414C File Offset: 0x002C234C
	public Vector3 o()
	{
		return this.d;
	}

	// Token: 0x060068B6 RID: 26806 RVA: 0x002C4154 File Offset: 0x002C2354
	public void a(Vector3 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060068B7 RID: 26807 RVA: 0x002C4160 File Offset: 0x002C2360
	public float m()
	{
		return this.e;
	}

	// Token: 0x060068B8 RID: 26808 RVA: 0x002C4168 File Offset: 0x002C2368
	public void a(float A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060068B9 RID: 26809 RVA: 0x002C4174 File Offset: 0x002C2374
	public float h()
	{
		return this.f;
	}

	// Token: 0x060068BA RID: 26810 RVA: 0x002C417C File Offset: 0x002C237C
	public void b(float A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060068BB RID: 26811 RVA: 0x002C4188 File Offset: 0x002C2388
	public int l()
	{
		return this.g;
	}

	// Token: 0x060068BC RID: 26812 RVA: 0x002C4190 File Offset: 0x002C2390
	public void a(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060068BD RID: 26813 RVA: 0x002C419C File Offset: 0x002C239C
	public bool k()
	{
		return this.h;
	}

	// Token: 0x060068BE RID: 26814 RVA: 0x002C41A4 File Offset: 0x002C23A4
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060068BF RID: 26815 RVA: 0x002C41B0 File Offset: 0x002C23B0
	public int? a()
	{
		return this.j;
	}

	// Token: 0x060068C0 RID: 26816 RVA: 0x002C41B8 File Offset: 0x002C23B8
	public void b(int? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060068C1 RID: 26817 RVA: 0x002C41C4 File Offset: 0x002C23C4
	public int? j()
	{
		return this.k;
	}

	// Token: 0x060068C2 RID: 26818 RVA: 0x002C41CC File Offset: 0x002C23CC
	public void c(int? A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060068C3 RID: 26819 RVA: 0x002C41D8 File Offset: 0x002C23D8
	public int? g()
	{
		return this.l;
	}

	// Token: 0x060068C4 RID: 26820 RVA: 0x002C41E0 File Offset: 0x002C23E0
	public void a(int? A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060068C5 RID: 26821 RVA: 0x002C41EC File Offset: 0x002C23EC
	public bool f()
	{
		return this.m;
	}

	// Token: 0x060068C6 RID: 26822 RVA: 0x002C41F4 File Offset: 0x002C23F4
	public void c(bool A_0)
	{
		this.m = A_0;
	}

	// Token: 0x060068C7 RID: 26823 RVA: 0x002C4200 File Offset: 0x002C2400
	public bjp d()
	{
		return this.n;
	}

	// Token: 0x060068C8 RID: 26824 RVA: 0x002C4208 File Offset: 0x002C2408
	public void a(bjp A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060068C9 RID: 26825 RVA: 0x002C4214 File Offset: 0x002C2414
	public bjp e()
	{
		return this.o;
	}

	// Token: 0x060068CA RID: 26826 RVA: 0x002C421C File Offset: 0x002C241C
	public void b(bjp A_0)
	{
		this.o = A_0;
	}

	// Token: 0x060068CB RID: 26827 RVA: 0x002C4228 File Offset: 0x002C2428
	public h4(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060068CC RID: 26828 RVA: 0x002C4280 File Offset: 0x002C2480
	public void r7(eds A_0)
	{
		if (this.a)
		{
			this.i += A_0.b.TotalMilliseconds;
			while (this.i >= (double)this.g)
			{
				this.i -= (double)this.g;
				if (this.b != null && this.b.Count > 0)
				{
					string text = this.b[cuo.a.Next(this.b.Count)];
					if (!string.IsNullOrEmpty(text))
					{
						Vector3 vector = new Vector3((float)((double)this.d.X * cuo.a.NextDouble()), (float)((double)this.d.Y * cuo.a.NextDouble()), (float)((double)this.d.Z * cuo.a.NextDouble()));
						Vector3 vector2 = base.a8().Location + vector;
						ak1 ak = base.a8().Area.a(vector2.a());
						if (ak != null)
						{
							if (this.n != null && this.n.b() != 0L && !ak.Formation.b(this.n.b()))
							{
								return;
							}
							if (this.o != null && this.o.b() != 0L && ak.Formation.b(this.o.b()))
							{
								return;
							}
						}
						Vector3 a_;
						if (this.h)
						{
							a_ = vector2 + new Vector3(0f, 0f, this.e - vector.Z);
						}
						else
						{
							a_ = vector2 + new Vector3(0f, 0f, -(this.e + vector.Z));
						}
						c5x c5x;
						if (this.m)
						{
							c5x = boj.a(base.a8().Area, vector2, null, text, 1, double.MaxValue, null, null, null, null);
						}
						else
						{
							c5x = vq.a(text, base.a8().Zone, new bt4(base.a8().Area.y8(), vector2), false);
						}
						if (c5x != null)
						{
							bpu bpu = new bpu(c5x);
							bpu.a(this.f);
							bpu.b(this.f);
							c5x.SetAspect<bpu>(bpu);
							mj mj = new mj(c5x);
							c5x.SetAspect<mj>(mj);
							qy qy = new qy();
							qy.ad().Add(new bpr(mj, a_));
							qy.ad().Add(new c7(c5x, false, false, true, false));
							if (this.c != null && this.c.Count > 0)
							{
								string a_2 = this.c[cuo.a.Next(this.c.Count)];
								qy.ad().Add(new au0(c5x.Area, a_, a_2, 1, double.MaxValue, null, null, null));
							}
							base.a8().Zone.ActionManager.g9(qy, atp.a);
							if (this.j != null || this.l != null)
							{
								qy qy2 = new qy();
								if (this.j != null)
								{
									c5x.ae = new float?(0f);
									List<auv> list = qy2.ad();
									ad6 ad = new ad6(c5x);
									ad.b(0.0);
									ad.c(1.0);
									ad.a(1.0 / (double)this.j.Value);
									list.Add(ad);
								}
								if (this.k != null)
								{
									qy2.ad().Add(new bm3(this.k.Value));
								}
								if (this.l != null)
								{
									List<auv> list2 = qy2.ad();
									ad6 ad2 = new ad6(c5x);
									ad2.b(1.0);
									ad2.c(0.0);
									ad2.a(1.0 / (double)this.l.Value);
									list2.Add(ad2);
								}
								base.a8().Zone.ActionManager.g9(qy2, atp.a);
							}
						}
					}
				}
			}
			return;
		}
		this.i = 0.0;
	}

	// Token: 0x04002B3F RID: 11071
	private bool a = true;

	// Token: 0x04002B40 RID: 11072
	private List<string> b = new List<string>();

	// Token: 0x04002B41 RID: 11073
	private List<string> c = new List<string>();

	// Token: 0x04002B42 RID: 11074
	private Vector3 d;

	// Token: 0x04002B43 RID: 11075
	private float e = 2f;

	// Token: 0x04002B44 RID: 11076
	private float f = 2f;

	// Token: 0x04002B45 RID: 11077
	private int g = 100;

	// Token: 0x04002B46 RID: 11078
	private bool h;

	// Token: 0x04002B47 RID: 11079
	private double i;

	// Token: 0x04002B48 RID: 11080
	private int? j;

	// Token: 0x04002B49 RID: 11081
	private int? k;

	// Token: 0x04002B4A RID: 11082
	private int? l;

	// Token: 0x04002B4B RID: 11083
	private bool m = true;

	// Token: 0x04002B4C RID: 11084
	private bjp n;

	// Token: 0x04002B4D RID: 11085
	private bjp o;
}
