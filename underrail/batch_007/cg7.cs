using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A64 RID: 2660
[eiz("SLPGSJ")]
[Serializable]
public sealed class cg7 : cze, ISerializable
{
	// Token: 0x06003ED2 RID: 16082 RVA: 0x0017B914 File Offset: 0x00179B14
	private cg7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SLPGSJ:S");
		this.b = (Guid)A_0.GetValue("SLPGSJ:G", typeof(Guid));
		this.c = (Guid)A_0.GetValue("SLPGSJ:C", typeof(Guid));
	}

	// Token: 0x06003ED3 RID: 16083 RVA: 0x0017B97C File Offset: 0x00179B7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLPGSJ:S", this.a);
		info.AddValue("SLPGSJ:G", this.b);
		info.AddValue("SLPGSJ:C", this.c);
	}

	// Token: 0x06003ED4 RID: 16084 RVA: 0x0017B9D0 File Offset: 0x00179BD0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06003ED5 RID: 16085 RVA: 0x0017B9D8 File Offset: 0x00179BD8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x0017B9E4 File Offset: 0x00179BE4
	public Guid a()
	{
		return this.b;
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x0017B9EC File Offset: 0x00179BEC
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003ED8 RID: 16088 RVA: 0x0017B9F8 File Offset: 0x00179BF8
	public Guid c()
	{
		return this.c;
	}

	// Token: 0x06003ED9 RID: 16089 RVA: 0x0017BA00 File Offset: 0x00179C00
	public void b(Guid A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06003EDA RID: 16090 RVA: 0x0017BA0C File Offset: 0x00179C0C
	public cg7()
	{
	}

	// Token: 0x06003EDB RID: 16091 RVA: 0x0017BA18 File Offset: 0x00179C18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = this.a(A_0, A_1);
		if (aud != null)
		{
			c5x c5x = this.a(aud, new Guid?(this.b));
			c5x c5x2 = this.a(aud, new Guid?(this.c));
			if (c5x2 != null && c5x != null && c5x.p.b != null && c5x.p.b.a.Count == 2 && c5x2.p.b != null && c5x2.p.b.a.Count == 3)
			{
				ny ny = c5x.i.b;
				if (ny != null)
				{
					if (ny.a() != null)
					{
						c5x c5x3 = A_1 as c5x;
						if (c5x3 != null)
						{
							c5x3.c().a("xpbl_LemurianGeneratorError");
						}
						return;
					}
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | (m7.b | m7.k));
					if (this.a)
					{
						c5x.p.b.a[0].b = new Point(0, 1);
						c5x.p.b.a[1].d = null;
						c5x2.p.b.a[1].d = null;
						c5x2.p.b.a[2].d = new float?(0.75f);
						bfq bfq = new bfq();
						bfq.b("expand");
						bfq.c("PowerGenConductorLift");
						bfq.a(0.6f);
						awx.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
						ddg ddg = new ddg(c5x2.p.b);
						ddg.c(3);
						ddg.a(250.0);
						ddg.a(true);
						awx.ad().Add(ddg);
						bfq bfq2 = new bfq();
						bfq2.b("humming");
						bfq2.c("PowerGenConductorHumming");
						bfq2.d(true);
						bfq2.a(0.2f);
						bfq2.a(c9z.b);
						awx.ad().Add(new a4s(bfq2, null, new ar7(c5x2), null));
						List<auv> list = awx.ad();
						bi5 bi = new bi5();
						bi.a(new int?(0));
						bi.a(new float?(0.9f));
						bi.a(true);
						a4s a4s = new a4s(bi, null, null, null);
						a4s.b(new ar7(c5x2));
						list.Add(a4s);
						List<auv> list2 = awx.ad();
						a4s a4s2 = new a4s(new eb7(new Guid?(this.b), true), null, null, null);
						a4s2.b(new ar7(c5x));
						list2.Add(a4s2);
					}
					else
					{
						List<auv> list3 = awx.ad();
						a4s a4s3 = new a4s(new eb7(new Guid?(this.b), false), null, null, null);
						a4s3.b(new ar7(c5x));
						list3.Add(a4s3);
						List<auv> list4 = awx.ad();
						bi5 bi2 = new bi5();
						bi2.a(new int?(0));
						bi2.a(new float?(0f));
						bi2.a(true);
						a4s a4s4 = new a4s(bi2, null, null, null);
						a4s4.b(new ar7(c5x2));
						list4.Add(a4s4);
						b18 b = new b18();
						b.b("humming");
						awx.ad().Add(new a4s(b, null, new ar7(c5x2), null));
						bfq bfq3 = new bfq();
						bfq3.b("expand");
						bfq3.c("PowerGenConductorLift");
						bfq3.a(0.6f);
						awx.ad().Add(new a4s(bfq3, null, new ar7(c5x), null));
						ddg ddg2 = new ddg(c5x2.p.b);
						ddg2.b(3);
						ddg2.c(3);
						ddg2.a(-1);
						ddg2.a(250.0);
						ddg2.a(false);
						awx.ad().Add(ddg2);
						List<auv> list5 = awx.ad();
						bi5 bi3 = new bi5();
						bi3.a(new int?(0));
						bi3.a(0);
						bi3.c(true);
						a4s a4s5 = new a4s(bi3, null, null, null);
						a4s5.b(new ar7(c5x));
						list5.Add(a4s5);
						List<auv> list6 = awx.ad();
						bi5 bi4 = new bi5();
						bi4.a(new int?(1));
						bi4.a(new float?(0f));
						bi4.a(true);
						a4s a4s6 = new a4s(bi4, null, null, null);
						a4s6.b(new ar7(c5x));
						list6.Add(a4s6);
						List<auv> list7 = awx.ad();
						bi5 bi5 = new bi5();
						bi5.a(new int?(1));
						bi5.a(new float?(0f));
						bi5.a(true);
						a4s a4s7 = new a4s(bi5, null, null, null);
						a4s7.b(new ar7(c5x2));
						list7.Add(a4s7);
						List<auv> list8 = awx.ad();
						bi5 bi6 = new bi5();
						bi6.a(new int?(2));
						bi6.a(new float?(0f));
						bi6.a(true);
						a4s a4s8 = new a4s(bi6, null, null, null);
						a4s8.b(new ar7(c5x2));
						list8.Add(a4s8);
					}
					ny.b(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x06003EDC RID: 16092 RVA: 0x0017BF60 File Offset: 0x0017A160
	private aud a(b0b A_0, b0b A_1)
	{
		aud aud = null;
		if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud == null && A_0 != null)
		{
			aud = A_0.Area;
		}
		return aud;
	}

	// Token: 0x06003EDD RID: 16093 RVA: 0x0017BF90 File Offset: 0x0017A190
	private c5x a(aud A_0, Guid? A_1)
	{
		if (A_1 != null)
		{
			return new ar7(A_1.Value, A_0).ao() as c5x;
		}
		return null;
	}

	// Token: 0x04001BCA RID: 7114
	private new bool a;

	// Token: 0x04001BCB RID: 7115
	private Guid b;

	// Token: 0x04001BCC RID: 7116
	private Guid c;
}
