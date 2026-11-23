using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B99 RID: 2969
[eiz("XPBLL12TOMPJ")]
[Serializable]
public sealed class c60 : cze, ISerializable
{
	// Token: 0x06004391 RID: 17297 RVA: 0x001A7B6C File Offset: 0x001A5D6C
	private c60(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004392 RID: 17298 RVA: 0x001A7B78 File Offset: 0x001A5D78
	public c60()
	{
	}

	// Token: 0x06004393 RID: 17299 RVA: 0x001A7B84 File Offset: 0x001A5D84
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = new ar7(new Guid("80a001c0-9892-4549-aa82-6f7c968723f3"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x c5x2 = new ar7(new Guid("3f406eda-73e2-4d01-b199-2bdc12e150a6"), aud).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("cad00903-fa05-44c5-bc1c-93fe9550468b"), aud).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("5a9c0a70-c5f7-4a97-aaf8-48fbd6e49c4e"), aud).ao() as c5x;
					c5x a_ = new ar7(new Guid("d24d5619-46fb-41e3-a268-87c4aed416d6"), aud).ao() as c5x;
					bool flag = true;
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x5 = (c5x)b0b;
						if (c5x5 != null && c5x5.aa)
						{
							c2x aspect = c5x5.GetAspect<c2x>();
							if (aspect != null)
							{
								c2x c2x = aspect;
								bool a_2 = flag;
								if (c2x.a(null, a_2))
								{
									flag = false;
								}
							}
						}
					}
					serviceOrThrow.aqu().r()["loc_xpbl_l12_canUseCameras"] = true;
					dtb dtb = new dtb();
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), true), null, new ar7(c5x), null));
					List<auv> list = dtb.ad();
					ch3 ch = new ch3();
					ch.a(c5x3.Area.y8());
					ch.a(new Guid?(c5x3.qe()));
					ch.a(new float?(0f));
					list.Add(new a4s(ch, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(1000));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), false), null, new ar7(c5x), null));
					List<auv> list2 = dtb.ad();
					ch3 ch2 = new ch3();
					ch2.a(c5x3.Area.y8());
					ch2.a(new Guid?(c5x3.qe()));
					ch2.a(new float?((float)1));
					list2.Add(new a4s(ch2, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(300));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), true), null, new ar7(c5x), null));
					List<auv> list3 = dtb.ad();
					ch3 ch3 = new ch3();
					ch3.a(c5x3.Area.y8());
					ch3.a(new Guid?(c5x3.qe()));
					ch3.a(new float?(0f));
					list3.Add(new a4s(ch3, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(500));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), false), null, new ar7(c5x), null));
					List<auv> list4 = dtb.ad();
					ch3 ch4 = new ch3();
					ch4.a(c5x3.Area.y8());
					ch4.a(new Guid?(c5x3.qe()));
					ch4.a(new float?((float)1));
					list4.Add(new a4s(ch4, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(200));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), true), null, new ar7(c5x), null));
					List<auv> list5 = dtb.ad();
					ch3 ch5 = new ch3();
					ch5.a(c5x3.Area.y8());
					ch5.a(new Guid?(c5x3.qe()));
					ch5.a(new float?(0f));
					list5.Add(new a4s(ch5, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(300));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), false), null, new ar7(c5x), null));
					List<auv> list6 = dtb.ad();
					ch3 ch6 = new ch3();
					ch6.a(c5x3.Area.y8());
					ch6.a(new Guid?(c5x3.qe()));
					ch6.a(new float?((float)1));
					list6.Add(new a4s(ch6, null, new ar7(c5x3), null));
					dtb.ad().Add(new bm3(200));
					dtb.ad().Add(new a4s(new eb7(new Guid?(c5x.qe()), true), null, new ar7(c5x), null));
					List<auv> list7 = dtb.ad();
					ch3 ch7 = new ch3();
					ch7.a(c5x3.Area.y8());
					ch7.a(new Guid?(c5x3.qe()));
					ch7.a(new float?(0f));
					list7.Add(new a4s(ch7, null, new ar7(c5x3), null));
					List<auv> list8 = dtb.ad();
					e2d e2d = new e2d();
					e2d.a(c5x2.Area.y8());
					e2d.a(new Guid?(c5x2.qe()));
					e2d.a(true);
					list8.Add(new a4s(e2d, null, new ar7(c5x2), null));
					List<auv> list9 = dtb.ad();
					e2d e2d2 = new e2d();
					e2d2.a(c5x4.Area.y8());
					e2d2.a(new Guid?(c5x4.qe()));
					e2d2.a(true);
					list9.Add(new a4s(e2d2, null, new ar7(c5x4), null));
					dtb.ad().Add(new bm3(3000));
					List<auv> list10 = dtb.ad();
					bfq bfq = new bfq();
					bfq.a(bvl.c);
					bfq.b("horn");
					bfq.c("xpbl_SavageWarHorn");
					bfq.a(c9z.a);
					bfq.a(true);
					bfq.a(1f);
					list10.Add(new a4s(bfq, null, new ar7(a_), null));
					dtb.ad().Add(new bm3(1000));
					dtb.ad().Add(new a4s(new djm(), null, null, null));
					aud.Zone.ActionManager.g9(dtb, atp.a);
				}
			}
		}
	}
}
