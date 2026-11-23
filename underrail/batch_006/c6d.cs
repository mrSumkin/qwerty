using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C7A RID: 3194
[eiz("DNMEDE")]
[Serializable]
public sealed class c6d : cd2
{
	// Token: 0x06004817 RID: 18455 RVA: 0x001D9324 File Offset: 0x001D7524
	private c6d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x001D9330 File Offset: 0x001D7530
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x001D933C File Offset: 0x001D753C
	public override TimeSpan ge()
	{
		return TimeSpan.FromSeconds(3.0);
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x001D934C File Offset: 0x001D754C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x001D935C File Offset: 0x001D755C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x001D936C File Offset: 0x001D756C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x001D937C File Offset: 0x001D757C
	public c6d() : base(c6d.a)
	{
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x001D938C File Offset: 0x001D758C
	protected override bool ez(cyt A_0)
	{
		if (base.ez(A_0))
		{
			List<string> list = new List<string>
			{
				"D5",
				"D6",
				"E5",
				"E6"
			};
			string text = e3m.a();
			return text == null || !list.Contains(text);
		}
		return false;
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x001D93F4 File Offset: 0x001D75F4
	protected override void gg(cyt A_0)
	{
		dtb dtb = new dtb();
		List<auv> list = dtb.ad();
		bfq bfq = new bfq();
		bfq.a(bvl.c);
		bfq.b("explosion1");
		bfq.c("DistantExplosion1");
		bfq.a(c9z.a);
		bfq.a(true);
		bfq.a(0.8f);
		list.Add(new a4s(bfq, null, new ar7(A_0.v().b()), null));
		dtb.ad().Add(new bm3(2500));
		List<auv> list2 = dtb.ad();
		bfq bfq2 = new bfq();
		bfq2.a(bvl.c);
		bfq2.b("explosion2");
		bfq2.c("DistantExplosion2");
		bfq2.a(c9z.a);
		bfq2.a(true);
		bfq2.a(1f);
		list2.Add(new a4s(bfq2, null, new ar7(A_0.v().b()), null));
		dtb.ad().Add(new bm3(150));
		List<auv> list3 = dtb.ad();
		bfq bfq3 = new bfq();
		bfq3.a(bvl.c);
		bfq3.b("explosion3");
		bfq3.c("WaterSplashGiant");
		bfq3.a(c9z.a);
		bfq3.a(true);
		bfq3.a(0.02f);
		list3.Add(new a4s(bfq3, null, new ar7(A_0.v().b()), null));
		dtb.ad().Add(new bm3(1400));
		List<auv> list4 = dtb.ad();
		bfq bfq4 = new bfq();
		bfq4.a(bvl.c);
		bfq4.b("explosion4");
		bfq4.c("DistantExplosion2");
		bfq4.a(c9z.a);
		bfq4.a(true);
		bfq4.a(0.8f);
		list4.Add(new a4s(bfq4, null, new ar7(A_0.v().b()), null));
		dtb.ad().Add(new bm3(3300));
		List<auv> list5 = dtb.ad();
		bfq bfq5 = new bfq();
		bfq5.a(bvl.c);
		bfq5.b("explosion5");
		bfq5.c("DistantExplosion1");
		bfq5.a(c9z.a);
		bfq5.a(true);
		bfq5.a(0.8f);
		list5.Add(new a4s(bfq5, null, new ar7(A_0.v().b()), null));
		dtb.ad().Add(new bm3(350));
		List<auv> list6 = dtb.ad();
		bfq bfq6 = new bfq();
		bfq6.a(bvl.c);
		bfq6.b("explosion6");
		bfq6.c("WaterSplashGiant");
		bfq6.a(c9z.a);
		bfq6.a(true);
		bfq6.a(0.05f);
		list6.Add(new a4s(bfq6, null, new ar7(A_0.v().b()), null));
		A_0.v().b().Zone.ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x04001CAC RID: 7340
	public new static readonly string a = "distantNavalMineExplosion";
}
