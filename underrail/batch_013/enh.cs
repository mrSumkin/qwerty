using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009D2 RID: 2514
[eiz("RKLSC")]
[Serializable]
public sealed class enh : bdw, ISerializable
{
	// Token: 0x06003C43 RID: 15427 RVA: 0x0016433C File Offset: 0x0016253C
	private enh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x00164344 File Offset: 0x00162544
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x00164348 File Offset: 0x00162548
	public enh()
	{
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x00164354 File Offset: 0x00162554
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				bv.a(asp.cv, asp.a, h.b, null, true, false, false);
				bv.a(asp.cv, asp.cy, h.b, null, false, false, false);
				bv.a(asp.cy, asp.cv, h.e, new h?(h.a), false, false, false);
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_beck_dead", new bool?(false)).Value)
				{
					csd csd = A_0.g("hunter1");
					csd csd2 = A_0.g("hunter2");
					if (csd != null)
					{
						vq.a("creature\\characters\\support\\ch_hunter1", csd, true);
					}
					if (csd2 != null)
					{
						vq.a("creature\\characters\\support\\ch_hunter2", csd2, true);
					}
				}
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("63c0cb7e-3bbb-41fc-a467-32933f07337e")).ao();
				cnb cnb2 = new EntityAspectReference<cnb, bim>(aud, new Guid("5ba0be2c-4dd2-4f60-bab7-758f2f24557d")).ao();
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("63c0cb7e-3bbb-41fc-a467-32933f07337e")).ao();
				d2b d2b2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("5ba0be2c-4dd2-4f60-bab7-758f2f24557d")).ao();
				c3g c3g = new EntityAspectReference<c3g, c3g>(aud, new Guid("63c0cb7e-3bbb-41fc-a467-32933f07337e")).ao();
				if (cnb != null)
				{
					cnb.d(false);
				}
				if (d2b != null)
				{
					if (!d2b.n())
					{
						d2b.e(true);
					}
					List<cze> list = d2b.m();
					eaq eaq = new eaq();
					eaq.a(asp.a);
					eaq.b(asp.cv);
					eaq.a(h.a);
					eaq.a(true);
					list.Add(eaq);
					List<cze> list2 = d2b.q();
					eaq eaq2 = new eaq();
					eaq2.a(asp.a);
					eaq2.b(asp.cv);
					eaq2.a(h.a);
					eaq2.a(true);
					list2.Add(eaq2);
					List<cze> list3 = d2b.m();
					eaq eaq3 = new eaq();
					eaq3.a(asp.a);
					eaq3.b(asp.cy);
					eaq3.a(h.a);
					eaq3.a(true);
					list3.Add(eaq3);
					List<cze> list4 = d2b.q();
					eaq eaq4 = new eaq();
					eaq4.a(asp.a);
					eaq4.b(asp.cy);
					eaq4.a(h.a);
					eaq4.a(true);
					list4.Add(eaq4);
					c4f c4f = new c4f();
					c4f.Properties["loc_rkl2_sarineDoorUnlocked"] = true;
					d2b.m().Add(c4f);
					d2b.q().Add(c4f);
				}
				if (cnb2 != null)
				{
					cnb2.d(false);
				}
				if (d2b2 != null && !d2b2.n())
				{
					d2b2.e(true);
				}
				if (c3g != null)
				{
					c3g.d().Add("campHathor_sarine");
				}
				if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					c5x c5x = new ar7(new Guid("bd2d41ba-a3a7-4880-970e-a9fca148b4fc"), aud).ao() as c5x;
					if (c5x != null)
					{
						c5x.GetAspect<j7>().a(serviceOrThrow.aqu().v().b().GetAspect<j7>(), true, null, false);
					}
				}
			}
		}
	}
}
