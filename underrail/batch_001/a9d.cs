using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;

// Token: 0x020010C3 RID: 4291
[eiz("OTIGJ")]
[Serializable]
public sealed class a9d : cze, ISerializable
{
	// Token: 0x06005A38 RID: 23096 RVA: 0x0026E7B8 File Offset: 0x0026C9B8
	private a9d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = (Guid)A_0.GetValue("OTIGJ:LSEI", typeof(Guid));
		this.f = (Guid)A_0.GetValue("OTIGJ:RSEI", typeof(Guid));
		this.g = A_0.GetString("OTIGJ:AN");
		this.h = (bbo)A_0.GetValue("OTIGJ:O", typeof(bbo));
	}

	// Token: 0x06005A39 RID: 23097 RVA: 0x0026E840 File Offset: 0x0026CA40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OTIGJ:LSEI", this.e);
		info.AddValue("OTIGJ:RSEI", this.f);
		info.AddValue("OTIGJ:AN", this.g);
		info.AddValue("OTIGJ:O", this.h);
	}

	// Token: 0x06005A3A RID: 23098 RVA: 0x0026E8A8 File Offset: 0x0026CAA8
	public Guid b()
	{
		return this.e;
	}

	// Token: 0x06005A3B RID: 23099 RVA: 0x0026E8B0 File Offset: 0x0026CAB0
	public void b(Guid A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005A3C RID: 23100 RVA: 0x0026E8BC File Offset: 0x0026CABC
	public Guid a()
	{
		return this.f;
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x0026E8C4 File Offset: 0x0026CAC4
	public void a(Guid A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x0026E8D0 File Offset: 0x0026CAD0
	public string c()
	{
		return this.g;
	}

	// Token: 0x06005A3F RID: 23103 RVA: 0x0026E8D8 File Offset: 0x0026CAD8
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005A40 RID: 23104 RVA: 0x0026E8E4 File Offset: 0x0026CAE4
	public bbo d()
	{
		return this.h;
	}

	// Token: 0x06005A41 RID: 23105 RVA: 0x0026E8EC File Offset: 0x0026CAEC
	public void a(bbo A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005A42 RID: 23106 RVA: 0x0026E8F8 File Offset: 0x0026CAF8
	public a9d()
	{
	}

	// Token: 0x06005A43 RID: 23107 RVA: 0x0026E900 File Offset: 0x0026CB00
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
			if (string.IsNullOrWhiteSpace(this.g))
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
				return;
			}
			aud = c1a.n(this.g);
		}
		if (aud == null)
		{
			return;
		}
		ar7 ar = new ar7(this.e, aud);
		ar7 ar2 = new ar7(this.f, aud);
		if (ar.ao() != null && ar2.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			cd0 aspect2 = ar2.ao().GetAspect<cd0>();
			ny aspect3 = ar.ao().GetAspect<ny>();
			ny aspect4 = ar2.ao().GetAspect<ny>();
			if (aspect != null && aspect2 != null && aspect3 != null && aspect4 != null)
			{
				if (this.h == bbo.b)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "open")
						{
							a9d.a(aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 14)
					{
						a9d.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (this.h == bbo.c)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "close")
						{
							a9d.a(aud, aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 0)
					{
						a9d.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (aspect3.a() != null)
				{
					if (aspect3.a().Name == "open")
					{
						a9d.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
					a9d.a(aspect, aspect2, aspect3, aspect4);
					return;
				}
				else
				{
					if (aspect.b.X < 7)
					{
						a9d.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
					a9d.a(aud, aspect, aspect2, aspect3, aspect4);
				}
			}
		}
	}

	// Token: 0x06005A44 RID: 23108 RVA: 0x0026EBA0 File Offset: 0x0026CDA0
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		Guid guid = this.e;
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
			if (string.IsNullOrWhiteSpace(this.g))
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
			aud = c1a.n(this.g);
		}
		if (aud == null)
		{
			return false;
		}
		ar7 ar = new ar7(this.e, aud);
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

	// Token: 0x06005A45 RID: 23109 RVA: 0x0026ED04 File Offset: 0x0026CF04
	private static void a(cd0 A_0, cd0 A_1, ny A_2, ny A_3)
	{
		awx awx = new awx("open");
		awx.a(m7.b | m7.k);
		dqm dqm = null;
		if (A_0.b.X < 10)
		{
			dqm = new dqm(A_0);
			dqm.c(10 - A_0.b.X);
			dqm.a(true);
			dqm.b(A_0.b.X);
			dqm.a(1);
			dqm.a(200.0);
		}
		dqm dqm2 = new dqm(A_0);
		dqm2.c(Math.Min(5, 15 - A_0.b.X));
		dqm2.a(true);
		dqm2.b(A_0.b.X + Math.Max(0, 10 - A_0.b.X));
		dqm2.a(1);
		dqm2.a(300.0);
		l6 l = new l6();
		l.a(new ar7(A_0.a8()));
		l.a().c(new List<byte>
		{
			0,
			2
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
		if (dqm != null)
		{
			awx.ad().Add(dqm);
		}
		awx.ad().Add(dqm2);
		awx.ad().Add(l2);
		awx awx2 = new awx("open");
		awx2.a(m7.b | m7.k);
		dqm dqm3 = null;
		if (A_1.b.X < 10)
		{
			dqm3 = new dqm(A_1);
			dqm3.c(10 - A_1.b.X);
			dqm3.a(true);
			dqm3.b(A_1.b.X);
			dqm3.a(1);
			dqm3.a(200.0);
		}
		dqm dqm4 = new dqm(A_1);
		dqm4.c(Math.Min(5, 15 - A_1.b.X));
		dqm4.a(true);
		dqm4.b(A_0.b.X + Math.Max(0, 10 - A_1.b.X));
		dqm4.a(1);
		dqm4.a(300.0);
		l6 l3 = new l6();
		l3.a(new ar7(A_1.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2
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
		if (dqm3 != null)
		{
			awx2.ad().Add(dqm3);
		}
		awx2.ad().Add(dqm4);
		awx2.ad().Add(l4);
		A_2.a(awx, atp.a, true, true);
		A_3.a(awx2, atp.a, true, true);
		if (A_0.b.X == 0)
		{
			aru aru = (A_2.a8() as c5x).c();
			if (aru != null)
			{
				aru.a("open_close", false);
				aru.a("open_close", "TchortDoorOpen", 1f, c9z.a, false, false);
			}
		}
	}

	// Token: 0x06005A46 RID: 23110 RVA: 0x0026F0C4 File Offset: 0x0026D2C4
	private static void a(aud A_0, cd0 A_1, cd0 A_2, ny A_3, ny A_4)
	{
		awx awx = new awx("close");
		awx.a(m7.b | m7.k);
		clw clw = new clw();
		clw.a(new e6z(A_0));
		clw.a(true);
		clw.a(Axis.X);
		clw.a().Add(A_2.a8().Location.a());
		clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 1), false));
		clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 2), false));
		clw.e().Add(A_1.a8().qe());
		clw.e().Add(A_2.a8().qe());
		dqm dqm = null;
		if (A_1.b.X > 10)
		{
			dqm = new dqm(A_1);
			dqm.c(A_1.b.X - 10);
			dqm.a(true);
			dqm.b(A_1.b.X);
			dqm.a(-1);
			dqm.a(300.0);
		}
		dqm dqm2 = new dqm(A_1);
		dqm2.c(Math.Min(10, A_1.b.X));
		dqm2.a(true);
		dqm2.b(Math.Min(10, A_1.b.X));
		dqm2.a(-1);
		dqm2.a(200.0);
		l6 l = new l6();
		l.a(new ar7(A_1.a8()));
		l.a().c(new List<byte>
		{
			0,
			2
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
		if (dqm != null)
		{
			awx.ad().Add(dqm);
		}
		awx.ad().Add(dqm2);
		awx.ad().Add(l);
		awx.ad().Add(clw);
		awx awx2 = new awx("close");
		awx2.a(m7.b | m7.k);
		dqm dqm3 = null;
		if (A_2.b.X > 10)
		{
			dqm3 = new dqm(A_2);
			dqm3.c(A_2.b.X - 10);
			dqm3.a(true);
			dqm3.b(A_2.b.X);
			dqm3.a(-1);
			dqm3.a(300.0);
		}
		dqm dqm4 = new dqm(A_2);
		dqm4.c(Math.Min(10, A_2.b.X));
		dqm4.a(true);
		dqm4.b(Math.Min(10, A_2.b.X));
		dqm4.a(-1);
		dqm4.a(200.0);
		l6 l3 = new l6();
		l3.a(new ar7(A_2.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2
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
		if (dqm3 != null)
		{
			awx2.ad().Add(dqm3);
		}
		awx2.ad().Add(dqm4);
		awx2.ad().Add(l3);
		A_3.a(awx, atp.a, true, true);
		A_4.a(awx2, atp.a, true, true);
		if (A_1.b.X == 15)
		{
			aru aru = (A_3.a8() as c5x).c();
			if (aru != null)
			{
				aru.a("open_close", false);
				aru.a("open_close", "TchortDoorClose", 1f, c9z.a, false, false);
			}
		}
	}

	// Token: 0x04002427 RID: 9255
	private new const int a = 10;

	// Token: 0x04002428 RID: 9256
	private const int b = 200;

	// Token: 0x04002429 RID: 9257
	private const int c = 5;

	// Token: 0x0400242A RID: 9258
	private const int d = 300;

	// Token: 0x0400242B RID: 9259
	private Guid e;

	// Token: 0x0400242C RID: 9260
	private Guid f;

	// Token: 0x0400242D RID: 9261
	private string g;

	// Token: 0x0400242E RID: 9262
	private bbo h;
}
