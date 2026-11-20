using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000951 RID: 2385
[eiz("FOMABD")]
[Serializable]
public sealed class cod : bdw, ISerializable
{
	// Token: 0x06003A3D RID: 14909 RVA: 0x00158D34 File Offset: 0x00156F34
	private cod(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x00158D3C File Offset: 0x00156F3C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x00158D40 File Offset: 0x00156F40
	public cod()
	{
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x00158D4C File Offset: 0x00156F4C
	public void av(c1a A_0, cyt A_1)
	{
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom1_minersReturned", new bool?(false)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom2_minersReturned", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom3_minersReturned", new bool?(false)).Value;
		bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom4_minersReturned", new bool?(false)).Value;
		bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom5_minersReturned", new bool?(false)).Value;
		bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom6_minersReturned", new bool?(false)).Value;
		bool value8 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom7_minersReturned", new bool?(false)).Value;
		bool value9 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fom8_minersReturned", new bool?(false)).Value;
		bool value10 = A_1.r().GetPrimitivePropertyValue<bool>("loc_crys1_minersReturned", new bool?(false)).Value;
		bool value11 = A_1.r().GetPrimitivePropertyValue<bool>("loc_crys2_minersReturned", new bool?(false)).Value;
		dat dat = new dat();
		if (A_0 != null && value)
		{
			if (A_0.y8() == "fom1" && !value2)
			{
				c5x c5x = new ar7(new Guid("2acef4b9-d31f-4756-80a5-8926ff38cddb"), A_0.n("fom1")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("33010a2d-d125-4163-962c-9f41eeef77ea"), A_0.n("fom1")).ao() as c5x;
				if (c5x != null)
				{
					c5x.an();
					c5x.w();
				}
				else
				{
					A_1.r()["loc_fom1_marcosDead"] = true;
				}
				if (c5x2 != null)
				{
					c5x2.an();
					c5x2.w();
				}
				A_1.r()["loc_fom1_minersReturned"] = true;
			}
			if (A_0.y8() == "fom2" && !value3)
			{
				this.a(A_0, A_1, value3);
			}
			if (A_0.y8() == "fom3" && !value4)
			{
				this.a(A_0, A_1, value4);
			}
			if (A_0.y8() == "fom4" && !value5)
			{
				this.a(A_0, A_1, value5);
			}
			if (A_0.y8() == "fom5" && !value6)
			{
				this.a(A_0, A_1, value6);
			}
			if (A_0.y8() == "fom6" && !value7)
			{
				this.a(A_0, A_1, value7);
			}
			if (A_0.y8() == "fom7" && !value8)
			{
				this.a(A_0, A_1, value8);
			}
			if (A_0.y8() == "fom8" && !value9)
			{
				this.a(A_0, A_1, value9);
			}
			if (A_0.y8() == "crys1" && !value10)
			{
				this.a(A_0, A_1, value10);
				dat.ym(null, null, null);
			}
			if (A_0.y8() == "crys2" && !value11)
			{
				this.a(A_0, A_1, value11);
				dat.ym(null, null, null);
			}
		}
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x001590F8 File Offset: 0x001572F8
	private void a(c1a A_0, cyt A_1, bool A_2)
	{
		foreach (aud aud in A_0.Areas)
		{
			e5g.b(aud);
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && (c5x.h.b.am() == "borer" || c5x.h.b.aa().FactionId == "bladelings"))
				{
					c5x.an();
					c5x.w();
				}
				else if (c5x != null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
				{
					c5x.an();
					c5x.w();
				}
				else if (c5x != null && c5x.y8() != "Обломки" && (c5x.s.b is c7j || (c5x.s.b != null && (c5x.y8() == "TNT" || c5x.y8() == "Отбойный молоток"))))
				{
					c3g c3g = c5x.GetAspect<c3g>();
					if (c3g == null)
					{
						c3g = new c3g(c5x);
						c5x.SetAspect<c3g>(c3g);
					}
					c3g.d().Clear();
					c3g.d().Add(asp.cz);
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					if (c7j != null)
					{
						c7j.ContainerProtectionMode = ctz.c;
					}
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null)
					{
						aspect.a(d1c.b);
					}
				}
			}
		}
		doq a_ = doq.a(Path.Combine(d5x.q(), A_0.y8() + "_l2") + ".uzl");
		A_0.a(a_, 1, null);
		bpo.GetServiceOrThrow<d02>();
		A_1.r()["loc_" + A_0.y8() + "_minersReturned"] = true;
	}
}
