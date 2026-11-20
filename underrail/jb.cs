using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001FA1 RID: 8097
[ayj("BlueprintConsumation")]
public sealed class jb : cxf
{
	// Token: 0x0600BE4A RID: 48714 RVA: 0x00418AB8 File Offset: 0x00416CB8
	public override string y8()
	{
		return "Чертёж";
	}

	// Token: 0x0600BE4B RID: 48715 RVA: 0x00418AC0 File Offset: 0x00416CC0
	public override string os()
	{
		return "BlueprintConsumation";
	}

	// Token: 0x0600BE4C RID: 48716 RVA: 0x00418AC8 File Offset: 0x00416CC8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE4E RID: 48718 RVA: 0x00418AD4 File Offset: 0x00416CD4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE4F RID: 48719 RVA: 0x00418AD8 File Offset: 0x00416CD8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE50 RID: 48720 RVA: 0x00418ADC File Offset: 0x00416CDC
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BE51 RID: 48721 RVA: 0x00418AE4 File Offset: 0x00416CE4
	public override string bp(cnm A_0)
	{
		return "Загрузить чертёж в ваш наручный компьютер.";
	}

	// Token: 0x0600BE52 RID: 48722 RVA: 0x00418AEC File Offset: 0x00416CEC
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
				avz avz = coh.Definition as avz;
				if (avz != null)
				{
					jb.a a = new jb.a();
					a.a = d79.a(avz.b());
					return a.a != null && !Enumerable.Any<bdc>(e3q.d(), new Func<bdc, bool>(a.a));
				}
			}
		}
		return false;
	}

	// Token: 0x0600BE53 RID: 48723 RVA: 0x00418B80 File Offset: 0x00416D80
	public override bool cu(cnm A_0)
	{
		return true;
	}

	// Token: 0x0600BE54 RID: 48724 RVA: 0x00418B84 File Offset: 0x00416D84
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x02001FA2 RID: 8098
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600BE56 RID: 48726 RVA: 0x00418B90 File Offset: 0x00416D90
		internal bool a(bdc A_0)
		{
			return A_0.ao() == this.a;
		}

		// Token: 0x0400445B RID: 17499
		public cwp a;
	}
}
