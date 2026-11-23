using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009DE RID: 2526
[eiz("EIP0")]
[Serializable]
public sealed class kk : bdw, ISerializable
{
	// Token: 0x06003C74 RID: 15476 RVA: 0x00166320 File Offset: 0x00164520
	private kk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C75 RID: 15477 RVA: 0x00166328 File Offset: 0x00164528
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x0016632C File Offset: 0x0016452C
	public kk()
	{
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x00166338 File Offset: 0x00164538
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null && A_1.v() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqz() != null)
			{
				serviceOrThrow.aqz().atd("jy_getKeycard", true);
				serviceOrThrow.aqz().atd("jy_elwoodBreakIn", true);
				serviceOrThrow.aqz().atd("jy_findWormhole", true);
			}
			bv9 bv = A_1.ac() as bv9;
			bv.a(asp.ac, asp.ab, h.a, null, true, false, false);
			bv.a(asp.a, asp.ab, h.a, null, true, false, false);
			bv.a(asp.af, asp.ab, h.c, null, true, false, false);
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotSgsSupport", new bool?(false)).Value)
			{
				bv.a(asp.f, asp.ab, h.a, null, true, false, false);
				bv.a(asp.f, asp.ac, h.e, new h?(h.a), true, false, false);
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotUSSupport", new bool?(false)).Value)
			{
				bv.a(asp.bh, asp.ab, h.a, null, true, false, false);
				bv.a(asp.bh, asp.ac, h.e, new h?(h.a), true, false, false);
			}
			aud aud = A_0.n("jy6");
			HashSet<Guid> a_ = new HashSet<Guid>();
			if (aud != null)
			{
				for (int i = 0; i <= 12; i++)
				{
					for (int j = 2; j <= 11; j++)
					{
						this.a(aud, i, j, a_);
					}
				}
				for (int k = 7; k <= 11; k++)
				{
					for (int l = 12; l <= 16; l++)
					{
						this.a(aud, k, l, a_);
					}
				}
				c5x c5x = aud.a(new Guid("1f9747df-1865-437a-a1d5-5ef18f04ea60")) as c5x;
				c5x c5x2 = aud.a(new Guid("375adfed-82d9-4932-ab3f-d7bb17fe8efc")) as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && d4n.b.aa().FactionId == asp.n)
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
				doq a_2 = doq.a(Path.Combine(d5x.q(), "jy6_l2") + ".uzl");
				aud.Zone.a(a_2, 1, null);
				for (int m = 1; m <= 4; m++)
				{
					csd csd = A_0.g("invadingEel" + m.ToString());
					if (csd != null)
					{
						c5x c5x3 = vq.a("creature\\characters\\support\\invadingEel" + m.ToString(), csd, true);
						if (c5x3 != null)
						{
							cgh.a(c5x3, "eid" + m.ToString());
						}
					}
				}
				int num = 3;
				string text = null;
				if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotSgsSupport", new bool?(false)).Value)
				{
					text = "sgsSupport";
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotUSSupport", new bool?(false)).Value)
				{
					text = "jyUsSupport";
					num = 4;
				}
				if (text != null)
				{
					for (int n = 1; n <= num; n++)
					{
						csd csd2 = A_0.g("invadingSupport" + n.ToString());
						if (csd2 != null)
						{
							c5x c5x4 = vq.a("creature\\characters\\support\\" + text + n.ToString(), csd2, true);
							if (c5x4 != null)
							{
								cgh.a(c5x4, "sid" + n.ToString());
							}
						}
					}
				}
				bpo.GetServiceOrThrow<b4b>().yr(A_0, A_1.v().c());
			}
		}
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x001667D8 File Offset: 0x001649D8
	private void a(aud A_0, int A_1, int A_2, HashSet<Guid> A_3)
	{
		ak1 ak = A_0.b(A_1, A_2);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
			{
				c5x c5x = (c5x)b0b;
				if (!A_3.Contains(c5x.qe()))
				{
					A_3.Add(c5x.qe());
					if (c5x.Layer == aju.x)
					{
						amc aspect = c5x.GetAspect<amc>();
						if (aspect != null)
						{
							if (aspect.aa().FactionId != asp.f)
							{
								aspect.a(null, false);
							}
						}
						else if (!(c5x.GetAspect<bim>() is c7j))
						{
							c5x.w();
							c5x.an();
						}
					}
				}
			}
		}
	}
}
