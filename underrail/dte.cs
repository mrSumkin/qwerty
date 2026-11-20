using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001236 RID: 4662
[eiz("VDTSN")]
[Serializable]
public sealed class dte : c3r, ISerializable
{
	// Token: 0x06006486 RID: 25734 RVA: 0x002B1CE4 File Offset: 0x002AFEE4
	private dte(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (csk)A_0.GetValue("VDTSN:D", typeof(csk));
		this.b = A_0.GetBoolean("VDTSN:CH");
		this.c = A_0.GetBoolean("VDTSN:P");
		this.d = A_0.GetBoolean("VDTSN:IP");
	}

	// Token: 0x06006487 RID: 25735 RVA: 0x002B1D4C File Offset: 0x002AFF4C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VDTSN:D", this.a);
		info.AddValue("VDTSN:CH", this.b);
		info.AddValue("VDTSN:P", this.c);
		info.AddValue("VDTSN:IP", this.d);
	}

	// Token: 0x06006488 RID: 25736 RVA: 0x002B1DA4 File Offset: 0x002AFFA4
	public string sf()
	{
		if (this.a.DamageType != DamageType.Mechanical)
		{
			return "DamageType." + this.a.DamageType.ToString();
		}
		return null;
	}

	// Token: 0x06006489 RID: 25737 RVA: 0x002B1DE8 File Offset: 0x002AFFE8
	public string sg()
	{
		string text = "-" + this.a.Amount.ToString();
		if (this.b)
		{
			text += " Критический урон!";
		}
		return text;
	}

	// Token: 0x0600648A RID: 25738 RVA: 0x002B1E2C File Offset: 0x002B002C
	public Color sh()
	{
		return Color.Gray;
	}

	// Token: 0x0600648B RID: 25739 RVA: 0x002B1E34 File Offset: 0x002B0034
	public bool si()
	{
		return this.b;
	}

	// Token: 0x0600648C RID: 25740 RVA: 0x002B1E3C File Offset: 0x002B003C
	public ScrollingCombatTextOptions sj()
	{
		if (!this.c)
		{
			return ScrollingCombatTextOptions.Damage;
		}
		return ScrollingCombatTextOptions.PeriodicDamage;
	}

	// Token: 0x0600648D RID: 25741 RVA: 0x002B1E4C File Offset: 0x002B004C
	public dte(csk A_0, bool A_1, bool A_2, bool A_3)
	{
		this.d = A_3;
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04002A14 RID: 10772
	private csk a;

	// Token: 0x04002A15 RID: 10773
	private bool b;

	// Token: 0x04002A16 RID: 10774
	private bool c;

	// Token: 0x04002A17 RID: 10775
	private bool d;
}
