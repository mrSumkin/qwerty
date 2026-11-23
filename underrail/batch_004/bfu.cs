using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000950 RID: 2384
[eiz("FLSSGAW")]
[Serializable]
public sealed class bfu : bdw, ISerializable
{
	// Token: 0x06003A37 RID: 14903 RVA: 0x0015843C File Offset: 0x0015663C
	private bfu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x00158444 File Offset: 0x00156644
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x00158448 File Offset: 0x00156648
	public bfu()
	{
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x00158454 File Offset: 0x00156654
	public void av(c1a A_0, cyt A_1)
	{
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("talkToBretForRoundupStart", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp1Patched", new bool?(false)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp2Patched", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp3Patched", new bool?(false)).Value;
		bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp4Patched", new bool?(false)).Value;
		bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp5Patched", new bool?(false)).Value;
		bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fls_otp6Patched", new bool?(false)).Value;
		if (A_0 != null && value)
		{
			if (A_0.y8() == "ForlornStations1")
			{
				c5x c5x = new ar7(new Guid("d5f98dd3-e5d0-43d1-b0e9-1686f584e8c7"), A_0.n("ForlornStations1")).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("4fea1864-0cfd-4492-b215-a12caba31c75"), A_0.n("ForlornStations1")).ao() as c5x;
				if (c5x != null && c5x.o.b != null && c5x.o.b.b.X == 1 && !value2)
				{
					this.a(A_0, A_1, "loc_fls_otp1Patched");
					this.a(A_0, "guard1Outpost1", false, true, "mt");
				}
				if (c5x2 != null && c5x2.o.b != null && c5x2.o.b.b.X == 1 && !value3)
				{
					this.a(A_0, A_1, "loc_fls_otp2Patched");
					this.a(A_0, "guard1Outpost2", false, true, "mt_f");
					this.a(A_0, "worker1Outpost2", false, false, "wrk2");
				}
			}
			if (A_0.y8() == "ForlornStations2")
			{
				if (!value4)
				{
					this.a(A_0, A_1, "loc_fls_otp3Patched");
					this.a(A_0, "guard1Outpost3", false, true, "mt");
					this.a(A_0, "worker1Outpost3", false, false, "wrk1");
				}
				c5x c5x3 = new ar7(new Guid("e0b0734d-f9dd-4939-9beb-03e5a61b22c4"), A_0.n("ForlornStations2")).ao() as c5x;
				if (c5x3 != null && c5x3.o.b != null && c5x3.o.b.b.X == 1 && !value5)
				{
					this.a(A_0, A_1, "loc_fls_otp4Patched");
					this.a(A_0, "guard1Outpost4", true, true, "mt");
				}
			}
			if (A_0.y8() == "ForlornStations3")
			{
				c5x c5x4 = new ar7(new Guid("5f404039-c346-45ce-8bf9-f172b37fad2e"), A_0.n("ForlornStations3")).ao() as c5x;
				if (c5x4 != null && c5x4.o.b != null && c5x4.o.b.b.X == 1 && !value6)
				{
					this.a(A_0, A_1, "loc_fls_otp5Patched");
					this.a(A_0, "guard1Outpost5", false, true, "mt_f");
				}
			}
			if (A_0.y8() == "ForlornStations4")
			{
				c5x c5x5 = new ar7(new Guid("160b2620-03e4-40fe-acf7-72989382ac4b"), A_0.n("ForlornStations4")).ao() as c5x;
				if (c5x5 != null && c5x5.o.b != null && c5x5.o.b.b.X == 1 && !value7)
				{
					this.a(A_0, A_1, "loc_fls_otp6Patched");
					this.a(A_0, "guard1Outpost6", false, true, "mt_f");
					this.a(A_0, "guard2Outpost6", false, true, "mt");
					this.a(A_0, "worker1Outpost6", false, false, "wrk2");
				}
			}
		}
	}

	// Token: 0x06003A3B RID: 14907 RVA: 0x00158894 File Offset: 0x00156A94
	private void a(c1a A_0, cyt A_1, string A_2)
	{
		bpo.GetServiceOrThrow<d02>();
		foreach (aud aud in A_0.Areas)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == "rathoundPack")
				{
					c5x.an();
					c5x.w();
				}
				else if (c5x != null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
				{
					c5x.an();
					c5x.w();
				}
				else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
				{
					c5x.w();
					c5x.an();
				}
				else if (c5x != null && c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
				{
					c5x.an();
					c5x.w();
				}
			}
		}
		A_1.r()[A_2] = true;
	}

	// Token: 0x06003A3C RID: 14908 RVA: 0x00158A90 File Offset: 0x00156C90
	private void a(c1a A_0, string A_1, bool A_2, bool A_3, string A_4)
	{
		csd a_ = A_0.g(A_1);
		if (A_3)
		{
			c5x c5x = vq.a("creatures\\generichumans\\sgsheavyassaultriflesentry", a_, false);
			if (c5x != null)
			{
				if (c5x.h.b != null)
				{
					if (A_4.Contains("_f"))
					{
						c5x.h.b.aa().Gender = Gender.Female;
					}
					c5x.h.b.a(A_4);
				}
				if (c5x.t.b != null)
				{
					if (!A_2)
					{
						c5x.t.b.y6()[ddq.ay] = new bt4(A_1);
					}
					else
					{
						c5x.t.b.y6()[ddq.k] = new List<string>
						{
							"pa1",
							"pa2"
						};
						c5x.t.b.y6()[ddq.l] = 30000;
						c5x.t.b.y6()[ddq.n] = true;
					}
				}
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn == null)
				{
					bn = new bn5(c5x);
					c5x.SetAspect<j7>(bn);
				}
				if (bn != null)
				{
					bn.a("speaker");
					bn.b("support\\sgs_fls_g");
					bn.b(true);
					if (A_2)
					{
						bn.a(false);
						return;
					}
				}
			}
		}
		else
		{
			c5x c5x2 = vq.a("creatures\\generichumans\\commoner", a_, false);
			if (c5x2 != null)
			{
				c5x2.q("Рабочий");
				if (c5x2.h.b != null)
				{
					if (A_4.Contains("_f"))
					{
						c5x2.h.b.aa().Gender = Gender.Female;
					}
					c5x2.h.b.a(A_4);
					c5x2.h.b.aa().Name = "Рабочий";
				}
				if (c5x2.t.b != null)
				{
					c5x2.t.b.y6()[ddq.ay] = new bt4(A_1);
					c5x2.t.b.y6()[ddq.w] = CharacterState.Operating;
				}
				bn5 bn2 = c5x2.GetAspect<j7>() as bn5;
				if (bn2 == null)
				{
					bn2 = new bn5(c5x2);
					c5x2.SetAspect<j7>(bn2);
				}
				if (bn2 != null)
				{
					bn2.a(false);
					bn2.a("speaker");
					bn2.b("support\\sgs_fls_w");
					bn2.b(true);
				}
			}
		}
	}
}
