using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020016CE RID: 5838
[eiz("TGS0")]
[Serializable]
public sealed class bu5 : a6k, ISerializable
{
	// Token: 0x06007F23 RID: 32547 RVA: 0x0035CB58 File Offset: 0x0035AD58
	private bu5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F24 RID: 32548 RVA: 0x0035CB64 File Offset: 0x0035AD64
	public bu5()
	{
	}

	// Token: 0x06007F25 RID: 32549 RVA: 0x0035CB70 File Offset: 0x0035AD70
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		awx.b(false);
		awx.c(false);
		awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Custom1, dz6.b(80), 0, null, 1));
		awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Custom2, dz6.b(80), 0, null, 1));
		awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Custom3, dz6.b(80), 0, null, 1));
		base.vg().q().i.b.b(awx, atp.a);
		dz6.a(awx);
		for (int i = 0; i < azf.e; i++)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			qy.ad().Add(new bm3(dz6.b(1000 + i * 100)));
			b0b b0b = null;
			Vector3 vector = base.vg().q().Location + new Vector3(0f, 0f, 0.7f);
			Vector3 vector2 = c5x.Location + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, c5x.Size.Z / 2f - 0.3f + (float)cuo.a.NextDouble() * 0.6f);
			if (vector != vector2)
			{
				Vector3 value = vector2 - vector;
				value.Normalize();
				vector += value * 0.5f;
			}
			dvv item = es2.a(vector, vector2, c5x.Area, "TchortGooBlobSmall", null, out b0b);
			if (b0b != null && b0b.Zone != null)
			{
				((c5x)b0b).ae = new float?(0f);
				List<auv> list = qy.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(b0b), null));
				bfq a_ = new bfq("TchortGooBlob");
				qy.ad().Add(new a4s(a_, null, new ar7(base.vg().q()), null));
				qy.ad().Add(item);
				c7 item2 = new c7(b0b, false, false, true, false);
				qy.ad().Add(item2);
				cwt cwt = new cwt();
				cwt.i = new ap9(base.vg().e().b8());
				cwt.j = new ap9(c5x.h.b.aa());
				cwt.b = !euf.b(base.vg().e().b8().Skills.Get<jk>().g(), c5x.h.b.aa());
				cwt.l = true;
				cwt.f.Add(azf.a());
				if (cwt.b)
				{
					bfq a_2 = new bfq("TchortGooBlobBigHit");
					qy.ad().Add(new a4s(a_2, null, new ar7(c5x), null));
					c5x a_3 = c5x;
					string a_4 = "tchortGooSplash";
					int a_5 = 1;
					double maxValue = double.MaxValue;
					bool a_6 = true;
					bool a_7 = true;
					float? a_8 = dz6.b();
					a7j item3 = new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null);
					qy.ad().Add(item3);
				}
				akg item4 = new akg(base.vg().q().h.b, c5x.h.b, cwt, null, false);
				qy.ad().Add(item4);
				ak1 ak = c5x.Area.a(c5x.aj().a());
				if (ak != null)
				{
					qy.ad().Add(new a4s(new b9f(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b), true), null, null, null));
				}
				awq.a(qy, base.vg().q(), c5x, true, true);
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
		return dc4.c;
	}
}
