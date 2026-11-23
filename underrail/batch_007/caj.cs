using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9F RID: 8095
[ayj("PsiMentorConsumation")]
public sealed class caj : cxf
{
	// Token: 0x0600BE3B RID: 48699 RVA: 0x004189E4 File Offset: 0x00416BE4
	public override string y8()
	{
		return "PsiMentorConsumation";
	}

	// Token: 0x0600BE3C RID: 48700 RVA: 0x004189EC File Offset: 0x00416BEC
	public override string os()
	{
		return "PsiMentorConsumation";
	}

	// Token: 0x0600BE3D RID: 48701 RVA: 0x004189F4 File Offset: 0x00416BF4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE3F RID: 48703 RVA: 0x00418A00 File Offset: 0x00416C00
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE40 RID: 48704 RVA: 0x00418A04 File Offset: 0x00416C04
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE41 RID: 48705 RVA: 0x00418A08 File Offset: 0x00416C08
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BE42 RID: 48706 RVA: 0x00418A10 File Offset: 0x00416C10
	public override string bp(cnm A_0)
	{
		return "Использовать пси-наставника, чтобы отпечатать знание о пси-способности в вашем мозгу.";
	}

	// Token: 0x0600BE43 RID: 48707 RVA: 0x00418A18 File Offset: 0x00416C18
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		e3q e3q = A_0.b8() as e3q;
		if (e3q != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				eml eml = coh.Definition as eml;
				if (eml != null)
				{
					c3n c3n = dgk.a(eml.b());
					if (c3n is c7i && !e3q.PsiAbilities.c(c3n))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600BE44 RID: 48708 RVA: 0x00418A94 File Offset: 0x00416C94
	protected override int hi(cnm A_0)
	{
		return 0;
	}
}
