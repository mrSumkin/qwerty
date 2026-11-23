using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A9 RID: 4265
[eiz("OMTGJ")]
[Serializable]
public sealed class egn : cze, ISerializable
{
	// Token: 0x0600597F RID: 22911 RVA: 0x0026A6D0 File Offset: 0x002688D0
	private egn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid)A_0.GetValue("OMTGJ:L", typeof(Guid));
		this.d = (Guid)A_0.GetValue("OMTGJ:R", typeof(Guid));
		this.e = A_0.GetString("OMTGJ:A");
		this.f = (bbo)A_0.GetValue("OMTGJ:O", typeof(bbo));
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x0026A758 File Offset: 0x00268958
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OMTGJ:L", this.c);
		info.AddValue("OMTGJ:R", this.d);
		info.AddValue("OMTGJ:A", this.e);
		info.AddValue("OMTGJ:O", this.f);
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x0026A7C0 File Offset: 0x002689C0
	public Guid b()
	{
		return this.c;
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x0026A7C8 File Offset: 0x002689C8
	public void b(Guid A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x0026A7D4 File Offset: 0x002689D4
	public Guid a()
	{
		return this.d;
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x0026A7DC File Offset: 0x002689DC
	public void a(Guid A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x0026A7E8 File Offset: 0x002689E8
	public string c()
	{
		return this.e;
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x0026A7F0 File Offset: 0x002689F0
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x0026A7FC File Offset: 0x002689FC
	public bbo d()
	{
		return this.f;
	}

	// Token: 0x06005988 RID: 22920 RVA: 0x0026A804 File Offset: 0x00268A04
	public void a(bbo A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x0026A810 File Offset: 0x00268A10
	public egn()
	{
	}

	// Token: 0x0600598A RID: 22922 RVA: 0x0026A818 File Offset: 0x00268A18
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
			if (string.IsNullOrWhiteSpace(this.e))
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
			aud = c1a.n(this.e);
		}
		if (aud == null)
		{
			return;
		}
		ar7 ar = new ar7(this.c, aud);
		ar7 ar2 = new ar7(this.d, aud);
		if (ar.ao() != null && ar2.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			cd0 aspect2 = ar2.ao().GetAspect<cd0>();
			ny aspect3 = ar.ao().GetAspect<ny>();
			ny aspect4 = ar2.ao().GetAspect<ny>();
			if (aspect != null && aspect2 != null && aspect3 != null && aspect4 != null)
			{
				if (this.f == bbo.b)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "open")
						{
							egn.a(aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 5)
					{
						egn.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (this.f == bbo.c)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "close")
						{
							egn.a(aud, aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 0)
					{
						egn.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (aspect3.a() != null)
				{
					if (aspect3.a().Name == "open")
					{
						egn.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
					egn.a(aspect, aspect2, aspect3, aspect4);
					return;
				}
				else
				{
					if (aspect.b.X < 3)
					{
						egn.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
					egn.a(aud, aspect, aspect2, aspect3, aspect4);
				}
			}
		}
	}

	// Token: 0x0600598B RID: 22923 RVA: 0x0026AAB4 File Offset: 0x00268CB4
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		Guid guid = this.c;
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
			if (string.IsNullOrWhiteSpace(this.e))
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
			aud = c1a.n(this.e);
		}
		if (aud == null)
		{
			return false;
		}
		ar7 ar = new ar7(this.c, aud);
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

	// Token: 0x0600598C RID: 22924 RVA: 0x0026AC18 File Offset: 0x00268E18
	private static void a(cd0 A_0, cd0 A_1, ny A_2, ny A_3)
	{
		awx awx = new awx("open");
		awx.a(m7.b | m7.k);
		dqm dqm = new dqm(A_0);
		dqm.c(5 - A_0.b.X);
		dqm.a(true);
		dqm.b(A_0.b.X);
		dqm.a(1);
		dqm.a(300.0);
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
		awx.ad().Add(dqm);
		awx.ad().Add(l2);
		awx awx2 = new awx("open");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_1);
		dqm2.c(5 - A_1.b.X);
		dqm2.a(true);
		dqm2.b(A_1.b.X);
		dqm2.a(1);
		dqm2.a(300.0);
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
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l4);
		A_2.a(awx, atp.a, true, true);
		A_3.a(awx2, atp.a, true, true);
		aru aru = (A_2.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", "LargeDoor", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x0600598D RID: 22925 RVA: 0x0026AEA4 File Offset: 0x002690A4
	private static void a(aud A_0, cd0 A_1, cd0 A_2, ny A_3, ny A_4)
	{
		awx awx = new awx("close");
		awx.a(m7.b | m7.k);
		dqm dqm = new dqm(A_1);
		dqm.c(A_1.b.X);
		dqm.a(false);
		dqm.b(A_1.b.X);
		dqm.a(-1);
		dqm.a(300.0);
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
		awx.ad().Add(dqm);
		awx.ad().Add(l);
		awx awx2 = new awx("close");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_2);
		dqm2.c(A_2.b.X);
		dqm2.a(false);
		dqm2.b(A_2.b.X);
		dqm2.a(-1);
		dqm2.a(300.0);
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
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l3);
		A_3.a(awx, atp.a, true, true);
		A_4.a(awx2, atp.a, true, true);
		aru aru = (A_3.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", "LargeDoor", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x040023F4 RID: 9204
	private new const int a = 300;

	// Token: 0x040023F5 RID: 9205
	private const int b = 6;

	// Token: 0x040023F6 RID: 9206
	private Guid c;

	// Token: 0x040023F7 RID: 9207
	private Guid d;

	// Token: 0x040023F8 RID: 9208
	private string e;

	// Token: 0x040023F9 RID: 9209
	private bbo f;
}
