using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;

// Token: 0x020010C7 RID: 4295
[eiz("OSGJ")]
[Serializable]
public sealed class b6r : cze, ISerializable
{
	// Token: 0x06005A58 RID: 23128 RVA: 0x0026FFA4 File Offset: 0x0026E1A4
	private b6r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Guid)A_0.GetValue("OSGJ:LSEI", typeof(Guid));
			this.b = (Guid)A_0.GetValue("OSGJ:RSEI", typeof(Guid));
			this.c = A_0.GetString("OSGJ:AN");
			this.d = (bbo)A_0.GetValue("OSGJ:O", typeof(bbo));
			if (ell.a() >= 344)
			{
				this.e = (A_0.GetValue("OSGJ:TF", typeof(int?)) as int?);
				this.f = (A_0.GetValue("OSGJ:AS", typeof(int?)) as int?);
				this.g = A_0.GetString("OSGJ:OS");
				this.h = A_0.GetString("OSGJ:CS");
			}
			if (ell.a() >= 439)
			{
				this.i = A_0.GetBoolean("OSGJ:E");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(b6r))
			{
				this.a = (Guid)A_0.GetValue("_LeftSegmentEntityId", typeof(Guid));
				this.b = (Guid)A_0.GetValue("_RightSegmentEntityId", typeof(Guid));
				this.c = A_0.GetString("_AreaName");
				this.d = (bbo)A_0.GetValue("_Operation", typeof(bbo));
				return;
			}
			this.a = (Guid)A_0.GetValue("OperateSplitGateJob+_LeftSegmentEntityId", typeof(Guid));
			this.b = (Guid)A_0.GetValue("OperateSplitGateJob+_RightSegmentEntityId", typeof(Guid));
			this.c = A_0.GetString("OperateSplitGateJob+_AreaName");
			this.d = (bbo)A_0.GetValue("OperateSplitGateJob+_Operation", typeof(bbo));
		}
	}

	// Token: 0x06005A59 RID: 23129 RVA: 0x002701D0 File Offset: 0x0026E3D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OSGJ:LSEI", this.a);
		info.AddValue("OSGJ:RSEI", this.b);
		info.AddValue("OSGJ:AN", this.c);
		info.AddValue("OSGJ:O", this.d);
		info.AddValue("OSGJ:TF", this.e);
		info.AddValue("OSGJ:AS", this.f);
		info.AddValue("OSGJ:OS", this.g);
		info.AddValue("OSGJ:CS", this.h);
		info.AddValue("OSGJ:E", this.i);
	}

	// Token: 0x06005A5A RID: 23130 RVA: 0x00270298 File Offset: 0x0026E498
	private int d()
	{
		return this.e.GetValueOrDefault(6);
	}

	// Token: 0x06005A5B RID: 23131 RVA: 0x002702A8 File Offset: 0x0026E4A8
	private int c()
	{
		return this.f.GetValueOrDefault(300);
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x002702BC File Offset: 0x0026E4BC
	private string b()
	{
		return this.h ?? "LargeDoor";
	}

	// Token: 0x06005A5D RID: 23133 RVA: 0x002702D0 File Offset: 0x0026E4D0
	private string a()
	{
		return this.g ?? "LargeDoor";
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x002702E4 File Offset: 0x0026E4E4
	public int? h()
	{
		return this.e;
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x002702EC File Offset: 0x0026E4EC
	public void a(int? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x002702F8 File Offset: 0x0026E4F8
	public int? i()
	{
		return this.f;
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x00270300 File Offset: 0x0026E500
	public void b(int? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x0027030C File Offset: 0x0026E50C
	public string g()
	{
		return this.g;
	}

	// Token: 0x06005A63 RID: 23139 RVA: 0x00270314 File Offset: 0x0026E514
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x00270320 File Offset: 0x0026E520
	public string j()
	{
		return this.h;
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x00270328 File Offset: 0x0026E528
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x00270334 File Offset: 0x0026E534
	public Guid l()
	{
		return this.a;
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x0027033C File Offset: 0x0026E53C
	public void b(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A68 RID: 23144 RVA: 0x00270348 File Offset: 0x0026E548
	public Guid m()
	{
		return this.b;
	}

	// Token: 0x06005A69 RID: 23145 RVA: 0x00270350 File Offset: 0x0026E550
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A6A RID: 23146 RVA: 0x0027035C File Offset: 0x0026E55C
	public string k()
	{
		return this.c;
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x00270364 File Offset: 0x0026E564
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x00270370 File Offset: 0x0026E570
	public bbo e()
	{
		return this.d;
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x00270378 File Offset: 0x0026E578
	public void a(bbo A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005A6E RID: 23150 RVA: 0x00270384 File Offset: 0x0026E584
	public bool f()
	{
		return this.i;
	}

	// Token: 0x06005A6F RID: 23151 RVA: 0x0027038C File Offset: 0x0026E58C
	public void a(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005A70 RID: 23152 RVA: 0x00270398 File Offset: 0x0026E598
	public b6r()
	{
	}

	// Token: 0x06005A71 RID: 23153 RVA: 0x002703A0 File Offset: 0x0026E5A0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_2 != null && A_2.ContainsKey(dmh.e))
		{
			e6z e6z = A_2[dmh.e] as e6z;
			if (e6z != null)
			{
				aud = e6z.ao();
			}
		}
		if (aud == null)
		{
			if (string.IsNullOrWhiteSpace(this.c))
			{
				return;
			}
			c1a c1a = null;
			if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
			}
			else if (A_2 != null && A_2.ContainsKey(dmh.d))
			{
				a55 a = A_2[dmh.d] as a55;
				if (a != null)
				{
					c1a = a.ao();
				}
			}
			if (c1a == null)
			{
				return;
			}
			aud = c1a.n(this.c);
		}
		if (aud == null)
		{
			return;
		}
		ar7 ar = new ar7(this.a, aud);
		ar7 ar2 = new ar7(this.b, aud);
		if (ar.ao() != null && ar2.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			cd0 aspect2 = ar2.ao().GetAspect<cd0>();
			ny aspect3 = ar.ao().GetAspect<ny>();
			ny aspect4 = ar2.ao().GetAspect<ny>();
			if (aspect != null && aspect2 != null && aspect3 != null && aspect4 != null)
			{
				if (this.d == bbo.b)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "open")
						{
							this.a(aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != this.d() - 1)
					{
						this.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (this.d == bbo.c)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "close")
						{
							this.a(aud, aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 0)
					{
						this.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (aspect3.a() != null)
				{
					if (aspect3.a().Name == "open")
					{
						this.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
					this.a(aspect, aspect2, aspect3, aspect4);
					return;
				}
				else
				{
					if (aspect.b.X < this.d() / 2)
					{
						this.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
					this.a(aud, aspect, aspect2, aspect3, aspect4);
				}
			}
		}
	}

	// Token: 0x06005A72 RID: 23154 RVA: 0x00270658 File Offset: 0x0026E858
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		Guid guid = this.a;
		if (A_2 != null && A_2.ContainsKey(dmh.e))
		{
			e6z e6z = A_2[dmh.e] as e6z;
			if (e6z != null)
			{
				aud = e6z.ao();
			}
		}
		if (aud == null)
		{
			if (string.IsNullOrWhiteSpace(this.c))
			{
				return false;
			}
			c1a c1a = null;
			if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
			}
			else if (A_2.ContainsKey(dmh.d))
			{
				a55 a = A_2[dmh.d] as a55;
				if (a != null)
				{
					c1a = a.ao();
				}
			}
			if (c1a == null)
			{
				return false;
			}
			aud = c1a.n(this.c);
		}
		if (aud == null)
		{
			return false;
		}
		ar7 ar = new ar7(this.a, aud);
		if (ar.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			ny aspect2 = ar.ao().GetAspect<ny>();
			if (aspect2 != null)
			{
				if (aspect2.a() != null)
				{
					return aspect2.a().Name == "close";
				}
				if (aspect != null)
				{
					return aspect.b.X == 0;
				}
			}
		}
		return false;
	}

	// Token: 0x06005A73 RID: 23155 RVA: 0x002707BC File Offset: 0x0026E9BC
	private void a(cd0 A_0, cd0 A_1, ny A_2, ny A_3)
	{
		awx awx = new awx("open");
		awx.a(m7.b | m7.k);
		dqm dqm = new dqm(A_0);
		dqm.c(this.d() - 1 - A_0.b.X);
		dqm.a(true);
		dqm.b(A_0.b.X);
		dqm.a(1);
		dqm.a((double)this.c());
		l6 l = new l6();
		l.a(new ar7(A_0.a8()));
		l.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l.a(x3.c);
		l6 l2 = new l6();
		l2.a(new ar7(A_0.a8()));
		l2.a().c(new List<byte>
		{
			1
		});
		l2.a(x3.c);
		awx.ad().Add(new bm3(200));
		awx.ad().Add(l);
		awx.ad().Add(dqm);
		awx.ad().Add(l2);
		awx awx2 = new awx("open");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_1);
		dqm2.c(this.d() - 1 - A_1.b.X);
		dqm2.a(true);
		dqm2.b(A_1.b.X);
		dqm2.a(1);
		dqm2.a((double)this.c());
		l6 l3 = new l6();
		l3.a(new ar7(A_1.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l3.a(x3.c);
		l6 l4 = new l6();
		l4.a(new ar7(A_1.a8()));
		l4.a().c(new List<byte>
		{
			1
		});
		l4.a(x3.c);
		awx2.ad().Add(new bm3(200));
		awx2.ad().Add(l3);
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l4);
		A_2.a(awx, atp.a, true, true);
		A_3.a(awx2, atp.a, true, true);
		aru aru = (A_2.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", this.a(), 1f, c9z.a, false, false);
		}
		if (this.i)
		{
			eym.a(A_2.a8() as c5x, (double)aju.bw);
		}
	}

	// Token: 0x06005A74 RID: 23156 RVA: 0x00270A84 File Offset: 0x0026EC84
	private void a(aud A_0, cd0 A_1, cd0 A_2, ny A_3, ny A_4)
	{
		awx awx = new awx("close");
		awx.a(m7.b | m7.k);
		clw clw = new clw();
		clw.a(new e6z(A_0));
		clw.a(true);
		if (A_2.a == "Doors\\SplitGateHSegmentsR")
		{
			clw.a(Axis.X);
			clw.a().Add(A_2.a8().Location.a());
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 1), false));
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 2), false));
		}
		else
		{
			clw.a(Axis.Y);
			clw.a().Add(A_2.a8().Location.a());
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(1, 0), false));
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(2, 0), false));
		}
		clw.e().Add(A_1.a8().qe());
		clw.e().Add(A_2.a8().qe());
		dqm dqm = new dqm(A_1);
		dqm.c(A_1.b.X);
		dqm.a(false);
		dqm.b(A_1.b.X);
		dqm.a(-1);
		dqm.a((double)this.c());
		l6 l = new l6();
		l.a(new ar7(A_1.a8()));
		l.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l.a(x3.b);
		l6 l2 = new l6();
		l2.a(new ar7(A_1.a8()));
		l2.a().c(new List<byte>
		{
			1
		});
		l2.a(x3.b);
		awx.ad().Add(new bm3(250));
		awx.ad().Add(l2);
		awx.ad().Add(dqm);
		awx.ad().Add(l);
		awx.ad().Add(clw);
		awx awx2 = new awx("close");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_2);
		dqm2.c(A_2.b.X);
		dqm2.a(false);
		dqm2.b(A_2.b.X);
		dqm2.a(-1);
		dqm2.a((double)this.c());
		l6 l3 = new l6();
		l3.a(new ar7(A_2.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l3.a(x3.b);
		l6 l4 = new l6();
		l4.a(new ar7(A_2.a8()));
		l4.a().c(new List<byte>
		{
			1
		});
		l4.a(x3.b);
		awx2.ad().Add(new bm3(250));
		awx2.ad().Add(l4);
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l3);
		A_3.a(awx, atp.a, true, true);
		A_4.a(awx2, atp.a, true, true);
		aru aru = (A_3.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", this.b(), 1f, c9z.a, false, false);
		}
		if (this.i)
		{
			eym.a(A_3.a8() as c5x, (double)aju.bw);
		}
	}

	// Token: 0x04002432 RID: 9266
	private new Guid a;

	// Token: 0x04002433 RID: 9267
	private Guid b;

	// Token: 0x04002434 RID: 9268
	private string c;

	// Token: 0x04002435 RID: 9269
	private bbo d;

	// Token: 0x04002436 RID: 9270
	private int? e;

	// Token: 0x04002437 RID: 9271
	private int? f;

	// Token: 0x04002438 RID: 9272
	private string g;

	// Token: 0x04002439 RID: 9273
	private string h;

	// Token: 0x0400243A RID: 9274
	private bool i;
}
