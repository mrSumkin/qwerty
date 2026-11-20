using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A06 RID: 2566
[eiz("XPBLPIRAE")]
[Serializable]
public sealed class a39 : bdw, ISerializable
{
	// Token: 0x06003D2D RID: 15661 RVA: 0x0016BE40 File Offset: 0x0016A040
	private a39(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x0016BE48 File Offset: 0x0016A048
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x0016BE4C File Offset: 0x0016A04C
	public a39()
	{
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x0016BE58 File Offset: 0x0016A058
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = null;
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_pir_aegisAttack_whatHappens");
			bool flag = false;
			if (classPropertyValue != null && (classPropertyValue == "spawndie" || classPropertyValue == "spawnstay"))
			{
				flag = true;
			}
			if (A_0.y8() == "xpbl_e3")
			{
				aud = A_0.n("xpbl_e3");
				if (flag)
				{
					this.a(A_0, aud, classPropertyValue);
					return;
				}
			}
			else if (A_0.y8() == "xpbl_f3")
			{
				aud = A_0.n("xpbl_f3");
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_f3_L2_demolitionDebris") + ".uzl");
				aud.Zone.a(a_, 1, null);
				d60 d = A_0.a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"xpbl_f3_remove"
					}))
					{
						if (b0b != null)
						{
							b0b.w();
							b0b.an();
						}
					}
				}
				if (flag)
				{
					this.a(A_0, aud, classPropertyValue);
					return;
				}
			}
			else if (A_0.y8() == "xpbl_g3")
			{
				aud = A_0.n("xpbl_g3");
				if (flag)
				{
					this.a(A_0, aud, classPropertyValue);
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g3_gateOpen", new bool?(false)).Value)
				{
					a8q a8q = new a8q();
					c5x a_2 = new ar7(new Guid("c761478d-2a9e-4752-b176-48d863f6d30c"), aud).ao() as c5x;
					c5x a_3 = new ar7(new Guid("1fbcb996-ce62-473d-8c0f-fdb6b498402a"), aud).ao() as c5x;
					c5x a_4 = new ar7(new Guid("df9a03bc-c39e-47c9-b7b2-8b46ed9aadaf"), aud).ao() as c5x;
					c5x a_5 = new ar7(new Guid("28c3efd3-ed3c-4d73-b2fa-8787efdfc59f"), aud).ao() as c5x;
					a8q.a(a_2);
					a8q.a(a_3);
					a8q.b(a_4);
					a8q.b(a_5);
					a8q.a(true, aud);
					a8q.a(aud);
				}
			}
		}
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x0016C0BC File Offset: 0x0016A2BC
	private void a(c1a A_0, aud A_1, string A_2)
	{
		gx gx = new gx();
		bool flag = false;
		if (A_2 == "spawndie")
		{
			flag = true;
		}
		if (gx != null && A_1 != null)
		{
			List<csd> list = new List<csd>();
			List<csd> list2 = new List<csd>();
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
			{
				if (csd != null && csd.Name.Contains("_spawned"))
				{
					if (csd.Name.Contains("jet_spawned"))
					{
						list2.Add(csd);
					}
					else
					{
						list.Add(csd);
					}
				}
			}
			foreach (csd csd2 in list)
			{
				if (csd2 != null)
				{
					c5x c5x = gx.a(csd2, new int?(10), "Aegis", null, null, null, "support\\xpbl\\le_aegis", false, null, false);
					if (c5x != null)
					{
						c5x = bh8.b(c5x);
						c5x = bh8.a(c5x);
					}
					if (flag)
					{
						if (c5x.h.b != null)
						{
							if (c5x.h.b.aa().Gear.h().Item != null)
							{
								c5x.h.b.aa().Defense.a(true);
							}
							c5x.h.b.ay().Clear();
						}
						c5x.h.b.aa().a(null, null, false);
					}
					else
					{
						c5x.b("loc_" + A_0.y8() + "_aegisSecTroopers");
					}
				}
			}
			foreach (csd csd3 in list2)
			{
				if (csd3 != null && aw1.a(new bt4(csd3.Name), A_1, l9.b))
				{
					c5x c5x2 = vq.a("object\\vehicles\\xpbl\\aegisPatroller", csd3, true);
					c5x2.b("loc_" + A_0.y8() + "_aegisJets");
					if (c5x2 != null)
					{
						c5x2.VisualDirection = csd3.Direction;
					}
				}
			}
		}
	}
}
