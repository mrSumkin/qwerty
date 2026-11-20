using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000464 RID: 1124
public sealed class e8q : adt
{
	// Token: 0x06001D3B RID: 7483 RVA: 0x000A213C File Offset: 0x000A033C
	public e8q(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000A2148 File Offset: 0x000A0348
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject == null || this.Subject.a8() == null || this.Subject.a8().k.b == null || this.Subject.a8().i.b == null)
		{
			return ej1.c;
		}
		if (this.a == null)
		{
			ar7 ar = this.Subject.y6()["lgTargetMushroom"] as ar7;
			if (ar == null)
			{
				return ej1.c;
			}
			c5x c5x = ar.ao() as c5x;
			if (c5x == null)
			{
				this.Subject.y6()["lgTargetMushroom"] = null;
				return ej1.c;
			}
			awx awx = new awx();
			awx.a(m7.b);
			fk fk = new fk(this.Subject.a8().k.b, c5x, null, false, 0);
			fk.c(5);
			fk.b(400);
			awx.ad().Add(fk);
			awx.ad().Add(new b2b(c5x));
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, 50, 0, null, 1));
			List<auv> list = awx.ad();
			bfq bfq = new bfq("chew", "ChewMushroom");
			bfq.a(bvl.b);
			list.Add(new a4s(bfq, new ar7(this.Subject.a8()), null, null));
			awx.ad().Add(new bm3(1000));
			awx.ad().Add(new b2b(c5x));
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, 50, 0, null, 1));
			List<auv> list2 = awx.ad();
			bfq bfq2 = new bfq("chew", "ChewMushroom");
			bfq2.a(bvl.b);
			list2.Add(new a4s(bfq2, new ar7(this.Subject.a8()), null, null));
			awx.ad().Add(new b9t(this.Subject.a8(), c5x.s.b, null));
			awx.ad().Add(new ec8(this.Subject));
			awx.ad().Add(new bm3(1000));
			awx.ad().Add(new b2b(c5x));
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, 50, 0, null, 1));
			List<auv> list3 = awx.ad();
			bfq bfq3 = new bfq("chew", "ChewMushroom");
			bfq3.a(bvl.b);
			list3.Add(new a4s(bfq3, new ar7(this.Subject.a8()), null, null));
			awx.ad().Add(new bm3(2000));
			this.a = awx;
			this.Subject.a8().i.b.b(awx, atp.a);
			return ej1.a;
		}
		else
		{
			if (this.a.State == dc4.c)
			{
				this.Subject.y6()["lgTargetMushroom"] = null;
				return ej1.b;
			}
			if (this.a.State == dc4.e || this.a.State == dc4.d)
			{
				this.Subject.y6()["lgTargetMushroom"] = null;
				return ej1.c;
			}
			return ej1.a;
		}
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x000A24C4 File Offset: 0x000A06C4
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.a = null;
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x000A24D0 File Offset: 0x000A06D0
	public override void ack()
	{
		if (this.a != null && this.a.State == dc4.b)
		{
			this.a.j();
			this.a = null;
		}
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x000A2500 File Offset: 0x000A0700
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6()["lgTargetMushroom"] != null;
	}

	// Token: 0x04001031 RID: 4145
	private auv a;
}
