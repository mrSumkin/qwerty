using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001606 RID: 5638
[eiz("IX")]
[Serializable]
public sealed class aym : a6k, ISerializable
{
	// Token: 0x06007C0A RID: 31754 RVA: 0x00340C64 File Offset: 0x0033EE64
	private aym(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C0B RID: 31755 RVA: 0x00340C70 File Offset: 0x0033EE70
	public aym()
	{
	}

	// Token: 0x06007C0C RID: 31756 RVA: 0x00340C78 File Offset: 0x0033EE78
	protected override dc4 dt()
	{
		if (!(base.vg().h() is c5x))
		{
			return dc4.e;
		}
		return dc4.b;
	}

	// Token: 0x06007C0D RID: 31757 RVA: 0x00340C94 File Offset: 0x0033EE94
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		qy a_ = new qy();
		this.a(a_, base.vg().q(), c5x);
		c5x.Zone.ActionManager.g9(a_, atp.a);
		dz6.a(a_);
		if (egy.a(base.vg().q(), c5x))
		{
			eg2 eg = egy.a(base.vg().q());
			egy.a(eg);
			eg.b();
			qy qy = new qy();
			qy.ad().Add(new bm3(dz6.b(200)));
			this.a(qy, eg.a8(), c5x);
			c5x.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
		return dc4.c;
	}

	// Token: 0x06007C0E RID: 31758 RVA: 0x00340D94 File Offset: 0x0033EF94
	private void a(qy A_0, c5x A_1, c5x A_2)
	{
		A_0.b(false);
		A_0.c(false);
		awq.a(A_0, base.vg().q(), A_2, true, true);
		if (A_2.h.b != null)
		{
			cwt a_ = this.a(base.vg().q().h.b.aa(), A_2.h.b.aa());
			double a_2 = byu.a(base.vg().e());
			als item = new als(base.vg().q().h.b, A_2.h.b, a_, a_2, null);
			A_0.ad().Add(item);
			bfq bfq = new bfq();
			bfq.b("Implosion" + Guid.NewGuid().ToString());
			bfq.c("Implosion");
			A_0.ad().Add(new a4s(bfq, null, new ar7(A_2), null));
			eym.a(A_0, A_2, (double)aju.bh);
			string a_3 = "Implosion";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			bool a_5 = true;
			bool a_6 = true;
			float? a_7 = dz6.b();
			a7j item2 = new a7j(A_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
			A_0.ad().Add(item2);
		}
	}

	// Token: 0x06007C0F RID: 31759 RVA: 0x00340F00 File Offset: 0x0033F100
	private cwt a(efk A_0, efk A_1)
	{
		bas bas = A_0.Offense.ag()[PsiSchool.Psychokinesis];
		dxh.b(base.vg().e());
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = false;
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.l = true;
		cwt.m = true;
		cwt.k = "Имплозия";
		cwt.ad["PsionicSource"] = PsiSchool.Psychokinesis;
		return cwt;
	}
}
