using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016D0 RID: 5840
[eiz("ACX10")]
[Serializable]
public sealed class b5v : a6k, ISerializable
{
	// Token: 0x06007F29 RID: 32553 RVA: 0x0035D0E4 File Offset: 0x0035B2E4
	private b5v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F2A RID: 32554 RVA: 0x0035D0F0 File Offset: 0x0035B2F0
	public b5v()
	{
	}

	// Token: 0x06007F2B RID: 32555 RVA: 0x0035D0FC File Offset: 0x0035B2FC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		bool flag = c2h.a(base.vg().e());
		string str = flag ? "Rusting" : "";
		for (int i = 0; i < bdk.e; i++)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			qy.ad().Add(new bm3(dz6.b(i * 100)));
			b0b b0b = null;
			Vector3 vector = base.vg().q().Location + new Vector3(0f, 0f, 1.4f);
			Vector3 vector2 = c5x.Location + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, c5x.Size.Z / 2f - 0.3f + (float)cuo.a.NextDouble() * 0.6f);
			if (vector != vector2)
			{
				Vector3 value = vector2 - vector;
				value.Normalize();
				vector += value * 0.5f;
			}
			dvv item = es2.a(vector, vector2, c5x.Area, str + "AcidBlobSmall", null, out b0b);
			if (b0b != null && b0b.Zone != null)
			{
				bfq a_ = new bfq("AcidBlob");
				qy.ad().Add(new a4s(a_, null, new ar7(base.vg().q()), null));
				qy.ad().Add(item);
				c7 item2 = new c7(b0b, false, false, true, false);
				qy.ad().Add(item2);
				cwt cwt = new cwt();
				cwt.i = new ap9(base.vg().e().b8());
				cwt.j = new ap9(c5x.h.b.aa());
				cwt.b = !euf.b(base.vg().e().b8().Skills.Get<jk>().g(), c5x.h.b.aa());
				cwt.l = true;
				cwt.f.Add(bdk.b(base.vg().e()));
				cwt.ad["IsAcidWeapon"] = true;
				if (flag)
				{
					cwt.x = AmmoType.Vial_Acid_Rusting;
				}
				if (cwt.b)
				{
					bfq a_2 = new bfq("AcidFizz");
					qy.ad().Add(new a4s(a_2, null, new ar7(c5x), null));
					c5x a_3 = c5x;
					string a_4 = str + "acidSplash";
					int a_5 = 1;
					double maxValue = double.MaxValue;
					bool a_6 = true;
					bool a_7 = true;
					float? a_8 = dz6.b();
					a7j item3 = new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null);
					qy.ad().Add(item3);
					if (flag)
					{
						qy.ad().Add(new amd(c5x.h.b, new els[]
						{
							new ce()
						}));
					}
				}
				akg item4 = new akg(base.vg().q().h.b, c5x.h.b, cwt, null, false);
				qy.ad().Add(item4);
				ak1 ak = c5x.Area.a(c5x.aj().a());
				if (ak != null)
				{
					if (flag)
					{
						qy.ad().Add(new a4s(new amg(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b)), null, null, null));
					}
					else
					{
						qy.ad().Add(new a4s(new dku(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b), false, true, false), null, null, null));
					}
				}
				awq.a(qy, base.vg().q(), c5x, true, true);
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
		return dc4.c;
	}
}
