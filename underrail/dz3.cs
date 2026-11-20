using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A79 RID: 2681
[eiz("SRBGSJ")]
[Serializable]
public sealed class dz3 : cze, ISerializable
{
	// Token: 0x06003F24 RID: 16164 RVA: 0x0017E250 File Offset: 0x0017C450
	private dz3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SRBGSJ:S");
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x0017E26C File Offset: 0x0017C46C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SRBGSJ:S", this.a);
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x0017E288 File Offset: 0x0017C488
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x0017E290 File Offset: 0x0017C490
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x0017E29C File Offset: 0x0017C49C
	public dz3()
	{
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x0017E2A4 File Offset: 0x0017C4A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.p.b != null && c5x.p.b.a.Count >= 2 && c5x.i.b != null)
		{
			c5x.i.b.a(true, true);
			int x = c5x.p.b.a[0].b.X;
			if (this.a)
			{
				c5x.p.b.a[1].d = null;
				if (x > 0)
				{
					c5x.c().a("movement", false);
					c5x.c().a("movement", "RechargeBayGeneratorMovement", 1f, c9z.a, false, false);
					awx awx = new awx();
					awx.a(m7.b);
					ddg ddg = new ddg(c5x.p.b);
					ddg.b(x);
					ddg.c(x);
					ddg.a(-1);
					ddg.a(250.0);
					ddg.a(true);
					awx.ad().Add(ddg);
					c5x.i.b.b(awx, atp.a);
					return;
				}
			}
			else if (x < 4)
			{
				c5x.c().a("movement", false);
				c5x.c().a("movement", "RechargeBayGeneratorMovement", 1f, c9z.a, false, false);
				awx awx2 = new awx();
				awx2.a(m7.b);
				ddg ddg2 = new ddg(c5x.p.b);
				ddg2.b(x);
				ddg2.c(4 - x);
				ddg2.a(1);
				ddg2.a(250.0);
				ddg2.a(true);
				awx2.ad().Add(ddg2);
				bi5 bi = new bi5();
				bi.a(new int?(1));
				bi.a(new float?(0f));
				bi.a(true);
				a4s a4s = new a4s(bi, null, null, null);
				a4s.b(new ar7(c5x));
				a4s item = a4s;
				awx2.ad().Add(item);
				c5x.i.b.b(awx2, atp.a);
			}
		}
	}

	// Token: 0x04001BD1 RID: 7121
	private new bool a;
}
