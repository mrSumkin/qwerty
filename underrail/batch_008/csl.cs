using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009AC RID: 2476
[eiz("FOPSB1")]
[Serializable]
public sealed class csl : bdw, ISerializable
{
	// Token: 0x06003BAC RID: 15276 RVA: 0x001612E8 File Offset: 0x0015F4E8
	private csl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x001612F0 File Offset: 0x0015F4F0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x001612F4 File Offset: 0x0015F4F4
	public csl()
	{
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x001612FC File Offset: 0x0015F4FC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("fo_prison");
			if (aud != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_prison_securityBreach", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_prison_securityPreprocessorCompleted", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "fo_prison_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				axh aspect = (new ar7(new Guid("a5f4396c-58bc-4daf-840e-6f3bcda6d9cd"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, false, null);
				}
				axh aspect2 = (new ar7(new Guid("03fc4fd3-aa7c-476b-ab04-a1e7f3b9acc3"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect2 != null)
				{
					aspect2.a(null, true, null);
				}
				c5x c5x = new ar7(new Guid("bceab9e9-4537-42a1-9a3e-2392b5aada24"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("ac8fef67-6f9d-4a9f-855d-cae2b153e4ee"), aud).ao() as c5x;
				Point b = new Point(0, 0);
				if (c5x != null)
				{
					cd0 aspect3 = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					c5x.z();
					if (aspect3 != null)
					{
						aspect3.b = b;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect4 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					c5x2.z();
					if (aspect4 != null)
					{
						aspect4.b = b;
					}
				}
				c5x c5x3 = new ar7(new Guid("24b94c29-2169-4f8e-ab0a-43847d8e529e"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("d521d787-1ff8-4d21-99f7-2d7f9e8d4b8f"), aud).ao() as c5x;
				if (c5x3 != null)
				{
					cd0 aspect5 = c5x3.GetAspect<cd0>();
					c5x3.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					c5x3.z();
					if (aspect5 != null)
					{
						aspect5.b = b;
					}
				}
				if (c5x4 != null)
				{
					cd0 aspect6 = c5x4.GetAspect<cd0>();
					c5x4.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					c5x4.z();
					if (aspect6 != null)
					{
						aspect6.b = b;
					}
				}
				c5x c5x5 = new ar7(new Guid("b5b75e23-d509-4d0c-bf67-98039b69b165"), aud).ao() as c5x;
				new ar7(new Guid("fdf2578e-5173-44ea-a179-cef0ca3ba58f"), aud).ao();
				if (c5x5 != null)
				{
					cnb cnb = c5x5.s.b as cnb;
					if (cnb != null && cnb.q())
					{
						cnb.d(false);
					}
					d2b aspect7 = c5x5.GetAspect<d2b>();
					if (aspect7 != null && !aspect7.n())
					{
						aspect7.b(true, true);
					}
				}
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"fo_prison_speakers"
					});
					if (list != null && list.Count > 0)
					{
						foreach (b0b b0b in list)
						{
							aru aru = ((c5x)b0b).c();
							app app;
							aru.e().TryGetValue("alarm", out app);
							if (app == null)
							{
								aru.a("alarm", "PrisonAlarm", 0.3f, c9z.b, true, false);
							}
						}
					}
				}
				serviceOrThrow.aqu().r()["loc_fo_prison_securityPreprocessorCompleted"] = true;
			}
		}
	}
}
