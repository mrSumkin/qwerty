using System;
using System.IO;

// Token: 0x0200188C RID: 6284
public sealed class cvr : btm
{
	// Token: 0x0600855F RID: 34143 RVA: 0x003762C8 File Offset: 0x003744C8
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<cnk>().ara();
		return true;
	}

	// Token: 0x06008560 RID: 34144 RVA: 0x003762D8 File Offset: 0x003744D8
	public static void a()
	{
		bbp serviceOrThrow = bpo.GetServiceOrThrow<bbp>();
		serviceOrThrow.kv("Initializing UI");
		bl9.e();
		serviceOrThrow.kv("Preloading icons");
		ejh.c();
		serviceOrThrow.kv("Initializing item definitions");
		ez2.a();
		serviceOrThrow.kv("Initializing playfield manager");
		d6j serviceOrThrow2 = bpo.GetServiceOrThrow<d6j>();
		serviceOrThrow2.dv().d(d5x.ae);
		serviceOrThrow.kv("Loading playfield prototypes");
		serviceOrThrow2.dv().b();
		eve service = bpo.GetService<eve>();
		if (service != null)
		{
			service.y2(Path.Combine(dr3.d().lf(), d5x.am));
		}
		serviceOrThrow.kv("Importing quests");
		b4m.a();
		dd7 serviceOrThrow3 = bpo.GetServiceOrThrow<dd7>();
		serviceOrThrow.kv("Loading audio bank");
		serviceOrThrow3.ad4(Path.Combine(dr3.d().lf(), bo1.b2));
		serviceOrThrow.kv("Initializing audio manager");
		bpo.RegisterService<am7>(new c4m());
		serviceOrThrow.kv("Loading global entity provider manager");
		cap.a();
		serviceOrThrow.kv("Loading global map");
		eeo eeo = new eeo();
		bpo.RegisterService<e5f>(eeo);
		eeo.c();
		serviceOrThrow.kv("Loading random fragments");
		a4i.d();
		serviceOrThrow.kv("Initializing console");
		bdg.c();
		serviceOrThrow.kv("Initializing item randomizer library");
		bbf bbf = new bbf();
		bpo.RegisterService<btu>(bbf);
		bbf.a();
		serviceOrThrow.kv("Boom!");
	}

	// Token: 0x06008561 RID: 34145 RVA: 0x00376438 File Offset: 0x00374638
	public cvr() : base(null)
	{
	}
}
