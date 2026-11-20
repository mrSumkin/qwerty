using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020015DE RID: 5598
[eiz("L78")]
[Serializable]
public sealed class a4r : a6k, ISerializable
{
	// Token: 0x06007B6E RID: 31598 RVA: 0x0033973C File Offset: 0x0033793C
	private a4r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B6F RID: 31599 RVA: 0x00339748 File Offset: 0x00337948
	public a4r()
	{
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x00339754 File Offset: 0x00337954
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if ((base.vg().q() != null && base.vg().q().h.b != null && c5x == null) || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		qy.ad().Add(new a4s(new bfq("PsychokineticChainApplicationLaunch"), null, new ar7(base.vg().q()), null));
		awq.a(qy, base.vg().q(), c5x, true, true);
		int a_ = ari.a(base.vg().e());
		List<c5x> list = new List<c5x>
		{
			c5x
		};
		this.a(base.vg().q().h.b, list, a_, c5x.h.b.aa().FactionId);
		b0b b0b = null;
		for (int i = 0; i < list.Count; i++)
		{
			c5x c5x2 = list[i];
			c5x c5x3 = (i > 0) ? list[i - 1] : null;
			c5x c5x4 = (i < list.Count - 1) ? list[i + 1] : null;
			if (b0b == null)
			{
				dvv dvv = es2.a(base.vg().q(), c5x, "PsychokineticChain", 0.5f, null, out b0b, true, 0.5f);
				if (dvv == null)
				{
					return dc4.e;
				}
				c5x c5x5 = b0b as c5x;
				if (c5x5 != null && c5x5.o.b != null)
				{
					c5x5.o.b.g = new float?(0.95f);
				}
				qy.ad().Add(dvv);
			}
			else
			{
				Vector3 a_2 = c5x2.aj();
				bpr item = new bpr(b0b.GetAspect<mj>(), a_2);
				qy.ad().Add(item);
			}
			double a_3 = ari.c(base.vg().e());
			int a_4 = ari.b(base.vg().e());
			qy.ad().Add(new a4s(new bfq("PsychokineticChainApply"), null, new ar7(c5x2), null));
			qy.ad().Add(new amd(c5x2.h.b, new els[]
			{
				new ec4(ari.i, new ar7(base.vg().q()), (c5x3 != null) ? new ar7(c5x3) : null, (c5x4 != null) ? new ar7(c5x4) : null, a_3, a_4)
			}));
			qy.ad().Add(new a4s(new cxz("PsychokineticChain_SpawnCreationEffects"), null, new ar7(c5x2), null));
		}
		if (b0b != null)
		{
			qy.ad().Add(new c7(b0b, false, false, true, false));
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x06007B71 RID: 31601 RVA: 0x00339AAC File Offset: 0x00337CAC
	private void a(amc A_0, List<c5x> A_1, int A_2, string A_3)
	{
		c5x c5x = A_1[A_1.Count - 1];
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow2.aqu() != null)
		{
			c5x c5x2 = null;
			double num = 0.0;
			foreach (d4n d4n in serviceOrThrow.ahl())
			{
				if (d4n.b != null && d4n.b.a8() != null && !A_1.Contains(d4n.b.a8()) && d4n.b.a8().t.b != null && d4n.b.aa().FactionId != A_0.aa().FactionId && (d4n.b.aa().a(serviceOrThrow2.aqu().ac(), A_0.aa().FactionId) == h.a || d4n.b.aa().FactionId == A_3 || this.a(serviceOrThrow2, A_3, d4n.b.aa().FactionId)))
				{
					double num2 = aw1.b(d4n.b.a8(), c5x);
					if (num2 <= 5.0 && (c5x2 == null || num2 < num))
					{
						bool flag = false;
						foreach (ak1 a_ in c5x.l)
						{
							if (d4n.b.a8().t.b.a(a_))
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							c5x2 = d4n.b.a8();
							num = num2;
						}
					}
				}
			}
			if (c5x2 != null)
			{
				A_1.Add(c5x2);
				if (A_1.Count < A_2)
				{
					this.a(A_0, A_1, A_2, A_3);
				}
			}
		}
	}

	// Token: 0x06007B72 RID: 31602 RVA: 0x00339D0C File Offset: 0x00337F0C
	private bool a(cnk A_0, string A_1, string A_2)
	{
		if (A_0.aqu() != null)
		{
			cky cky = A_0.aqu().ac().abu(A_2, A_1);
			if (cky != null && cky.a == h.e)
			{
				h? b = cky.b;
				h h = h.a;
				if (b.GetValueOrDefault() == h & b != null)
				{
					return true;
				}
			}
		}
		return false;
	}
}
