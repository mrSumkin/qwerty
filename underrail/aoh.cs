using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009ED RID: 2541
[eiz("XPBLKL2KLA")]
[Serializable]
public sealed class aoh : bdw, ISerializable
{
	// Token: 0x06003CBC RID: 15548 RVA: 0x00168894 File Offset: 0x00166A94
	private aoh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CBD RID: 15549 RVA: 0x0016889C File Offset: 0x00166A9C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CBE RID: 15550 RVA: 0x001688A0 File Offset: 0x00166AA0
	public aoh()
	{
	}

	// Token: 0x06003CBF RID: 15551 RVA: 0x001688AC File Offset: 0x00166AAC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string a_ = Path.Combine(d5x.q(), "xpbl_kirillLab2_L2") + ".uzl";
		if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_betrayed", new bool?(false)).Value)
		{
			doq a_2 = doq.a(a_);
			if (A_0 != null)
			{
				bq8 bq = serviceOrThrow.aqu().e();
				d60 d = A_0.a();
				if (d != null)
				{
					if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
					{
						A_0.a(a_2, 1, null);
						this.a(false, d, serviceOrThrow);
					}
					else if (!bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value)
					{
						A_0.a(a_2, 1, null);
						this.a(true, d, serviceOrThrow);
						serviceOrThrow.aqu().r()["npc_xpbl_kirillAtLab"] = true;
					}
				}
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					service.ahr();
				}
			}
		}
	}

	// Token: 0x06003CC0 RID: 15552 RVA: 0x00168A60 File Offset: 0x00166C60
	private void a(bool A_0, d60 A_1, cnk A_2)
	{
		List<b0b> list = A_1.ab4(new string[]
		{
			"xpbl_kirillLab2_Mutants"
		});
		if (Enumerable.Count<b0b>(list) > 0)
		{
			A_2.aqu().r()["loc_xpbl_kirillRoastedHunters"] = true;
		}
		if (list != null)
		{
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				a3f a3f = c5x.GetAspect<a3f>();
				if (a3f == null)
				{
					a3f = new a3f(c5x);
					c5x.SetAspect<a3f>(a3f);
				}
				a3f.a()["BloodlessDeath"] = true;
				c5x.h.b.aa().FactionId = asp.gl;
				c5x.h.b.aa().StatusEffects.a(new bk9(c5x.h.b.aa(), 5, 5, false), false, false, false);
				c5x.h.b.aa().a(null, null, false);
			}
		}
		if (A_0)
		{
			list.Clear();
			list = A_1.ab4(new string[]
			{
				"xpbl_mutieHunters"
			});
			foreach (b0b b0b2 in list)
			{
				c5x c5x2 = (c5x)b0b2;
				a3f a3f2 = c5x2.GetAspect<a3f>();
				if (a3f2 == null)
				{
					a3f2 = new a3f(c5x2);
					c5x2.SetAspect<a3f>(a3f2);
				}
				a3f2.a()["BloodlessDeath"] = true;
				ak1 a_ = c5x2.Area.b((int)c5x2.Location.X, (int)c5x2.Location.Y);
				c5x c5x3 = dd5.a(null, a_, (double)cuo.a.Next(1, 4), 2000, true);
				c5x3.SetAspect<e3l>(new e3l(c5x3)
				{
					a = 
					{
						"xpbl_kirill_flames"
					}
				});
				c5x2.h.b.aa().StatusEffects.a(new d0f(0, 0, 0.0), false, false, false);
				c5x2.h.b.aa().a(null, null, false);
			}
			if (Enumerable.Count<b0b>(list) > 0)
			{
				A_2.aqu().r()["loc_xpbl_kirillRoastedHunters"] = true;
			}
		}
	}
}
