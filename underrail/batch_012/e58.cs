using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001576 RID: 5494
[eiz("S29")]
[Serializable]
public sealed class e58 : d64, ISerializable
{
	// Token: 0x06007A31 RID: 31281 RVA: 0x00331B60 File Offset: 0x0032FD60
	private e58(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A32 RID: 31282 RVA: 0x00331B6C File Offset: 0x0032FD6C
	public e58()
	{
	}

	// Token: 0x06007A33 RID: 31283 RVA: 0x00331B78 File Offset: 0x0032FD78
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			double a_3;
			if (cwt.e)
			{
				a_3 = 1.0 + base.c().aa().Offense.am();
			}
			else
			{
				a_3 = 1.0;
			}
			int a_4 = eyv.a(base.vg().e().b9() as coh);
			cwt.f.Add(euf.a(a0e.a(base.vg().e().b8(), a_4), a_3));
			cwt.ad["IsAcidWeapon"] = true;
			awq.a(base.c(), base.b(), cwt, cd, new e58.a(this, a_4), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001577 RID: 5495
	[eiz("S29a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A34 RID: 31284 RVA: 0x00331D88 File Offset: 0x0032FF88
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S29a:P", typeof(e58)) as e58);
			this.b = A_0.GetInt32("S29a:O");
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00331DC4 File Offset: 0x0032FFC4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S29a:P", this.a);
			info.AddValue("S29a:O", this.b);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00331DE8 File Offset: 0x0032FFE8
		public a(e58 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00331E00 File Offset: 0x00330000
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				List<auv> list = dtb.ad();
				c5x a_ = A_1.a8();
				string a_2 = "AcidSplash";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(A_1.a8()), null));
				A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}

		// Token: 0x040030DC RID: 12508
		private e58 a;

		// Token: 0x040030DD RID: 12509
		private int b;
	}
}
