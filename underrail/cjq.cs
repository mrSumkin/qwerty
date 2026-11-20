using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E85 RID: 7813
[ayj("LockpickUtility")]
public sealed class cjq : m0
{
	// Token: 0x0600AEAF RID: 44719 RVA: 0x003FC7FC File Offset: 0x003FA9FC
	public override string y8()
	{
		return "Взлом замка...";
	}

	// Token: 0x0600AEB0 RID: 44720 RVA: 0x003FC804 File Offset: 0x003FAA04
	public override string os()
	{
		return "Lockpicking";
	}

	// Token: 0x0600AEB1 RID: 44721 RVA: 0x003FC80C File Offset: 0x003FAA0C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AEB2 RID: 44722 RVA: 0x003FC810 File Offset: 0x003FAA10
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Lockpick);
	}

	// Token: 0x0600AEB3 RID: 44723 RVA: 0x003FC81C File Offset: 0x003FAA1C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AEB4 RID: 44724 RVA: 0x003FC820 File Offset: 0x003FAA20
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AEB5 RID: 44725 RVA: 0x003FC824 File Offset: 0x003FAA24
	public cjq()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AEB6 RID: 44726 RVA: 0x003FC838 File Offset: 0x003FAA38
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600AEB7 RID: 44727 RVA: 0x003FC83C File Offset: 0x003FAA3C
	public override string bm(cnm A_0)
	{
		return "Abilities.81";
	}

	// Token: 0x0600AEB8 RID: 44728 RVA: 0x003FC844 File Offset: 0x003FAA44
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LockableObject;
	}

	// Token: 0x0600AEB9 RID: 44729 RVA: 0x003FC848 File Offset: 0x003FAA48
	public override string bo(cnm A_0)
	{
		return "Пытается вскрыть механический замок.";
	}

	// Token: 0x0600AEBA RID: 44730 RVA: 0x003FC854 File Offset: 0x003FAA54
	public override string bp(cnm A_0)
	{
		int num = cjq.a(A_0.b9());
		string text = "Пытается вскрыть механический замок";
		if (num > 0)
		{
			text = text + ", увеличивая ваш навык взлома замков на " + num.ToString();
		}
		text += ".";
		if (A_0 != null && A_0.b8() != null)
		{
			text += string.Format(" С вашим действующим уровнем навыка взлом замков вы можете взломать замок с рейтингом сложности до {0}, используя эту отмычку.", A_0.b8().Skills.Get<dca>().g() + num);
		}
		return text;
	}

	// Token: 0x0600AEBB RID: 44731 RVA: 0x003FC8D8 File Offset: 0x003FAAD8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AEBC RID: 44732 RVA: 0x003FC8E0 File Offset: 0x003FAAE0
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AEBD RID: 44733 RVA: 0x003FC8EC File Offset: 0x003FAAEC
	public static int a(object A_0)
	{
		coh coh = A_0 as coh;
		if (coh != null)
		{
			int? num = null;
			if (coh.Definition != null && coh.Definition.a7() != null)
			{
				num = coh.Definition.a7().GetPrimitivePropertyValue<int>("LockpickBonus", null);
			}
			if (num != null)
			{
				return num.Value;
			}
		}
		return 0;
	}

	// Token: 0x0600AEBE RID: 44734 RVA: 0x003FC960 File Offset: 0x003FAB60
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AEBF RID: 44735 RVA: 0x003FC964 File Offset: 0x003FAB64
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600AEC0 RID: 44736 RVA: 0x003FC96C File Offset: 0x003FAB6C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AEC1 RID: 44737 RVA: 0x003FC978 File Offset: 0x003FAB78
	protected override float te(cnm A_0)
	{
		float num = 1f;
		if (A_0.b8() != null && A_0.b8().Feats.Contains<c3c>())
		{
			num -= c3c.a + (float)A_0.b8().GetSpecializationValue<awk>(true) * awk.a;
		}
		return base.te(A_0) * num;
	}

	// Token: 0x0600AEC2 RID: 44738 RVA: 0x003FC9D0 File Offset: 0x003FABD0
	protected override float cl(cnm A_0)
	{
		float num = 1f;
		if (A_0.b8() != null && A_0.b8().Feats.Contains<c3c>())
		{
			num -= c3c.a + (float)A_0.b8().GetSpecializationValue<awk>(true) * awk.a;
		}
		return base.cl(A_0) * num;
	}

	// Token: 0x04004083 RID: 16515
	private new List<string> a;
}
