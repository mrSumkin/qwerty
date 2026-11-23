using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000343 RID: 835
[ajo("Nb")]
public sealed class cn8 : dj4, clp
{
	// Token: 0x060017A0 RID: 6048 RVA: 0x000773E0 File Offset: 0x000755E0
	public void agd(object A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			if (this.b == null)
			{
				this.b = new List<c5x>();
			}
			this.b.Add(c5x);
		}
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0007741C File Offset: 0x0007561C
	public override bool abh()
	{
		return true;
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x00077420 File Offset: 0x00075620
	public override void abi(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00077428 File Offset: 0x00075628
	public override void age(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		this.c = new HashSet<Guid>();
		bm6 bm = A_0 as bm6;
		if (bm != null)
		{
			this.d = new bzv(bm.y6()).a();
			return;
		}
		this.d = new Dictionary<Guid, blk>();
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00077470 File Offset: 0x00075670
	public override void abj(cte A_0, b0b A_1)
	{
		if (A_1 == null || this.c.Contains(A_1.qe()))
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bm6 bm = A_0 as bm6;
		if (bm != null)
		{
			if (bm.a8() == A_1)
			{
				return;
			}
			c5x c5x = A_1 as c5x;
			if (c5x == null)
			{
				return;
			}
			Point a_ = bm.a8().aj().a();
			int num = -1;
			if (bm.a8().h.b != null)
			{
				num = (int)bm.a8().h.b.aa().SightRange;
			}
			if ((int)bnx.a(a_, A_1) > num)
			{
				return;
			}
			if (c5x.h.b != null && c5x.h.b != bm.a8().h.b)
			{
				h h = bm.a8().h.b.aa().a(serviceOrThrow.aqu().ac(), c5x.h.b.aa().FactionId);
				blk blk;
				this.d.TryGetValue(c5x.qe(), out blk);
				if (blk == null)
				{
					blk = new blk(c5x.h.b, h);
					this.d[A_1.qe()] = blk;
				}
				else
				{
					blk.a(h);
					if (blk.e() != null && !blk.e().aa().SpecialStates.g && (bm.a8().h.b == null || (!bm.a8().h.b.aa().SpecialStates.c && !bm.a8().h.b.aa().SpecialStates.j)))
					{
						blk.a().b();
					}
				}
				if (blk.a().f() == cem.d && blk.b() && h != h.a)
				{
					if (c5x.h.b.aa().Vehicle != null && c5x.h.b.aa().Vehicle.l().Count > 0 && c5x.h.b.aa().Vehicle.l().Contains(bm.a8().h.b.aa().FactionId))
					{
						awq.a(bm.a8().h.b, c5x.h.b, false, false, false, false, true, false, false);
					}
					else
					{
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							ar7 classPropertyValue = aspect.a().GetClassPropertyValue<ar7>(bah.c);
							if (classPropertyValue != null && classPropertyValue.ao() != null)
							{
								c3g aspect2 = classPropertyValue.ao().GetAspect<c3g>();
								if (aspect2 != null && aspect2.d().Count > 0 && aspect2.d().Contains(bm.a8().h.b.aa().FactionId))
								{
									awq.a(bm.a8().h.b, c5x.h.b, false, false, false, false, true, false, false);
								}
							}
						}
					}
					if (c5x.i.b != null)
					{
						foreach (cst cst in c5x.i.b.a(m7.m | m7.n))
						{
							ad5 ad = cst as ad5;
							if (ad != null)
							{
								c5x c5x2 = ad.h() as c5x;
								if (c5x2 != null)
								{
									c3g aspect3 = c5x2.GetAspect<c3g>();
									if (!bm.a8().h.b.aa().Passive && aspect3 != null && !aspect3.a(c5x.h.b.aa()) && (aspect3.d().Contains(bm.a8().h.b.aa().FactionId) || aspect3.g().Contains(bm.a8().h.b.aa().Id)))
									{
										awq.a(bm.a8().h.b, c5x.h.b, false, false, false, false, true, false, false);
										break;
									}
								}
							}
						}
					}
				}
				this.c.Add(A_1.qe());
			}
		}
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x00077968 File Offset: 0x00075B68
	public override void agf(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bm6 bm = A_0 as bm6;
		List<Guid> list = new List<Guid>();
		int num = -1;
		Point a_ = bm.a8().aj().a();
		amc amc = null;
		if (bm != null && bm.a8() != null)
		{
			amc = bm.a8().h.b;
		}
		if (amc != null)
		{
			num = (int)bm.a8().h.b.aa().SightRange;
		}
		Dictionary<Guid, blk> dictionary;
		if (this.b != null)
		{
			dictionary = new Dictionary<Guid, blk>();
			using (List<c5x>.Enumerator enumerator = this.b.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c5x c5x = enumerator.Current;
					blk value;
					if (this.d.TryGetValue(c5x.qe(), out value))
					{
						dictionary[c5x.qe()] = value;
					}
				}
				goto IL_EF;
			}
		}
		dictionary = new Dictionary<Guid, blk>(this.d);
		IL_EF:
		foreach (KeyValuePair<Guid, blk> keyValuePair in dictionary)
		{
			if (keyValuePair.Value.e() == null || keyValuePair.Value.e().a8() == null || keyValuePair.Value.e().a8().Area == null || keyValuePair.Value.e().a8().j != cgy.b || keyValuePair.Value.e().a8().Playfield == null || (amc != null && amc.a8() != null && amc.a8().Zone != null && keyValuePair.Value.e().a8().Zone != amc.a8().Zone))
			{
				list.Add(keyValuePair.Key);
			}
			else
			{
				float num2 = bnx.a(a_, keyValuePair.Value.e().a8());
				keyValuePair.Value.a(false);
				double a_2 = keyValuePair.Value.e().a8().l();
				if (this.c.Contains(keyValuePair.Key) && (int)num2 <= num && (amc == null || (!amc.aa().SpecialStates.c && !amc.aa().SpecialStates.j)))
				{
					if (keyValuePair.Value.a().f() == cem.d)
					{
						keyValuePair.Value.a(true);
					}
					if (keyValuePair.Value.b() && amc.aa().FactionId == asp.ct && keyValuePair.Value.e().aa().Gear.l().Item != null && keyValuePair.Value.e().aa().Gear.l().Item.fu().a5() == "rathoundRegalia" && keyValuePair.Value.e().aa().Vehicle == null)
					{
						serviceOrThrow.aqu().ac().aby(amc.aa().FactionId, keyValuePair.Value.e().aa().FactionId, amc.aa().HostilityBroadcastMode, amc.a8().Zone);
					}
					if (!amc.aa().Passive && !keyValuePair.Value.e().aa().Passive && keyValuePair.Value.e().a8().a() && !(keyValuePair.Value.e().aa() is e3q) && bm != null)
					{
						bm6 bm2 = keyValuePair.Value.e().a8().t.b;
						if (bm2 != null)
						{
							bm2.d(amc);
						}
					}
					bool? flag;
					if (amc == null)
					{
						flag = null;
					}
					else
					{
						efk efk = amc.aa();
						flag = ((efk != null) ? new bool?(efk.Truesighted) : null);
					}
					bool? flag2 = flag;
					bool flag3 = flag2.GetValueOrDefault();
					if (flag3 && amc.aa().TruesightRange != null && num2 > amc.aa().TruesightRange.Value)
					{
						flag3 = false;
					}
					if ((amc != null && flag3) || !keyValuePair.Value.e().aa().SpecialStates.g || keyValuePair.Value.a().f() == cem.d || (amc != null && !(amc.aa() is e3q) && bui.a(amc.aa().Detection, keyValuePair.Value.e().aa().Skills.Get<a2n>().g())))
					{
						keyValuePair.Value.a().b();
					}
					else
					{
						double a_3 = bnx.a(amc.a8().Location.b(), amc.a8().VisualDirection, keyValuePair.Value.e().a8().Location.b());
						double num3 = bui.a(keyValuePair.Value.e().aa(), amc.aa().Detection, keyValuePair.Value.e().aa().Skills.Get<a2n>().g(), (double)num2, (double)amc.aa().SightRange, a_3, a_2, amc.aa().Darkvision);
						if (num3 > 0.0 && (amc == null || (!amc.aa().SpecialStates.c && !amc.aa().SpecialStates.j)))
						{
							keyValuePair.Value.a().c(num3 * aiy.b4 * A_2.TotalMilliseconds);
							if (keyValuePair.Value.a().f() == cem.d)
							{
								keyValuePair.Value.a(true);
							}
						}
						else if (num3 < 0.0)
						{
							keyValuePair.Value.a().b(Math.Min(aiy.b6, Math.Abs(num3)) * aiy.b5 * A_2.TotalMilliseconds);
						}
					}
				}
				else
				{
					if (keyValuePair.Value.f() == h.a)
					{
						keyValuePair.Value.a().b(aiy.b5 * aiy.b6 * A_2.TotalMilliseconds);
					}
					else
					{
						keyValuePair.Value.a().a(cem.a);
						keyValuePair.Value.a().a(0.0);
					}
					if (keyValuePair.Value.a().f() == cem.a && keyValuePair.Value.a().c() == 0.0)
					{
						list.Add(keyValuePair.Key);
					}
				}
				if (serviceOrThrow.aqu() != null && keyValuePair.Value.a().f() == cem.d && keyValuePair.Value.e() != null && keyValuePair.Value.e().@as() && keyValuePair.Value.e().a8() != null && keyValuePair.Value.e().a8().i.b != null && amc != null && !amc.aa().Passive && amc.a8().a() && keyValuePair.Value.e().a8().a() && !string.IsNullOrEmpty(amc.aa().FactionId) && amc.aa().b(d8o.b | d8o.d | d8o.h) && num2 <= (float)Math.Min(4, num) && amc.aa().a(serviceOrThrow.aqu().ac(), keyValuePair.Value.e().aa().FactionId) != h.e && serviceOrThrow.aqu().ac().abt(keyValuePair.Value.e().aa().FactionId).h() && keyValuePair.Value.e().a8().i.b.a(m7.l).Count > 0)
				{
					awq.a(amc.a8(), keyValuePair.Value.e().a8(), false, false, false, true, false, false);
				}
			}
		}
		foreach (Guid key in list)
		{
			this.d.Remove(key);
		}
		int num4 = 0;
		int num5 = 0;
		bzv bzv = new bzv(A_0.y6());
		foreach (KeyValuePair<Guid, blk> keyValuePair2 in this.d)
		{
			if (keyValuePair2.Value.a().f() == cem.d && keyValuePair2.Value.e() != null)
			{
				bool? flag4;
				if (amc == null)
				{
					flag4 = null;
				}
				else
				{
					efk efk2 = amc.aa();
					flag4 = ((efk2 != null) ? new bool?(efk2.Truesighted) : null);
				}
				bool? flag2 = flag4;
				bool valueOrDefault = flag2.GetValueOrDefault();
				h h = bm.a8().h.b.aa().a(serviceOrThrow.aqu().ac(), keyValuePair2.Value.e().aa().FactionId);
				if (!keyValuePair2.Value.e().aa().Passive)
				{
					if (h <= h.b)
					{
						num5++;
					}
					if (h == h.a || amc.aa().FactionId == asp.e)
					{
						if (!(amc.aa() is e3q) && !amc.aa().Passive && !keyValuePair2.Value.e().aa().Passive && keyValuePair2.Value.e().a8().a())
						{
							if (bm.w() && !keyValuePair2.Value.b() && (!valueOrDefault || !this.c.Contains(keyValuePair2.Key)))
							{
								keyValuePair2.Value.a().a(cem.c);
								keyValuePair2.Value.a().a(aiy.b3[cem.c] / 2.0);
							}
							else if ((!bm.y6().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value && !bm.ad().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value) || !amc.aa().SpecialStates.g)
							{
								awq.a(amc, keyValuePair2.Value.e(), false, false, null, false, true, false, false);
							}
						}
						num4++;
					}
				}
			}
		}
		bzv.a(num4);
		bzv.b(num5);
	}

	// Token: 0x04000E06 RID: 3590
	public new static readonly string a = "Nb";

	// Token: 0x04000E07 RID: 3591
	private List<c5x> b;

	// Token: 0x04000E08 RID: 3592
	private HashSet<Guid> c;

	// Token: 0x04000E09 RID: 3593
	private Dictionary<Guid, blk> d;
}
