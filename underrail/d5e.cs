using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E66 RID: 7782
[ayj("Disembark")]
public sealed class d5e : c0z
{
	// Token: 0x0600AC91 RID: 44177 RVA: 0x003FA154 File Offset: 0x003F8354
	public override string y8()
	{
		return "Высадиться";
	}

	// Token: 0x0600AC92 RID: 44178 RVA: 0x003FA15C File Offset: 0x003F835C
	public override string os()
	{
		return "Disembark";
	}

	// Token: 0x0600AC93 RID: 44179 RVA: 0x003FA164 File Offset: 0x003F8364
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AC94 RID: 44180 RVA: 0x003FA168 File Offset: 0x003F8368
	public override string c1()
	{
		return "Высаживается";
	}

	// Token: 0x0600AC95 RID: 44181 RVA: 0x003FA170 File Offset: 0x003F8370
	public override int bh()
	{
		return int.MaxValue;
	}

	// Token: 0x0600AC96 RID: 44182 RVA: 0x003FA178 File Offset: 0x003F8378
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a
		};
	}

	// Token: 0x0600AC97 RID: 44183 RVA: 0x003FA18C File Offset: 0x003F838C
	public d5e()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AC98 RID: 44184 RVA: 0x003FA1A0 File Offset: 0x003F83A0
	public override TimelapseCursor? wz(object A_0, bool A_1 = false)
	{
		b49 service = bpo.GetService<b49>();
		if (service != null && service.yv(A_0))
		{
			return new TimelapseCursor?(TimelapseCursor.ForbiddenDisembark);
		}
		return new TimelapseCursor?(TimelapseCursor.Disembark);
	}

	// Token: 0x0600AC99 RID: 44185 RVA: 0x003FA1D4 File Offset: 0x003F83D4
	public override string bm(cnm A_0)
	{
		return "Abilities.70";
	}

	// Token: 0x0600AC9A RID: 44186 RVA: 0x003FA1DC File Offset: 0x003F83DC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DisembarkableSpot;
	}

	// Token: 0x0600AC9B RID: 44187 RVA: 0x003FA1E0 File Offset: 0x003F83E0
	public override string bo(cnm A_0)
	{
		return qv.b("Vehicle/Disembark");
	}

	// Token: 0x0600AC9C RID: 44188 RVA: 0x003FA1EC File Offset: 0x003F83EC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AC9D RID: 44189 RVA: 0x003FA1F8 File Offset: 0x003F83F8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AC9E RID: 44190 RVA: 0x003FA200 File Offset: 0x003F8400
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AC9F RID: 44191 RVA: 0x003FA208 File Offset: 0x003F8408
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600ACA0 RID: 44192 RVA: 0x003FA20C File Offset: 0x003F840C
	public override bool c3(cnm A_0)
	{
		return true;
	}

	// Token: 0x0600ACA1 RID: 44193 RVA: 0x003FA214 File Offset: 0x003F8414
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null) && (A_0.b8().Vehicle.y() == bws.b || A_0.b8().Vehicle.y() == bws.a);
	}

	// Token: 0x0600ACA2 RID: 44194 RVA: 0x003FA280 File Offset: 0x003F8480
	protected override int hi(cnm A_0)
	{
		int num = 40;
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().Feats.Contains<ej3>())
			{
				num -= ej3.c;
			}
			if (A_0.b8().Feats.Contains<duv>())
			{
				num -= duv.c;
			}
		}
		return num;
	}

	// Token: 0x0600ACA3 RID: 44195 RVA: 0x003FA2DC File Offset: 0x003F84DC
	protected override int br(cnm A_0)
	{
		return 2000;
	}

	// Token: 0x0600ACA4 RID: 44196 RVA: 0x003FA2E4 File Offset: 0x003F84E4
	protected override float f0(cnm A_0)
	{
		return 2f;
	}

	// Token: 0x04004049 RID: 16457
	private new List<string> a;
}
