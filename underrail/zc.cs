using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B30 RID: 2864
[eiz("GMSJ1")]
[Serializable]
public sealed class zc : cze, ISerializable
{
	// Token: 0x06004203 RID: 16899 RVA: 0x00199284 File Offset: 0x00197484
	private zc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00199290 File Offset: 0x00197490
	public zc()
	{
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x0019929C File Offset: 0x0019749C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		aud aud = c5x.Area;
		EntityAspectReference<cnb, bim> entityAspectReference = new EntityAspectReference<cnb, bim>(aud, new Guid("724fb9e0-861b-4cb5-8640-0b0488c1873b"));
		if (entityAspectReference.ao() != null && !entityAspectReference.ao().q())
		{
			entityAspectReference.ao().a(c5x, null, false, false);
		}
		EntityAspectReference<d2b, d2b> entityAspectReference2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("333f670f-c227-4dc3-8881-a2efe6006e8d"));
		if (entityAspectReference2.ao() != null && entityAspectReference2.ao().n())
		{
			entityAspectReference2.ao().a(false, false);
		}
		c5x c5x2 = new ar7(new Guid("93710c5d-93da-4eda-ad7f-9a3e383df839"), aud).ao() as c5x;
		c5x c5x3 = new ar7(new Guid("4eeccca7-07d5-4c58-9d18-0dcb181d6c6a"), aud).ao() as c5x;
		c5x c5x4 = new ar7(new Guid("5bfbfa6b-75fc-4a95-ab43-38af664a9a20"), aud).ao() as c5x;
		if (c5x2 != null)
		{
			c5x2.t.b.y6()[ddq.ay] = new bt4("touringRaiderLoc");
		}
		if (c5x3 != null)
		{
			c5x3.t.b.y6()[ddq.ay] = new bt4("touringChickLoc");
			c5x3.t.b.y6().RemoveProperty(ddq.aw);
		}
		if (c5x4 != null)
		{
			c5x4.t.b.y6()[ddq.ay] = new bt4("hostage1return");
		}
		cno cno = aud.Divinations.a("div1");
		cno cno2 = aud.Divinations.a("div2");
		if (cno != null)
		{
			cno.b(serviceOrThrow.aqu().v().c());
		}
		if (cno2 != null)
		{
			cno2.b(serviceOrThrow.aqu().v().c());
		}
		a0l.a(c5x2, "touringRaiderLoc", true);
		a0l.a(c5x3, "touringChickLoc", true);
		a0l.a(c5x4, "hostage1return", true);
		a0l.a(c5x, "playerVisitLoc", true);
		bpo.GetServiceOrThrow<ps>().amr(true, null, false);
	}
}
