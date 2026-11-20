using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E84 RID: 7812
[ayj("HackUtility")]
public sealed class azb : m0
{
	// Token: 0x0600AE99 RID: 44697 RVA: 0x003FC5A4 File Offset: 0x003FA7A4
	public override string y8()
	{
		return "Хакерство...";
	}

	// Token: 0x0600AE9A RID: 44698 RVA: 0x003FC5AC File Offset: 0x003FA7AC
	public override string os()
	{
		return "Hacking";
	}

	// Token: 0x0600AE9B RID: 44699 RVA: 0x003FC5B4 File Offset: 0x003FA7B4
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE9C RID: 44700 RVA: 0x003FC5B8 File Offset: 0x003FA7B8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Hack);
	}

	// Token: 0x0600AE9D RID: 44701 RVA: 0x003FC5C4 File Offset: 0x003FA7C4
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AE9E RID: 44702 RVA: 0x003FC5C8 File Offset: 0x003FA7C8
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE9F RID: 44703 RVA: 0x003FC5CC File Offset: 0x003FA7CC
	public azb()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AEA0 RID: 44704 RVA: 0x003FC5E0 File Offset: 0x003FA7E0
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600AEA1 RID: 44705 RVA: 0x003FC5E4 File Offset: 0x003FA7E4
	public override string bm(cnm A_0)
	{
		return "Abilities.82";
	}

	// Token: 0x0600AEA2 RID: 44706 RVA: 0x003FC5EC File Offset: 0x003FA7EC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HackableObject;
	}

	// Token: 0x0600AEA3 RID: 44707 RVA: 0x003FC5F0 File Offset: 0x003FA7F0
	public override string bo(cnm A_0)
	{
		return "Пытается взломать компьютерное устройство.";
	}

	// Token: 0x0600AEA4 RID: 44708 RVA: 0x003FC5F8 File Offset: 0x003FA7F8
	public override string bp(cnm A_0)
	{
		int num = azb.b(A_0.b9());
		int num2 = azb.a(A_0.b9());
		string text = "Пытается взломать компьютерное устройство";
		if (num > 0)
		{
			text = text + ", увеличивая ваш навык хакерства на " + num.ToString();
		}
		text += string.Format(". Может быть использован для вскрытия электронных замков. Потребляет {0} очков энергии.", num2);
		if (A_0 != null && A_0.b8() != null)
		{
			text += string.Format(" С вашим действующим уровнем навыка хакерства вы можете взломать замок с рейтингом сложности до {0}, используя это устройство.", A_0.b8().Skills.Get<adx>().g() + num);
		}
		return text;
	}

	// Token: 0x0600AEA5 RID: 44709 RVA: 0x003FC694 File Offset: 0x003FA894
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AEA6 RID: 44710 RVA: 0x003FC69C File Offset: 0x003FA89C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AEA7 RID: 44711 RVA: 0x003FC6A8 File Offset: 0x003FA8A8
	public static int b(object A_0)
	{
		coh coh = A_0 as coh;
		if (coh != null)
		{
			int? num = null;
			if (coh.Definition != null && coh.Definition.a7() != null)
			{
				num = coh.Definition.a7().GetPrimitivePropertyValue<int>("HackingBonus", null);
			}
			if (num != null)
			{
				return num.Value;
			}
		}
		return 0;
	}

	// Token: 0x0600AEA8 RID: 44712 RVA: 0x003FC71C File Offset: 0x003FA91C
	public static int a(object A_0)
	{
		return 5 + azb.b(A_0);
	}

	// Token: 0x0600AEA9 RID: 44713 RVA: 0x003FC728 File Offset: 0x003FA928
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AEAA RID: 44714 RVA: 0x003FC72C File Offset: 0x003FA92C
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600AEAB RID: 44715 RVA: 0x003FC734 File Offset: 0x003FA934
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AEAC RID: 44716 RVA: 0x003FC73C File Offset: 0x003FA93C
	protected override float te(cnm A_0)
	{
		float num = 1f;
		if (A_0.b8() != null && A_0.b8().Feats.Contains<c3c>())
		{
			num -= c3c.a + (float)A_0.b8().GetSpecializationValue<awk>(true) * awk.a;
		}
		return base.te(A_0) * num;
	}

	// Token: 0x0600AEAD RID: 44717 RVA: 0x003FC794 File Offset: 0x003FA994
	protected override float cl(cnm A_0)
	{
		float num = 1f;
		if (A_0.b8() != null && A_0.b8().Feats.Contains<c3c>())
		{
			num -= c3c.a + (float)A_0.b8().GetSpecializationValue<awk>(true) * awk.a;
		}
		return base.cl(A_0) * num;
	}

	// Token: 0x0600AEAE RID: 44718 RVA: 0x003FC7EC File Offset: 0x003FA9EC
	protected override double q3(cnm A_0)
	{
		return (double)azb.a(A_0.b9());
	}

	// Token: 0x04004082 RID: 16514
	private new List<string> a;
}
